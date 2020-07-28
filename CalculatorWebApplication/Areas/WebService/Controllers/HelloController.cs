using ClientWebApplication.HelloService;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetMessage(string name)
        {
            HelloServiceClient client = new HelloServiceClient("BasicHttpBinding_IHelloService");
            string message = client.GetMessage(name);

            return PartialView("GetMessage", message);
        }
    }
}