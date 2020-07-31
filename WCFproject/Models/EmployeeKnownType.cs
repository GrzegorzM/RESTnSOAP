using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFproject.Models
{
    [MessageContract(IsWrapped = true, WrapperName = "EmployeeRequestObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://MyCompany.com/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://MyCompany.com/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {
            this.EmployeeType = EmployeeType.Null;
        }

        public EmployeeInfo(EmployeeKnownType employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth;
            this.EmployeeType = employee.EmployeeType;
            if (employee.EmployeeType == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            } 
            else if(employee.EmployeeType == EmployeeType.PartTimeEmployee)
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;
            }
        }

        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Employee")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Employee")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Employee")]
        public EmployeeType EmployeeType { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Employee")]
        public int AnnualSalary { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Employee")]
        public int HourlyPay { get; set; }

        [MessageBodyMember(Order = 8, Namespace = "http://MyCompany.com/Employee")]
        public int HoursWorked { get; set; }
    }


    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public class EmployeeKnownType : Employee
    {
        public EmployeeType EmployeeType { get; set; }
    }

    public enum EmployeeType
    {
        Null = 0,
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
