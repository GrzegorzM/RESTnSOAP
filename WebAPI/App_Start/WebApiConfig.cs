using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Dispatcher;
using WebAPI.Custom;
using WebApiContrib.Formatting.Jsonp;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "StudentV2Api",
            //    routeTemplate: "api/v2/students/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "StudentsV2" }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IHttpControllerSelector), new CustomControllerSelector(config));

            // Removing Json respose format so API can support only XML
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            // Web browser send accept header as "text/html" thats why XML is returned. Changing default format returned by browsers to JSON but leaving accept header as "text/html" what is missleading.
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Add custom JSON Formatter to handle dafault accept header "text/html" used by browsers
            //config.Formatters.Add(new CustomJsonFormatter());
            config.Formatters.Add(new CSVMediaTypeFormatter(new QueryStringMapping("format", "csv", "text/csv")));

            // Setting camel case for Json response
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Allow using ajax in a cross domain
            JsonpMediaTypeFormatter jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            config.Formatters.Add(jsonpFormatter);

            //// Enables and activates CORS settings globally, * - all
            ////EnableCorsAttribute enableCorsAttribute = new EnableCorsAttribute("*", "*", "GET, POST");
            //EnableCorsAttribute enableCorsAttribute = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(enableCorsAttribute);

            //// Enables and does not activate CORS settings in the application. Use [EnableCorsAttribute] attributes on WebApi Controllers to activate.
            //config.EnableCors();

            config.Filters.Add(new RequireHttpsAttribute());
        }
    }
}