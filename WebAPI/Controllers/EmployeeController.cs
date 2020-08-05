using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<tblEmployees> Get()
        {
            List<tblEmployees> employees;
            using(Entities db = new Entities())
            {
                employees = db.tblEmployees.ToList();
            }
            return employees;
        }

        public tblEmployees Get(int id)
        {
            using (Entities db = new Entities())
            {
                return db.tblEmployees.FirstOrDefault(x => x.ID == id);
            }
        }

        public void Put(tblEmployees employeeModyfied)
        {
            using (Entities db = new Entities())
            {
                tblEmployees employee = db.tblEmployees.Find(employeeModyfied.ID);
                employee.FirstName = employeeModyfied.FirstName;
                employee.LastName = employeeModyfied.LastName;
                employee.Gender = employeeModyfied.Gender;
                employee.Salary = employeeModyfied.Salary;

                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Post(tblEmployees employee)
        {
            using (Entities db = new Entities())
            {
                db.tblEmployees.Add(employee);
            }
        }

        public void Delete(int id)
        {
            using (Entities db = new Entities())
            {
                tblEmployees employee = db.tblEmployees.Find(id);
                if (employee != null)
                {
                    db.tblEmployees.Remove(employee);
                }
            }
        }
    }
}
