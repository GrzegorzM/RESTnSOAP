using System.ServiceModel;

namespace WCFproject
{
    [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]
    public interface IReportService
    {
        //[OperationContract]
        [OperationContract(IsOneWay = true)]
        void ProcessReport();
    }

    public interface IReportServiceCallback
    {
        //[OperationContract]
        [OperationContract(IsOneWay = true)]
        void Progress(int percentageCompleted);
    }
}