using System;
using System.Net.Sockets;
using System.Text;

namespace ModbusTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] data={
                0x00,0x01, // işlem tanımlayıcı
                0x00,0x00, // Protokol Tanımlaycı (modbus)
                0x00,0x06, // PDU uzunluğu
                0x11,      // Adres (17 decimal)
                0x03,      // Register oku komutu
                0x00,0x00,  // 0 ıncı registerdan itibaren    
                0x00,0x01  // Sadece 1 register (2 byte)  
            };
            Byte[] rData=new byte[11];
            TcpClient tcpClient=new TcpClient();
            try
            {
                tcpClient.Connect("127.0.0.1",502);
                if(tcpClient!=null){
                    if(tcpClient.Connected){
                        NetworkStream networkStream=tcpClient.GetStream();
                        networkStream.Write(data,0,data.Length);
                        while(true){
                            int bytes=networkStream.Read(rData,0,rData.Length);
                            if(bytes>0){
                                var sb=new StringBuilder(rData.Length*2);
                                foreach(var b in rData){
                                    sb.AppendFormat("0x{0:x2}-",b);
                                }
                                Console.Write($"Gelen Data :{sb}");
                                break;
                            }
                        }
                        Console.Read();
                        networkStream.Close();
                        tcpClient.Close();
                    }
                }
            }
            catch (System.Exception e)
            {
                
                Console.WriteLine("Hata:{0}",e.Message);
            }
            




        }
    }
}
