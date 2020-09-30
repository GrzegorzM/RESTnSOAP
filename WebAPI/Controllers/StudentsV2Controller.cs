using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentsV2Controller : ApiController
    {
        private List<StudentV2> students = new List<StudentV2>()
        {
            new StudentV2() { Id = 1, FirstName = "Chad", LastName = "Kowalski" },
            new StudentV2() { Id = 2, FirstName = "Bob", LastName = "Snow" },
            new StudentV2() { Id = 3, FirstName = "Mary", LastName = "White" },
        };

        //[Route("api/v2/students")]
        public IEnumerable<StudentV2> Get()
        {
            return students;
        }

        //[Route("api/v2/students/{id}")]
        public StudentV2 Get(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}