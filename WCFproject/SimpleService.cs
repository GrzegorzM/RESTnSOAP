using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;

namespace WCFproject
{
    // basicHttpBinding does not support sessions

    //Instance of the service will be created each time the service is invoked.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

    //Instance of the service will stay in memory for 10 minutes for the same user.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]

    //One instance of service for all clients
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    // If basicHttpBinding is used(not session support) - Positive throughput impact, two calls are processed asynchronously.
    // If a session support binding is used - Negative throughput impact, the two calls are not processed asynchronously, they are queued. 
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerCall)]

    // If basicHttpBinding is used(not session support) - Positive throughput impact, two calls are processed asynchronously.
    // If a session support binding is used - Negative throughput impact on the same client and possitive impact between diffrent clients, the two calls are not processed asynchronously for same the client, they are queued. 
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerSession)]

    // If basicHttpBinding is used(not session support) - Negative throughput impact, a single service instance is used, leading to call queuing.
    // If a session support binding is used - Negative throughput impact, a single service instance is used, leading to call queuing.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class SimpleService : ISimpleService
    {
        private int number;

        public int IncrementNumber()
        {
            number = number + 1;
            return number;
        }

        public void DisplaySessionId()
        {
            Console.WriteLine($"Session Id: {OperationContext.Current.SessionId}");
        }

        public List<int> GetEvenNumbers()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started processing GetEvenNumbers at {DateTime.Now}");
            List<int> listEvenNumbers = new List<int>();
            for (int i = 0;i<= 10; i++)
            {
                Thread.Sleep(200);
                if (i % 2 == 0)
                {
                    listEvenNumbers.Add(i);
                }
            }
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed processing GetEvenNumbers at {DateTime.Now}");
            return listEvenNumbers;
        }

        public List<int> GetOddNumbers()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started processing GetOddNumbers at {DateTime.Now}");
            List<int> listOddNumbers = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(200);
                if (i % 2 != 0)
                {
                    listOddNumbers.Add(i);
                }
            }
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed processing GetOddNumbers at {DateTime.Now}");
            return listOddNumbers;
        }
    }
}