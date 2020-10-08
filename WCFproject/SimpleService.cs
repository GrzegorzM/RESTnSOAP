using System.ServiceModel;

namespace WCFproject
{
    // basicHttpBinding does not support sessions

    //Instance of the service will be created each time the service is invoked.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

    //Instance of the service will stay in memory for 10 minutes for the same user.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class SimpleService : ISimpleService
    {
        private int number;

        public int IncrementNumber()
        {
            number = number + 1;
            return number;
        }
    }
}