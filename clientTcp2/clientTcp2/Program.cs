using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace clientTcp2
{
    class Program
    {
        public static void PrintByteArray(byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length*2);
            sb.Append("Gelen Data: ");
            foreach (var b in bytes)
            {
                sb.AppendFormat("{0:x2}-",b);
            }
            

            Console.WriteLine(sb.ToString());
        }

        static void Main(string[] args)
        {
            Byte[] data = { 
                0x00, 0x01, // İşlem Tanımlayıcı
                0x00, 0x00, // Protokol Tanımlayıcı "0" Modbus
                0x00, 0x06, // Uzunluk bu kısımdan sonra 6 byte
                0x11, 0x06, // 17 nolu slave 06 nolu komut
                0x20, 0x01, // 2001H nolu registere
                0x0d, 0xac  // "0DAC" 35.00 datasını yaz
            };
            Byte[] rdata = new Byte[12];
            TcpClient client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", 502);
                
                if (client != null)
                {
                    if (client.Connected)
                    {
                        Console.WriteLine("Bağlantı oluştu");
                        NetworkStream stream=client.GetStream();
                        stream.Write(data, 0, data.Length);
                        int bytes;
                        while (true)
                        {
                            bytes=stream.Read(rdata,0,12);
                            if (bytes > 0)
                            {
                                PrintByteArray(rdata);
                                break;
                            }
                        }
                        
                        
                        Console.Read();
                        stream.Close();
                        client.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            


        }
    }
}
