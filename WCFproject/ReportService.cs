using System.ServiceModel;
using System.Threading;

namespace WCFproject
{
    // The service will throw a deadlock exception, to fix this issue use attribute specified below
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]  // Not required if the specified OperationContract is set to "IsOneWay = true"
    /// <summary>
    /// Duplex Message Exchange Pattern
    /// </summary>
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(50);
                OperationContext.Current.GetCallbackChannel<IReportServiceCallback>().Progress(i);
            }
            
        }
    }
}