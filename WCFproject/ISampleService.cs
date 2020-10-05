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

        [OperationContract(IsOneWay = true)]
        void OneWayOperation();

        [OperationContract(IsOneWay = true)]
        void OneWayOperation_ThrowsException();
    }
}