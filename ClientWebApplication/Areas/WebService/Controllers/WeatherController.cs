using ClientWebApplication.WeatherService;
using System;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetWeatherByZipCode(string zipCode)
        {
            WeatherReturn weather;
            try
            {
                //WeatherSoapClient client = new WeatherSoapClient(); // Error - more than one endpoint in web.config
                WeatherSoapClient client = new WeatherSoapClient("WeatherSoap"); 
                weather = client.GetCityWeatherByZIP(zipCode); //System.ServiceModel.FaultException: 'Server was unable to process request. ---> A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: Named Pipes Provider, error: 40 - Could not open a connection to SQL Server)'
            
                if (!weather.Success)
                    weather = null;
            }
            catch(Exception ex)
            {
                weather = null;
            }

            return PartialView(weather);
        }
    }
}