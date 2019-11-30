using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ModBusTCPClient
{
    class Baglanti
    {
        private TcpClient client;
        private NetworkStream stream;
        public string _ipAdres { get; set; }
        public Int32 _portNo { get; set; }
        public Baglanti(string ipAdres,Int32 portNo)
        {
            client=new TcpClient();
            _ipAdres = ipAdres;
            _portNo = portNo;
        }

        public async Task AcAsync()
        {
           
                await client.ConnectAsync(_ipAdres, _portNo);
                stream = client.GetStream();
           

        }
        public void Ac()
        {
            client.Connect(_ipAdres, _portNo);
            stream = client.GetStream();

        }

        public void Gonder(Byte[] gonderBytes)
        {
            byte uzunluk =(Byte)gonderBytes.Length;
            Byte[] nihaiBytes = new Byte[uzunluk + 6];
            nihaiBytes[0] = 0x00;
            nihaiBytes[1] = 0x01;
            nihaiBytes[2] = 0x00;
            nihaiBytes[3] = 0x00;
            nihaiBytes[4] = 0x00;
            nihaiBytes[5] = uzunluk;
            for (int i = 6; i < uzunluk + 6; i++)
            {
                nihaiBytes[i] = gonderBytes[i - 6];
            }

            try
            {
                stream.Write(nihaiBytes, 0, nihaiBytes.Length);
            }
            catch (Exception exception)
            {

                System.Windows.Forms.MessageBox.Show("Hata : "+exception);
            }
               

            
        }

        public void Kapat()
        {
            stream.Close();
            client.Close();
        }

        public bool Durum()
        {
            bool durum=false;
            if (client != null) {
                if (!client.Connected)
                {
                    durum = false;
                }
                else
                {
                    durum = true;
                }
            }


            return durum;

        }
    }
}
