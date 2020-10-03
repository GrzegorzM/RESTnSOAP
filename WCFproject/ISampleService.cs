using System.ServiceModel;

namespace WCFproject
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string RequestReplyOperation();

        [OperationContract]
        string RequestReplyOperation_ThrowsException();
    }
}