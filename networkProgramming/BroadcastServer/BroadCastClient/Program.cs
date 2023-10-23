using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BroadCastClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 9050);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("192.168.110.255"), 9050);
            string hostname = Dns.GetHostName();
            byte[] data = Encoding.UTF8.GetBytes(hostname);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            socket.SendTo(data, iep1);
            //socket.SendTo(data, iep2);
            socket.Close();

        }
    }
}