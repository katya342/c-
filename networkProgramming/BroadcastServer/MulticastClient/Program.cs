using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MulticastClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.IP,
                SocketOptionName.MulticastTimeToLive, 2);

            // IPAddress destAddr = IPAddress.Loopback;
            IPAddress destAddr = IPAddress.Parse("224.5.5.5");
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(destAddr));

            IPEndPoint desPoint = new IPEndPoint(destAddr, 1024);
            socket.Connect(desPoint);

            Console.Write("Message ");
            byte[] data = Encoding.UTF8.GetBytes(Console.ReadLine());
            socket.Send(data);
            socket.Close();
        }
    }
}