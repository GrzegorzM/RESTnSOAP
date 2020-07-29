namespace WCFproject.Models
{
    public class PartTimeEmployee : EmployeeKnownType
    {
        public int HourlyPay { get; set; }

        public int HoursWorked { get; set; }
    }
}