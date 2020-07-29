using System.ServiceModel;
using WCFproject.Models;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee employee);

        [OperationContract]
        EmployeeKnownType GetEmployeeKnownType(int Id);

        [OperationContract]
        void SaveEmployeeKnownType(EmployeeKnownType employee);
    }
}
