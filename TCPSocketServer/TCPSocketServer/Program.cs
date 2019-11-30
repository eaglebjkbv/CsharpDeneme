using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPSocketServer
{
    class Program
    {
        static byte[] buffer { get; set; }
        static Socket sck;

        static void Main(string[] args)
        {
            sck=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Any,1234));
            sck.Listen(100);
            

            Socket kabulEdildi = sck.Accept();

            buffer=new byte[kabulEdildi.SendBufferSize];
            int byteOkunan = kabulEdildi.Receive(buffer);

            byte[] duzenlenmis = new byte[byteOkunan];
            for (int i = 0; i < byteOkunan; i++)
            {
                duzenlenmis[i] = buffer[i];
            }

            string strVeri = Encoding.ASCII.GetString(duzenlenmis);
            Console.WriteLine(strVeri+"\r\n");
            Console.Read();
            kabulEdildi.Close();
        }
    }
}
