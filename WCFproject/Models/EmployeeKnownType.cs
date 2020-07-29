using System.Runtime.Serialization;

namespace WCFproject.Models
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public class EmployeeKnownType : Employee
    {
        public EmployeeType EmployeeType { get; set; }
    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
