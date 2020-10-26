using ClientWindowsForms.CalculatorService;
using ClientWindowsForms.DownloadService;
using ClientWindowsForms.HelloService;
using ClientWindowsForms.ReportService;
using ClientWindowsForms.SampleService;
using ClientWindowsForms.SimpleService;
using System;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace ClientWindowsForms
{
    [CallbackBehavior(UseSynchronizationContext = false)] // Not required if the specified OperationContract is set to "IsOneWay = true"
    public partial class Form1 : Form, IReportServiceCallback, ISimpleServiceCallback
    {
        private readonly SampleServiceClient client;
        private readonly SimpleServiceClient simpleServiceClient;

        public Form1()
        {
            //client = new SampleServiceClient(); // Comment if not using SampleService
            //simpleServiceClient = new SimpleServiceClient();
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //HelloServiceClient client = new HelloServiceClient("NetTcpBinding_IHelloService"); // Invoke Hello Service via host APP
            //HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("BasicHttpBinding_IHelloServiceIIS");// Invoke Hello Service via host IIS. IIS dont support TCP
            //HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("NetTcpBinding_IHelloServiceIIS");// WAS hosting
            HelloServiceClient client = new HelloServiceClient("WSHttpBinding_IHelloService");
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

        #region SampleService

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

        private void buttonOneWayOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add($"One Way Operation Started @{DateTime.Now}");
                buttonOneWayOperation.Enabled = false;
                client.OneWayOperation();
                buttonOneWayOperation.Enabled = true;
                listBox1.Items.Add($"One Way Operation Completed @{DateTime.Now}");
                listBox1.Items.Add(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOneWayOperation_ThrowsException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add($"One Way Operation Throw Exception Started @{DateTime.Now}");
                client.OneWayOperation_ThrowsException();
                listBox1.Items.Add($"One Way Operation Throw Exception Completed @{DateTime.Now}");
                listBox1.Items.Add(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ReportService

        private void buttonProcessReport_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ReportServiceClient client = new ReportServiceClient(instanceContext);
            client.ProcessReport();
        }

        public void Progress(int percentageCompleted)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBoxProgress.Text = $"{percentageCompleted} % completed";
        }

        #endregion

        #region SimpleService

        private void buttonDownloadFile_Click(object sender, EventArgs e)
        {
            DownloadServiceClient client = new DownloadServiceClient();
            File file = client.DownloadDocument();
            System.IO.File.WriteAllBytes(@"C:\RESTnSOAP\" + file.Name, file.Content);
            MessageBox.Show($"{file.Name} is downloaded");
        }

        private void buttonServiceBehavior_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SimpleServiceClient client = new SimpleServiceClient(instanceContext);
            //SimpleServiceClient client = new SimpleServiceClient();
            MessageBox.Show($"Number after first call = {client.IncrementNumber()}");
            MessageBox.Show($"Number after second call = {client.IncrementNumber()}");
            MessageBox.Show($"Number after third call = {client.IncrementNumber()}");

            //// Handling session timeout exception
            //try
            //{
            //    MessageBox.Show($"Number = {client.IncrementNumber()}");
            //}
            //catch(CommunicationException)
            //{
            //    if (client.State == CommunicationState.Faulted)
            //    {
            //        MessageBox.Show($"Session timed out and existing session is lost. A new session will now be created.");
            //        client = new SimpleServiceClient();
            //    }
            //}
        }

        private void buttonSessionId_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SimpleServiceClient client = new SimpleServiceClient(instanceContext);
            //SimpleServiceClient client = new SimpleServiceClient();
            client.DisplaySessionId();
            MessageBox.Show($"Session ID = {client.InnerChannel.SessionId}");
        }

        private void buttonGetEvenNumbers_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonOddNumbers_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = simpleServiceClient.GetEvenNumbers();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            listBoxEvenNumbers.DataSource = (int[])e.Result;
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = simpleServiceClient.GetOddNumbers();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            listBoxOddNumbers.DataSource = (int[])e.Result;
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            listBoxEvenNumbers.DataSource = null;
            listBoxOddNumbers.DataSource = null;
        }

        private void buttonProcessReportReentrant_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SimpleServiceClient client = new SimpleServiceClient(instanceContext);
            client.ProgressReport();
        }

        public void ReportProgress(int percentageCompleted)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBoxProgressReentrant.Text = $"{percentageCompleted}% completed";
        }

        private void buttonDoWork_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SimpleServiceClient client = new SimpleServiceClient(instanceContext);
            for(int i = 1; i <= 100; i++)
            {
                Thread thread = new Thread(client.DoWork);
                thread.Start();
            }
        }


        private void buttonAuthentication_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SimpleServiceClient client = new SimpleServiceClient(instanceContext);
            MessageBox.Show(client.GetUserName());
        }

        #endregion

        private void buttonGetMessage_Click(object sender, EventArgs e)
        {
            HelloServiceClient client = new HelloServiceClient("WSHttpBinding_IHelloService");
            MessageBox.Show(client.GetMessageWithoutAnyProtection());
        }

        private void buttonGetSignedMessage_Click(object sender, EventArgs e)
        {
            HelloServiceClient client = new HelloServiceClient("WSHttpBinding_IHelloService");
            MessageBox.Show(client.GetSignedMessage());
        }

        private void buttonGetSignedEncryptedMessage_Click(object sender, EventArgs e)
        {
            HelloServiceClient client = new HelloServiceClient("WSHttpBinding_IHelloService");
            MessageBox.Show(client.GetSignedAndEncryptedMessage());
        }

        private void buttonCallService_Click(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; }; // Workaround for a self-signed certificate.

            HelloServiceIIS.HelloServiceClient client = new HelloServiceIIS.HelloServiceClient("WSHttpBinding_IHelloService1");
            client.ClientCredentials.UserName.UserName = "WindowsLoginUsername";
            client.ClientCredentials.UserName.Password = "WindowsLoginPassword";
            MessageBox.Show(client.GetMessage("World!"));
        }
    }
}