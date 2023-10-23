using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiCastServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 1024);
                socket.Bind(endPoint);
                IPAddress ip = IPAddress.Parse("224.5.5.5");
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));
                byte[] data = new byte[1024];
                Console.WriteLine("Server started");
                socket.Receive(data);
                Console.WriteLine("--> {0}", Encoding.UTF8.GetString(data));
                socket.Close();
            }
        }
    }
}