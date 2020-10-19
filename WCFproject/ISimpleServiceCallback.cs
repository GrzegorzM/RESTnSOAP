using System.ServiceModel;

namespace WCFproject
{
    public interface ISimpleServiceCallback
    {
        [OperationContract]
        void ReportProgress(int percentageCompleted);
    }
}