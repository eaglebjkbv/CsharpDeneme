using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ModBusTCPClient_Form_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient tcpClient;
        int _modbusPortNr = 502;
        NetworkStream networkStream;
        Byte[] rData;
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSendData.Enabled = false;
            buttonDisconnect.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string ip =textBox14.Text+"."+textBox13.Text+"."+textBox15.Text+"."+textBox16.Text ;
            tcpClient = new TcpClient();
            
            try
            {
                tcpClient.Connect(ip, _modbusPortNr);
                if (tcpClient != null)
                {
                    if (tcpClient.Connected)
                    {
                        label1.ForeColor = Color.Green;
                        label1.Text = "Bağlendı";
                        buttonConnect.Enabled = false;
                        buttonDisconnect.Enabled = true;
                        buttonSendData.Enabled = true;

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                
                if (networkStream!=null)
                {
                    networkStream.Close();
                }
                tcpClient.Close();
                label1.ForeColor = Color.Red;
                label1.Text = "Bağlı Değil";
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                buttonSendData.Enabled = false;
            }
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                networkStream = tcpClient.GetStream();
                Byte[] data = new Byte[12];
                data[0] = (byte)Convert.ToInt32(textBox1.Text,16);
                data[1] = (byte)Convert.ToInt32(textBox2.Text,16);
                data[2] = (byte)Convert.ToInt32(textBox3.Text,16);
                data[3] = (byte)Convert.ToInt32(textBox4.Text,16);
                data[4] = (byte)Convert.ToInt32(textBox5.Text,16);
                data[5] = (byte)Convert.ToInt32(textBox6.Text,16);
                data[6] = (byte)Convert.ToInt32(textBox7.Text,16);
                data[7] = (byte)Convert.ToInt32(textBox8.Text,16);
                data[8] = (byte)Convert.ToInt32(textBox9.Text,16);
                data[9] = (byte)Convert.ToInt32(textBox10.Text,16);
                data[10] = (byte)Convert.ToInt32(textBox11.Text,16);
                data[11] = (byte)Convert.ToInt32(textBox12.Text,16);
                //Byte[] data1 ={
                //    0x00,0x01, // işlem tanımlayıcı
                //    0x00,0x00, // Protokol Tanımlaycı (modbus)
                //    0x00,0x06, // PDU uzunluğu
                //    0x11,      // Adres (17 decimal)
                //    0x03,      // Register oku komutu
                //    0x00,0x00,  // 0 ıncı registerdan itibaren    
                //    0x00,0x01  // Sadece 1 register (2 byte)  
                //};
                
                

                rData =new Byte[1024];
                networkStream.Write(data, 0, data.Length);
                AsyncCallback MyCallBack = new AsyncCallback(DataReceived);
                networkStream.BeginRead(rData, 0,rData.Length, MyCallBack, networkStream);
            }
            
        }
        public delegate void veriGoster(String veri);

        public void texteYaz(String veri)
        {
            label2.Text = veri;
        }
        private void DataReceived(IAsyncResult result)
        {
            veriGoster ekle = new veriGoster(texteYaz);
            var sb = new StringBuilder(rData.Length * 2);
            int dataLen = 6 + rData[5];

            for (int i= 0;i<dataLen;i++)
            {
                sb.AppendFormat("0x{0:x2}-", rData[i]);
                
            }
            label2.Invoke(ekle, sb.ToString());

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece rakan giriniz..");
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
            if (tb.Text.Length > 3)
            {
                tb.Text = tb.Text.Remove(tb.Text.Length-1 );
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
