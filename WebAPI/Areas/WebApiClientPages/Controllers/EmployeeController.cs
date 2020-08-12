using System.Web.Mvc;

namespace WebAPI.Areas.WebApiClientPages.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {


            return View();
        }
    }
}