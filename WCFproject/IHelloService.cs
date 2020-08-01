using System.ServiceModel;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    
    //[ServiceContract(Name = "IHelloServiceChangedName")] // Name = "IHelloServiceChangedName" allows change interface name without breaking clients.
    [ServiceContract] // Decorating with this attribute turns this interface into WCF Service.
    public interface IHelloService
    {
        //[OperationContract(Name = "GetMessageChangedName")]
        [OperationContract] // Decorating with this attribute makes this method available to client through service.
        string GetMessage(string Name);
    }
}
