using ClientWebApplication.StudentService;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetStudentById(int id)
        {
            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            Student student = client.GetStudentById(id);

            return PartialView(student);
        }
    }
}