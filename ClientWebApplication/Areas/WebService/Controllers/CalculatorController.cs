using ClientWebApplication.Areas.WebService.Data.ViewModels;
using ClientWebApplication.CalculatorService;
using ClientWebApplication.CalculatorServiceWCF;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            List<string> model = model = client.GetCalculations();

            return View(model);
        }

        public PartialViewResult Add(int firstNumber, int secondNumber)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            AddViewModel model = new AddViewModel();
            model.Result = client.Add(firstNumber: firstNumber, secondNumber: secondNumber);
            model.RecentCalculations = client.GetCalculations();

            return PartialView("Add", model);
        }
        // WebServices Above

        // WCF SERVICES BELOW
        public ActionResult IndexWCF()
        {
            return View();
        }

        public PartialViewResult Divide(int numerator, int denominator)
        {
            CalculatorServiceWCFClient client = new CalculatorServiceWCFClient();
            int result = client.Divide(numerator, denominator);

            return PartialView("Divide", result);
        }
    }
}