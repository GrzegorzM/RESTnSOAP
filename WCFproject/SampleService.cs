using System;
using System.Threading;

namespace WCFproject
{
    public class SampleService : ISampleService
    {
        public string RequestReplyOperation()
        {
            DateTime dateStart = DateTime.Now;
            Thread.Sleep(2000);
            DateTime dateEnd = DateTime.Now;

            return $"{dateEnd.Subtract(dateStart).Seconds} seconds processing time";
        }

        public string RequestReplyOperation_ThrowsException()
        {
            throw new NotImplementedException();
        }

        public void OneWayOperation()
        {
            Thread.Sleep(2000);
            return;
        }

        public void OneWayOperation_ThrowsException()
        {
            throw new NotImplementedException();
        }
    }
}