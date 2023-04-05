using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ModbusTCPTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient? tcpClient;
        NetworkStream? networkStream;
        byte[]? rData;
        
        
        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            string ip = textBoxIP.Text;
            int port =Convert.ToInt32(textBoxPort.Text);
            tcpClient = new TcpClient();
            try
            {
                await tcpClient.ConnectAsync(ip, port);
                if (tcpClient.Connected)
                {
                    labelStatus.Text = "Status :Online";
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool bClosed = false;
            if (tcpClient.Connected)
            {
                if (tcpClient.Client.Poll(0, SelectMode.SelectRead))
                {
                    byte[] buff = new byte[1];
                    if (tcpClient.Client.Receive(buff, SocketFlags.Peek) == 0)
                    {
                        // Client disconnected
                        bClosed = true;
                    }
                }
                if (bClosed)
                {
                    labelStatus.Text = "Status : Offline";
                    buttonConnect.Enabled = true;
                    buttonDisconnect.Enabled = false;
                    tcpClient.Close();
                }
            }
                    
         }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            if (!tcpClient.Connected)
            {
                buttonDisconnect.Enabled = false;
                buttonConnect.Enabled = true;
                timer1.Enabled = false;
                labelStatus.Text = "Status : Offline";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDisconnect.Enabled = false;
        }

        private void buttonSendCmd_Click(object sender, EventArgs e)
        {
            byte[] wData = new byte[30];
            wData[0] = (byte)Convert.ToInt32(textBoxTraId.Text.Substring(0, 2), 16);
            wData[1] = (byte)Convert.ToInt32(textBoxTraId.Text.Substring(2, 2), 16);
            wData[2] = (byte)Convert.ToInt32(textBoxProId.Text.Substring(0, 2), 16);
            wData[3] = (byte)Convert.ToInt32(textBoxProId.Text.Substring(2, 2), 16);
            wData[4] = (byte)Convert.ToInt32(textBoxLength.Text.Substring(0, 2), 16);
            wData[5] = (byte)Convert.ToInt32(textBoxLength.Text.Substring(2, 2), 16);
            wData[6] = (byte)Convert.ToInt32(textBoxUnitNr.Text.Substring(0, 2), 16);
            wData[7] = (byte)Convert.ToInt32(textBoxFuncCode.Text.Substring(0, 2), 16);
            int lenOfData =textBoxData.Text.Length;

            for(int i = 0; i < lenOfData; i+=2)
            {
                wData[i/2+8] = (byte)Convert.ToInt32(textBoxData.Text.Substring(i, 2), 16);
            }
            
            
            if (tcpClient != null)
            {
                if (tcpClient.Connected)
                {
                    richTextBox1.Text += "TxD : ";
                    StringBuilder hex = new StringBuilder((lenOfData + 16) / 2 * 2);
                    for (int i = 0; i < (lenOfData + 16)/2; i++)
                    {
                        hex.AppendFormat("{0:x2} ", wData[i]);
                    }
                    richTextBox1.Text += hex+"\n";
                    networkStream = tcpClient.GetStream();
                    networkStream.Write(wData, 0, (lenOfData + 16) / 2);
                    rData = new Byte[1024];
                    AsyncCallback MyCallBack = new AsyncCallback(DataReceived);
                    networkStream.BeginRead(rData, 0, rData.Length, MyCallBack, networkStream);
                }
            }
        }

        public delegate void veriGoster(String veri);

        public void texteYaz(String veri)
        {
            richTextBox1.Text +="RxD : " +veri +"\n";
        }
        private void DataReceived(IAsyncResult result)
        {
            veriGoster ekle = new veriGoster(texteYaz);
            var sb = new StringBuilder(rData.Length * 2);
            int dataLen = 6 + rData[5];

            for (int i = 0; i < dataLen; i++)
            {
                sb.AppendFormat("{0:x2} ", rData[i]);

            }
            richTextBox1.Invoke(ekle, sb.ToString());

        }
    }
}