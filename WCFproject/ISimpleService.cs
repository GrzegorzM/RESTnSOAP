using System.ServiceModel;

namespace WCFproject
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        int IncrementNumber();
    }
}