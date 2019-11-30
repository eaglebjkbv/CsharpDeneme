using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPSocketClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint=new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);
            sck.Connect(endPoint);

            Console.WriteLine("Mesaj Girin : ");
            string msg = Console.ReadLine();
            byte[] msgTamponu = Encoding.Default.GetBytes(msg);
            sck.Send(msgTamponu, 0, msgTamponu.Length, 0);

            byte[] tampon=new byte[255];
            int rec = sck.Receive(tampon, 0, tampon.Length, 0);

            Array.Resize(ref tampon,rec);
            Console.WriteLine("Gelen :{0}",Encoding.Default.GetString(tampon));

            Console.Read();
        }
    }
}
