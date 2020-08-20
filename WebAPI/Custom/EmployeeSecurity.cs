using System;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Custom
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (Entities db = new Entities())
            {
                return db.tblUsers.Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password.Equals(password));
            }
        }
    }
}