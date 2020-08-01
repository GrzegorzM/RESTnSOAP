using System.ServiceModel;
using System.ServiceProcess;
using WCFproject;

namespace WindowsServiceHost
{
    public partial class HelloWindowsService : ServiceBase
    {
        ServiceHost host;

        public HelloWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(HelloService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
