using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Custom;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //[EnableCorsAttribute("*", "*", "*")]
    //[RequireHttps]
    [Authorize]
    public class EmployeeController : ApiController
    {
        //[DisableCors]
        //https://localhost:44306/api/employee?gender=female
        //[BasicAuthentication]
        public HttpResponseMessage Get(string gender = "All")
        {
            try
            {
                List<tblEmployees> employees;
                gender = gender.ToLower();

                string username = Thread.CurrentPrincipal.Identity.Name.ToLower();

                using (Entities db = new Entities())
                {
                    //switch (gender)
                    switch (username)
                    {
                        case "all":
                            employees = db.tblEmployees.ToList();
                            break;
                        case "male":
                            employees = db.tblEmployees.Where(x => x.Gender.ToLower() == username).ToList();
                            //employees = db.tblEmployees.Where(x => x.Gender.ToLower() == gender).ToList();
                            break;
                        case "female":
                            employees = db.tblEmployees.Where(x => x.Gender.ToLower() == username).ToList();
                            //employees = db.tblEmployees.Where(x => x.Gender.ToLower() == gender).ToList();
                            break;
                        default:
                            return Request.CreateResponse(HttpStatusCode.BadRequest);
                            //return Request.CreateResponse(HttpStatusCode.BadRequest, $"Value for gender must be All, Male or Female. {gender} is invalid.");
                    }
                }

                if (employees.Count > 0)
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
            }
        }

        ////public HttpResponseMessage Get()
        ////public HttpResponseMessage GetEmployees()
        //[HttpGet]
        //public HttpResponseMessage LoadAllEmployees()
        //{
        //    try
        //    {
        //        List<tblEmployees> employees;
        //        using (Entities db = new Entities())
        //        {
        //            employees = db.tblEmployees.ToList();
        //        }
        //        if(employees.Count > 0)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, employees);
        //        }
        //        else
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NoContent, "No data to display");
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
        //        //return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
        //    }
        //}

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
        public HttpResponseMessage LoadEmployeeById(int id)
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

        //https://localhost:44306/api/employee?FirstName=uri&LastName=uriTest&Gender=Male&Salary=3000 (Body Content: add header "Content-Type:application/json", add body for id parameter "1")
        // Default convention: [From Uri] - simple types, [FromBody] - complex types 
        //public HttpResponseMessage Post([FromBody]int id, [FromUri]tblEmployees employee)
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
