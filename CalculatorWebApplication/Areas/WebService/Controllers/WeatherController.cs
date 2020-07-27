using CalculatorWebApplication.WeatherService;
using System.Web.Mvc;

namespace CalculatorWebApplication.Areas.WebService.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetWeatherByZipCode(string zipCode)
        {
            WeatherSoapClient client = new WeatherSoapClient();
            WeatherReturn weather = client.GetCityWeatherByZIP(zipCode);

            return PartialView(weather);
        }
    }
}