using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFproject;

namespace WCFhost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                //ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior() // This behavior is already added
                //{
                //    HttpGetEnabled = true
                //};
                //host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.AddServiceEndpoint(typeof(IHelloService), new NetTcpBinding(), "HelloService");

                host.Open();
                Console.WriteLine($"Host started at {DateTime.Now}");
                Console.ReadLine();
            }

            using (ServiceHost companyHost = new ServiceHost(typeof(CompanyService)))
            {
                companyHost.Open();
                Console.WriteLine($"Company host started at {DateTime.Now}");
                Console.ReadLine();
            }

            using (ServiceHost employeeHost = new ServiceHost(typeof(EmployeeService)))
            {
                employeeHost.Open();
                Console.WriteLine($"Employee host started at {DateTime.Now}");
                Console.ReadLine();
            }

            using (ServiceHost calculatorHost = new ServiceHost(typeof(CalculatorServiceWCF)))
            {
                calculatorHost.Open();
                Console.WriteLine($"Calculator host started at {DateTime.Now}");
                Console.ReadLine();
            }
        }
    }
}
