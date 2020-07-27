using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication.Models;

namespace WebApplication
{
    /// <summary>
    /// Summary description for StudentWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StudentWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Student GetStudentById(int id)
        {
            string cs = ConfigurationManager.ConnectionStrings["SampleWebService"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetStudentByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@Id", id);
                cmd.Parameters.Add(parameter);
                Student student = new Student();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (!reader.HasRows)
                    return null;

                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = reader["Name"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.TotalMarks = Convert.ToInt32(reader["TotalMarks"]);
                }

                return student;
            }
        }
    }
}
