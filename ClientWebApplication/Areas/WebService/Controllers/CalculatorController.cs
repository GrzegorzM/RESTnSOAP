using ClientWebApplication.Areas.WebService.Data.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
            List<string> model = model = client.GetCalculations();

            return View(model);
        }

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