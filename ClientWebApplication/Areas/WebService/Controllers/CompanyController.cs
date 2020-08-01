using ClientWebApplication.CompanyService;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetPublicInformation()
        {
            CompanyPublicServiceClient client = new CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            string information = client.GetPublicInformation();

            return PartialView("GetPublicInformation", information);
        }

        public PartialViewResult GetConfidentialInformation()
        {
            CompanyConfidentalServiceClient client = new CompanyConfidentalServiceClient("NetTcpBinding_ICompanyConfidentalService");
            string information = client.GetConfidentalInformation();

            return PartialView("GetConfidentialInformation", information);
        }
    }
}