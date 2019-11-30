using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SeriPorUygulamasi
{
    public partial class Form1 : Form
    {
        String Gelenveri;
        int baud = 9600;
        String portadi;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                portadi = cmbSeriPort.Text;
                serialPort1.BaudRate = baud;

                try
                {
                    serialPort1.PortName = portadi;
                    serialPort1.Open();
                    btnBaglan.Enabled = false;
                    btnBaglantiKes.Enabled = true;
                    btnGonder.Enabled = true;
                    
                } catch (Exception except)
                {
                    MessageBox.Show("Hata" + except.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        public delegate void TexteYaz();

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Gelenveri= serialPort1.ReadExisting();
            // Control.CheckForIllegalCrossThreadCalls = false;
            richTextBox1.Invoke(new TexteYaz(TexteYazFun));
            // txtGelen.Invoke(new TexteYaz(TexteYazFun));


        }
        private void TexteYazFun()
        {
            // txtGelen.AppendText(Gelenveri);
           richTextBox1.Focus();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.AppendText(Gelenveri+"\n");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SerialPort.GetPortNames().Length != 0) { 
                String[] portlar = SerialPort.GetPortNames();
                cmbSeriPort.Text = portlar[0];
                foreach (string port in portlar)
                {
                    cmbSeriPort.Items.Add(port); }
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            serialPort1.Write(txtGiden.Text);
            
           richTextBox1.Focus();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(txtGiden.Text+"\n");
            txtGiden.Text = "";

        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                btnGonder.Enabled = false;
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;

            }
        }

        private void From1_Unload(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();

            }
        }
    }
}
