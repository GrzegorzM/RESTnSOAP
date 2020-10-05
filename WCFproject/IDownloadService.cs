using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFproject
{
    [ServiceContract]
    public interface IDownloadService
    {
        [OperationContract]
        File DownloadDocument();
    }

    [DataContract]
    public class File 
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Content { get; set; }
    }
}