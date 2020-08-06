using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Custom
{
    public class CSVMediaTypeFormatter : MediaTypeFormatter
    {
        public CSVMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/csv"));

            // Character encodings - Default first
            SupportedEncodings.Add(new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
            SupportedEncodings.Add(Encoding.GetEncoding("iso-8859-1"));
        }

        public CSVMediaTypeFormatter(MediaTypeMapping mediaTypeMapping) : this()
        {
            MediaTypeMappings.Add(mediaTypeMapping);
        }

        public CSVMediaTypeFormatter(IEnumerable<MediaTypeMapping> mediaTypeMappings) : this()
        {
            foreach (MediaTypeMapping mediaTypeMapping in mediaTypeMappings)
            {
                MediaTypeMappings.Add(mediaTypeMapping);
            }
        }

        // CSV Formatter does not support deserialization so the method simply returns false.
        public override bool CanReadType(Type type)
        {
            return false;
        }

        // Check if type passed to the method is a collection. There is no point of generating a csv file for single data row.
        public override bool CanWriteType(Type type)
        {
            if (type == null)
                throw new ArgumentException("type");

            return IsTypeOfEnumerable(type);
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            //WriteStream(type, value, writeStream, content);
            //TaskCompletionSource<int> task = new TaskCompletionSource<int>();
            //task.SetResult(0);

            //return task.Task;

            return Task.Factory.StartNew(() =>
            {
                WriteStream(type, value, writeStream, content);
            });
        }

        private void WriteStream(Type type, object value, Stream stream, HttpContent httpContentHeader)
        {
            Type itemType = type.GetGenericArguments()[0];
            StringWriter stringWriter = new StringWriter();
            stringWriter.WriteLine(string.Join<string>(",", itemType.GetProperties().Select(x => x.Name)));

            foreach (object item in (IEnumerable<object>)value)
            {
                IEnumerable<object> values = item.GetType().GetProperties().Select(x => x.GetValue(item, null));

                string valueLine = string.Empty;

                foreach (object valueObj in values)
                {
                    if (valueObj != null)
                    {
                        string valueString = valueObj.ToString();

                        if (valueString.Contains(","))
                        {
                            valueString = string.Concat("\"", valueString, "\"");
                        }
                        if (valueString.Contains("\r"))
                        {
                            valueString = valueString.Replace("\r", " ");
                        }
                        if (valueString.Contains("\n"))
                        {
                            valueString = valueString.Replace("\n", " ");
                        }

                        valueLine = string.Concat(valueLine, valueString, ",");
                    }
                    else
                    {
                        valueLine = string.Concat(string.Empty, ",");
                    }
                }

                stringWriter.WriteLine(valueLine.TrimEnd(','));
            }

            Encoding effectiveEncoding = SelectCharacterEncoding(httpContentHeader.Headers);
            StreamWriter streamWriter = new StreamWriter(stream, effectiveEncoding);
            streamWriter.Write(stringWriter.ToString());
            streamWriter.Flush();
            streamWriter.Close();
        }

        private bool IsTypeOfEnumerable(Type type)
        {
            foreach (Type interfaceType in type.GetInterfaces())
            {
                if (interfaceType == typeof(IEnumerable))
                    return true;
            }

            return false;
        }
    }
}