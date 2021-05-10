using System;
using System.Net.Sockets;
using System.Text;


namespace ModbussTcpIpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] data={
                0x00,0x01,// 0001
                0x00,0x00, // 0000
                0x00,0x06, // 0006
                0x11,0x03, // 1103
                0x00,0x00, // 0000
                0x00,0x01  //0001
            };
            Byte[] rData=new Byte[12];
            TcpClient client=new TcpClient();
            
            try{
                client.Connect("127.0.0.1",502);
                if(client!=null){
                    if(client.Connected){
                        Console.WriteLine("Bağlantı Oluştu ");
                        NetworkStream networkStream=client.GetStream();
                        networkStream.Write(data,0,data.Length);
                        int bytes;
                        while(true){
                            bytes=networkStream.Read(rData,0,12);
                            if(bytes>0){
                                var sb=new StringBuilder(rData.Length*2);
                                foreach(var b in rData){
                                    sb.AppendFormat("0x{0:x2}-",b);
                                }
                                Console.Write($"Gelen Data {sb}");
                                break;
                            }
                        }
                        Console.Read();
                        networkStream.Close();
                        client.Close();
                    }
                }

            }catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
