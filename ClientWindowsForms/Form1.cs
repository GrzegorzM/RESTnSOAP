using ClientWindowsForms.CalculatorService;
using ClientWindowsForms.HelloService;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace ClientWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //HelloServiceClient client = new HelloServiceClient("NetTcpBinding_IHelloService"); // Invoke Hello Service via host APP
            HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("BasicHttpBinding_IHelloServiceIIS");// Invoke Hello Service via host IIS. IIS dont support TCP
            lblGetMessageResult.Text = client.GetMessage(tbName.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                CalculatorServiceWCFClient client = new CalculatorServiceWCFClient("WSHttpBinding_ICalculatorServiceWCF"); // wsHttpBinding - after exception occurs service will be lost. we need to create need instance of service after that
                lblResultDivide.Text = client.Divide(Convert.ToInt32(tbNumerator.Text), Convert.ToInt32(tbDenominator.Text)).ToString();
            }
            catch (FaultException ex)
            //catch (FaultException<DivideByZeroFault> ex) // Strongly typed exception
            {
                lblResultDivide.Text = $"{ex.Code} - {ex.Message}";
                //lblResultDivide.Text = $"{ex.Detail.Error} - {ex.Detail.Details}";
            }
        }
    }
}
