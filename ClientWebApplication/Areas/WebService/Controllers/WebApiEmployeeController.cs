using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class WebApiEmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Employees()
        {
            return View();
        }
    }
}