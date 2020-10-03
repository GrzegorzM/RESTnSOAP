﻿using ClientWindowsForms.CalculatorService;
using ClientWindowsForms.HelloService;
using ClientWindowsForms.SampleService;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace ClientWindowsForms
{
    public partial class Form1 : Form
    {
        private readonly SampleServiceClient client;

        public Form1()
        {
            client = new SampleServiceClient(); // Comment if not using SampleService
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //HelloServiceClient client = new HelloServiceClient("NetTcpBinding_IHelloService"); // Invoke Hello Service via host APP
            //HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("BasicHttpBinding_IHelloServiceIIS");// Invoke Hello Service via host IIS. IIS dont support TCP
            HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("NetTcpBinding_IHelloServiceIIS");// WAS hosting
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // IsOneWay = true
        // Operations in progress block clients. They are queued and executed one after the other.
        private void buttonRequestReplyOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add($"Request-Reply Operation Started @{DateTime.Now}");
                buttonRequestReplyOperation.Enabled = false;
                listBox1.Items.Add(client.RequestReplyOperation());
                buttonRequestReplyOperation.Enabled = true;
                listBox1.Items.Add($"Request-Reply Operation Completed @{DateTime.Now}");
                listBox1.Items.Add(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // IsOneWay = true
        // Throwed exceptions breaks connection to service. Subsequent operations are not possible to execute w/o creating a new connection to the service.
        private void buttonRequestReplyOperationThrowException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add($"Request-Reply Operation ThrowException Started @{DateTime.Now}");
                client.RequestReplyOperation_ThrowsException();
                listBox1.Items.Add($"Request-Reply Operation ThrowException Completed @{DateTime.Now}");
                listBox1.Items.Add(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // IsOneWay = true
        // Operations in progress don't block clients. They are executed asynchronously.
        //private async System.Threading.Tasks.Task buttonRequestReplyOperationAsync_ClickAsync(object sender, EventArgs e) // Wrong, not working - return type must be void for async event
        private async void buttonRequestReplyOperationAsync_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add($"Request-Reply Operation Started @{DateTime.Now}");
                buttonRequestReplyOperation.Enabled = false;
                listBox1.Items.Add(await client.RequestReplyOperationAsync());
                buttonRequestReplyOperation.Enabled = true;
                listBox1.Items.Add($"Request-Reply Operation Completed @{DateTime.Now}");
                listBox1.Items.Add(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
