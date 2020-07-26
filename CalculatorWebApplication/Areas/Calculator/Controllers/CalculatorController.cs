using CalculatorWebApplication.Areas.Calculator.Data.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace CalculatorWebApplication.Areas.Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
            List<string> model = model = client.GetCalculations();

            return View(model);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult Add(int firstNumber, int secondNumber)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
            AddViewModel model = new AddViewModel();
            model.Result = client.Add(firstNumber: firstNumber, secondNumber: secondNumber);
            model.RecentCalculations = client.GetCalculations();

            return PartialView("Add", model);
        }
    }
}