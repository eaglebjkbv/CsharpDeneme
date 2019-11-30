using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusTCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Baglanti baglanti;

        

        private  async void buttonBaglan_Click(object sender, EventArgs e)
        {

            labelBaglantiDurum.Text = "Bağlanıyor....";
            try
            {
                
                
                baglanti = new Baglanti(textBoxIpAdres.Text, Int32.Parse(textBoxPort.Text));
                
                await baglanti.AcAsync();
                
                if (baglanti.Durum() == true)
                {
                        labelBaglantiDurum.Text = "Bağlı";
                }
               
               
                
            }
            catch (Exception exception)
            {
                labelBaglantiDurum.Text = "Bağlı Değil";
                MessageBox.Show("Bağlanamadı :"+exception.Message);
                

            }
            

        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            string komut = textBoxKomut.Text;
            int uzunluk = komut.Length;
            Byte[] komutBytes = new Byte[uzunluk/2];
            int a = 0;
            for (int i = 0; i < uzunluk; i = i + 2)
            {
                
                string gecici =komut.Substring(i, 2);
                Byte geciciByte=Byte.Parse(gecici,System.Globalization.NumberStyles.HexNumber);
                komutBytes[a] = geciciByte;
                a++;
            }
            try
            {
                baglanti.Gonder(komutBytes);
            }
            catch (Exception exception)
            {

                MessageBox.Show("Hata : " +exception );
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.Durum() == true)
                {
                    baglanti.Kapat();
                    labelBaglantiDurum.Text = "Bağlı Değil";
                }
            }
            catch (Exception exception)
            {
                if(exception.GetType()==typeof(NullReferenceException))
                MessageBox.Show("Hata : Henüz Bağlantı Yapmadınız..");
            }
            
        }
    }
}
