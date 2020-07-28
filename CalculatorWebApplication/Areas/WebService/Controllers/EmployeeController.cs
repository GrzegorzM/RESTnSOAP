using ClientWebApplication.EmployeeService;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetEmployee(int id)
        {
            EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            Employee employee = client.GetEmployee(id);

            return PartialView("GetEmployee", employee);
        }

        public PartialViewResult SaveEmployee(Employee employee)
        {
            EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            client.SaveEmployee(employee);

            return PartialView("SaveEmployee", true);
        }
    }
}