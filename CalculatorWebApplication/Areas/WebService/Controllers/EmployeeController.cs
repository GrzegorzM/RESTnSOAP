using ClientWebApplication.EmployeeService;
using System;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            //var model = new PartTimeEmployee();
            //var model = new FullTimeEmployee();
            //return View("Index", model);
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

        public PartialViewResult GetEmployeeKnownType(int id)
        {
            EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            EmployeeKnownType employee = client.GetEmployeeKnownType(id);

            return PartialView("GetEmployee", employee);
        }

        public PartialViewResult SaveEmployeeKnownType(EmployeeKnownType employee, FormCollection formCollection)
        {
            EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            EmployeeKnownType employeeKnownType = new EmployeeKnownType();
            bool result = false;

            if ((int)employee.EmployeeType == 1)
            {
                employeeKnownType = new FullTimeEmployee()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Gender = employee.Gender,
                    DateOfBirth = employee.DateOfBirth,
                    EmployeeType = employee.EmployeeType,
                    AnnualSalary = Convert.ToInt32(formCollection["AnnualSalary"])
                };
            }
            else if ((int)employee.EmployeeType == 2)
            {
                employeeKnownType = new PartTimeEmployee()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Gender = employee.Gender,
                    DateOfBirth = employee.DateOfBirth,
                    EmployeeType = employee.EmployeeType,
                    HourlyPay = Convert.ToInt32(formCollection["HourlyPay"]),
                    HoursWorked = Convert.ToInt32(formCollection["HoursWorked"])
                };
            }

            try
            {
                client.SaveEmployeeKnownType(employeeKnownType);
                result = true;
            }
            catch(Exception ex)
            {

            }

            return PartialView("SaveEmployee", result);
        }
    }
}