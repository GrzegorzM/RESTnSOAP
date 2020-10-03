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
            //client.SaveEmployee(employee);
            client.SaveEmployee(employee, null, null, null);

            return PartialView("SaveEmployee", true);
        }

        public PartialViewResult GetEmployeeKnownType(int id)
        {
            //EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            //EmployeeKnownType employee = client.GetEmployeeKnownType(id);
            IEmployeeService client = new EmployeeServiceClient();
            EmployeeRequest request = new EmployeeRequest(LicenseKey: "ASCX4534DXZC", EmployeeId: id);
            EmployeeInfo employeeInfo = client.GetEmployeeKnownType(request);
            EmployeeKnownType employee = null;

            if(employeeInfo.EmployeeType == EmployeeType.Null)
            {
                return PartialView("GetEmployee", null);
            }

            if(employeeInfo.EmployeeType == EmployeeType.FullTimeEmployee)
            {
                employee = new FullTimeEmployee()
                {
                    AnnualSalary = employeeInfo.AnnualSalary
                };
            }
            else if(employeeInfo.EmployeeType == EmployeeType.PartTimeEmployee)
            {
                employee = new PartTimeEmployee()
                {
                    HourlyPay = employeeInfo.HourlyPay,
                    HoursWorked = employeeInfo.HoursWorked
                };
            }
            employee.Id = employeeInfo.Id;
            employee.Name = employeeInfo.Name;
            employee.Gender = employeeInfo.Gender;
            employee.DateOfBirth = employeeInfo.DOB;
            employee.EmployeeType = employeeInfo.EmployeeType;

            return PartialView("GetEmployee", employee);
        }

        public PartialViewResult SaveEmployeeKnownType(EmployeeKnownType employee, FormCollection formCollection)
        {
            //EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            //EmployeeKnownType employeeKnownType = new EmployeeKnownType();
            IEmployeeService client = new EmployeeServiceClient();
            EmployeeInfo employeeKnownType = new EmployeeInfo();
            bool result = false;

            if ((int)employee.EmployeeType == 1)
            {
                //employeeKnownType = new FullTimeEmployee()
                //{
                //    Id = employee.Id,
                //    Name = employee.Name,
                //    Gender = employee.Gender,
                //    DateOfBirth = employee.DateOfBirth,
                //    EmployeeType = employee.EmployeeType,
                //    AnnualSalary = Convert.ToInt32(formCollection["AnnualSalary"])
                //};
                employeeKnownType.EmployeeType = EmployeeType.FullTimeEmployee;
                employeeKnownType.AnnualSalary = Convert.ToInt32(formCollection["AnnualSalary"]);
            }
            else if ((int)employee.EmployeeType == 2)
            {
                //employeeKnownType = new PartTimeEmployee()
                //{
                //    Id = employee.Id,
                //    Name = employee.Name,
                //    Gender = employee.Gender,
                //    DateOfBirth = employee.DateOfBirth,
                //    EmployeeType = employee.EmployeeType,
                //    HourlyPay = Convert.ToInt32(formCollection["HourlyPay"]),
                //    HoursWorked = Convert.ToInt32(formCollection["HoursWorked"])
                //};
                employeeKnownType.EmployeeType = employee.EmployeeType;
                employeeKnownType.HourlyPay = Convert.ToInt32(formCollection["HourlyPay"]);
                employeeKnownType.HoursWorked = Convert.ToInt32(formCollection["HoursWorked"]);
            }

            employeeKnownType.Id = employee.Id;
            employeeKnownType.Name = employee.Name;
            employeeKnownType.Gender = employee.Gender;
            employeeKnownType.DOB = employee.DateOfBirth;
            employeeKnownType.EmployeeType = employee.EmployeeType;

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