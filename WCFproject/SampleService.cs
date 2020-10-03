using System;
using System.Threading;

namespace WCFproject
{
    public class SampleService : ISampleService
    {
        private int i = 0;

        public string RequestReplyOperation()
        {
            DateTime dateStart = DateTime.Now;
            if (i == 0)
                Thread.Sleep(20000);
            else
                Thread.Sleep(2000);
            DateTime dateEnd = DateTime.Now;

            return $"{dateEnd.Subtract(dateStart).Seconds} seconds processing time";
        }

        public string RequestReplyOperation_ThrowsException()
        {
            throw new NotImplementedException();
        }
    }
}