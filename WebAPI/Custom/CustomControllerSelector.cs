using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;

namespace WebAPI.Custom
{
    public class CustomControllerSelector : DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration configuration;

        public CustomControllerSelector(HttpConfiguration configuration) : base(configuration)
        {
            this.configuration = configuration;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            string versionNumber = "1";

            // Querystring versioning --> https://localhost:44306/api/students?v=2
            //NameValueCollection versionQueryString = HttpUtility.ParseQueryString(request.RequestUri.Query);
            //if (versionQueryString["v"] != null)
            //{
            //    versionNumber = versionQueryString["v"];
            //}

            // Custom header versioning --> X-StudentService-Version: 2
            //string customHeader = "X-StudentService-Version";
            //if (request.Headers.Contains(customHeader))
            //{
            //    versionNumber = request.Headers.GetValues(customHeader).FirstOrDefault();
            //}

            // Accept Header versioning --> Accept: application/json; version=2 
            // It even works with multiple accepted headers or multiple version values --> application/json; version=2; version=1; version=-2)
            //IEnumerable<MediaTypeWithQualityHeaderValue> acceptHeaders = request.Headers.Accept.Where(x => x.Parameters.Count(y => y.Name.ToLower() == "version") > 0);
            //if (acceptHeaders.Any())
            //{
            //    versionNumber = acceptHeaders.First().Parameters.First(x => x.Name.ToLower() == "version").Value;
            //}

            // Custom MediaType Accept Header versioning --> application/vnd.company_name.students.v1+json
            //string regex = @"application\/vnd\.company_name\.([a-z]+)\.v([0-9]+)\+([a-z]+)";
            string regex = @"application\/vnd\.company_name\.([a-z]+)\.v(?<version>[0-9]+)\+([a-z]+)";
            IEnumerable<MediaTypeWithQualityHeaderValue> acceptHeaders = request.Headers.Accept.Where(x => Regex.IsMatch(x.MediaType, regex, RegexOptions.IgnoreCase));
            if (acceptHeaders.Any())
            {
                Match match = Regex.Match(acceptHeaders.First().MediaType, regex, RegexOptions.IgnoreCase);
                versionNumber = match.Groups["version"].Value;
                //versionNumber = match.Groups[2].Value;
            }

            IHttpRouteData routeData = request.GetRouteData();
            string controllerName = routeData.Values["controller"].ToString();
            if (controllerName.Equals("students", System.StringComparison.OrdinalIgnoreCase))
            {
                switch (versionNumber)
                {
                    case "1":
                        controllerName = "Students";
                        break;
                    case "2":
                        controllerName = "StudentsV2";
                        break;
                    default:
                        controllerName = "Students";
                        break;
                }
            }

            HttpControllerDescriptor controllerDescriptor;
            IDictionary<string, HttpControllerDescriptor> controllers = GetControllerMapping();
            if (controllers.TryGetValue(controllerName, out controllerDescriptor))
            {
                return controllerDescriptor;
            }

            return null;
        }
    }
}