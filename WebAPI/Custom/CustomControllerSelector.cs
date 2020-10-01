using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
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

            // Querystring versioning - https://localhost:44306/api/students?v=2
            //NameValueCollection versionQueryString = HttpUtility.ParseQueryString(request.RequestUri.Query);
            //if (versionQueryString["v"] != null)
            //{
            //    versionNumber = versionQueryString["v"];
            //}

            // Header versioning - X-StudentService-Version: 1
            string customHeader = "X-StudentService-Version";
            if (request.Headers.Contains(customHeader))
            {
                versionNumber = request.Headers.GetValues(customHeader).FirstOrDefault();
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