using ClientWindowsForms.HelloService;
using System;
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
            HelloServiceClient client = new HelloServiceClient("NetTcpBinding_IHelloService");
            lblGetMessageResult.Text = client.GetMessage(tbName.Text);
        }
    }
}
