using System.ServiceModel;
using WCFproject.Models;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    //[ServiceKnownType(typeof(PartTimeEmployee))] Different way to assiociate known type
    //[ServiceKnownType(typeof(FullTimeEmployee))] Different way to assiociate known type
    [ServiceContract]
    public interface IEmployeeService
    {
        //[ServiceKnownType(typeof(PartTimeEmployee))] Different way to assiociate known type
        //[ServiceKnownType(typeof(FullTimeEmployee))] Different way to assiociate known type
        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee employee, EmployeeKnownType e1 = null, PartTimeEmployee e2 = null, FullTimeEmployee e3 = null);

        [OperationContract]
        //EmployeeKnownType GetEmployeeKnownType(int Id);
        EmployeeInfo GetEmployeeKnownType(EmployeeRequest request);

        [OperationContract]
        //void SaveEmployeeKnownType(EmployeeKnownType employee);
        void SaveEmployeeKnownType(EmployeeInfo employee);
    }
}
