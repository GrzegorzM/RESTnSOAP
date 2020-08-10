using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        //public HttpResponseMessage Get()
        //public HttpResponseMessage GetEmployees()
        [HttpGet]
        public HttpResponseMessage LoadAllEmployees()
        {
            try
            {
                List<tblEmployees> employees;
                using (Entities db = new Entities())
                {
                    employees = db.tblEmployees.ToList();
                }
                if(employees.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, employees);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "No data to display");
                }
                
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
                //return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        //public List<tblEmployees> Get()
        //{
        //    List<tblEmployees> employees;
        //    using(Entities db = new Entities())
        //    {
        //        employees = db.tblEmployees.ToList();
        //    }
        //    return employees;
        //}

        [HttpGet]
        public HttpResponseMessage LoadEMployeeById(int id)
        //public HttpResponseMessage Get(int id)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    tblEmployees employee = db.tblEmployees.FirstOrDefault(x => x.Id == id);

                    if (employee != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, employee);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, $"Employee with Id = {id} not found");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        //public tblEmployees Get(int id)
        //{
        //    using (Entities db = new Entities())
        //    {
        //        return db.tblEmployees.FirstOrDefault(x => x.Id == id);
        //    }
        //}

        public HttpResponseMessage Put([FromBody]tblEmployees employeeModyfied)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    tblEmployees employee = db.tblEmployees.Find(employeeModyfied.Id);
                    if (employee != null)
                    {
                        employee.FirstName = employeeModyfied.FirstName;
                        employee.LastName = employeeModyfied.LastName;
                        employee.Gender = employeeModyfied.Gender;
                        employee.Salary = employeeModyfied.Salary;

                        db.Entry(employee).State = EntityState.Modified;
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, employee);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, $"Employee with Id = {employeeModyfied.Id} not found");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        //public void Put([FromBody]tblEmployees employeeModyfied)
        //{
        //        using (Entities db = new Entities())
        //        {
        //            tblEmployees employee = db.tblEmployees.Find(employeeModyfied.Id);
        //            employee.FirstName = employeeModyfied.FirstName;
        //            employee.LastName = employeeModyfied.LastName;
        //            employee.Gender = employeeModyfied.Gender;
        //            employee.Salary = employeeModyfied.Salary;

        //            db.Entry(employee).State = EntityState.Modified;
        //            db.SaveChanges();
        //        }
        //}

        public HttpResponseMessage Post([FromBody]tblEmployees employee)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.tblEmployees.Add(employee);
                    db.SaveChanges();

                    HttpResponseMessage message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri($"{Request.RequestUri}/{employee.Id}");

                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        //public void Post([FromBody]tblEmployees employee)
        //{
        //    using (Entities db = new Entities())
        //    {
        //        db.tblEmployees.Add(employee);
        //        db.SaveChanges();
        //    }
        //}

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    tblEmployees employee = db.tblEmployees.Find(id);
                    if (employee != null)
                    {
                        db.tblEmployees.Remove(employee);
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, $"Employee with Id = {id} not found to delete");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        //public void Delete(int id)
        //{
        //    using (Entities db = new Entities())
        //    {
        //        tblEmployees employee = db.tblEmployees.Find(id);
        //        if (employee != null)
        //        {
        //            db.tblEmployees.Remove(employee);
        //            db.SaveChanges();
        //        }
        //    }
        //}
    }
}
