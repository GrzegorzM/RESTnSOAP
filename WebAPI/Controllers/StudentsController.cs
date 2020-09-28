using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>() {
            new Student() { Id = 1, Name = "Tom" },
            new Student() { Id = 2, Name = "Sam" },
            new Student() { Id = 3, Name = "John" }
        };

        ////[Route("api/students")]
        //public IEnumerable<Student> Get()
        //{
        //    return students;
        //}

        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, students);
        //}

        public IHttpActionResult Get()
        {
            return Ok(students);
        }

        ////[Route("api/students/{id}")]
        //[Route("{id}", Name = "GetStudentById")]
        //public Student Get(int id)
        //{
        //    return students.FirstOrDefault(x => x.Id == id);
        //}

        //public HttpResponseMessage Get(int id)
        //{
        //    Student student = students.FirstOrDefault(x => x.Id == id);
        //    if (student == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, students.Find(id));
        //}

        public IHttpActionResult Get(int id)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                //return NotFound();
                return Content(HttpStatusCode.NotFound, "Student not found");
            }
            return Ok(student);
        }

        //[Route("api/students/{id}/courses")]
        [Route("{id}/courses")]
        public IEnumerable<string> GetStudentsCourses(int id)
        {
            if (id == 1)
                return new List<string>() { "C#", "ASP.NET", "SQL Server" };
            else if (id == 2)
                return new List<string>() { "ASP.NET Web API", "C#", "SQL Server" };
            else
                return new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
        }

        // ~ symbol override routeprefix attribute so we can execute this method with api/teachers uri instead of api/students/api/teachers uri
        [Route("~/api/teachers")]
        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Id = 1, Name = "Rob" },
                new Teacher() { Id = 2, Name = "Mike" },
                new Teacher() { Id = 3, Name = "Mary" }
            };

            return teachers;
        }

        public HttpResponseMessage Post(Student student)
        {
            students.Add(student);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            //response.Headers.Location = new Uri($"{Request.RequestUri}{student.Id.ToString()}");

            // Generates link using route name - solves the problem with / at the end of the url
            response.Headers.Location = new Uri($"{Url.Link("GetStudentById", new { id = student.Id })}");

            return response;
        }
    }
}