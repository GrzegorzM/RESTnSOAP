using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using WCFproject.Models;

namespace WCFproject
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IgnoreExtensionDataObject = true)] // Turn Off ExtensionDataObject for current service
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        private EmployeeKnownType lastSavedEmployee;

        public Employee GetEmployee(int Id)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["SampleWebService"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = Id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                    return null;

                while (reader.Read())
                {
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                }
            }
            return employee;
        }

        public void SaveEmployee(Employee employee, EmployeeKnownType e1 = null, PartTimeEmployee e2 = null, FullTimeEmployee e3 = null) // e1, e2, e3 - Parameters for compatibility reason with previous version of client app.
        {
            string cs = ConfigurationManager.ConnectionStrings["SampleWebService"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter parameterId = new SqlParameter
                //{
                //    ParameterName = "@Id",
                //    Value = employee.Id
                //};
                //cmd.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter
                {
                    ParameterName = "@Gender",
                    Value = employee.Gender
                };
                cmd.Parameters.Add(parameterGender);

                SqlParameter parameterDateOfBirth = new SqlParameter
                {
                    ParameterName = "@DateOfBirth",
                    Value = employee.DateOfBirth
                };
                cmd.Parameters.Add(parameterDateOfBirth);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //public EmployeeKnownType GetEmployeeKnownType(int Id)
        public EmployeeInfo GetEmployeeKnownType(EmployeeRequest request)
        {
            EmployeeKnownType employee = null;
            string cs = ConfigurationManager.ConnectionStrings["SampleWebService"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeKnownType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                //parameterId.Value = Id;
                parameterId.Value = request.EmployeeId;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                    return new EmployeeInfo();
                    //return null;

                while (reader.Read())
                {
                    if ((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
                    {
                        employee = new FullTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            EmployeeType = EmployeeType.FullTimeEmployee,
                            AnnualSalary = reader["AnnualSalary"] == null ? 0 : Convert.ToInt32(reader["AnnualSalary"])
                        };
                    }
                    else
                    {
                        employee = new PartTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            EmployeeType = EmployeeType.PartTimeEmployee,
                            HourlyPay = reader["HourlyPay"] == null ? 0 : Convert.ToInt32(reader["HourlyPay"]),
                            HoursWorked = reader["HoursWorked"] == null ? 0 : Convert.ToInt32(reader["HoursWorked"])
                        };
                    }
                }
            }

            if (lastSavedEmployee != null && request.EmployeeId == lastSavedEmployee.Id)
            {
                employee.ExtensionData = lastSavedEmployee.ExtensionData;
            }

            //return employee;
            return new EmployeeInfo(employee);
        }

        //public void SaveEmployeeKnownType(EmployeeKnownType employee)
        public void SaveEmployeeKnownType(EmployeeInfo employee)
        {
            string cs = ConfigurationManager.ConnectionStrings["SampleWebService"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployeeKnownType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter parameterId = new SqlParameter
                //{
                //    ParameterName = "@Id",
                //    Value = employee.Id
                //};
                //cmd.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter
                {
                    ParameterName = "@Gender",
                    Value = employee.Gender
                };
                cmd.Parameters.Add(parameterGender);

                SqlParameter parameterDateOfBirth = new SqlParameter
                {
                    ParameterName = "@DateOfBirth",
                    //Value = employee.DateOfBirth
                    Value = employee.DOB
                };
                cmd.Parameters.Add(parameterDateOfBirth);

                SqlParameter parameterEmployeeType = new SqlParameter
                {
                    ParameterName = "@EmployeeType",
                    //Value = employee.EmployeeType
                    Value = employee.EmployeeType
                };
                cmd.Parameters.Add(parameterEmployeeType);

                //if (employee.GetType() == typeof(FullTimeEmployee))
                if (employee.EmployeeType == EmployeeType.FullTimeEmployee)
                {
                    SqlParameter parameterAnnualSalary = new SqlParameter
                    {
                        ParameterName = "@AnnualSalary",
                        //Value = ((FullTimeEmployee)employee).AnnualSalary
                        Value = employee.AnnualSalary
                    };
                    cmd.Parameters.Add(parameterAnnualSalary);
                }
                else
                {
                    SqlParameter parameterHourlyPay = new SqlParameter
                    {
                        ParameterName = "@HourlyPay",
                        //Value = ((PartTimeEmployee)employee).HourlyPay,
                        Value = employee.HourlyPay,
                    };
                    cmd.Parameters.Add(parameterHourlyPay);

                    SqlParameter parameterHoursWorked = new SqlParameter
                    {
                        ParameterName = "@HoursWorked",
                        //Value = ((PartTimeEmployee)employee).HoursWorked
                        Value = employee.HoursWorked
                    };
                    cmd.Parameters.Add(parameterHoursWorked);
                }

                lastSavedEmployee = employee.GetEmployeeObject();

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
