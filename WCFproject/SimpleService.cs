using System.ServiceModel;

namespace WCFproject
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
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