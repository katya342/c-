using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClientAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client RUN");
            while (true)
            {
                UdpClient client = new UdpClient();
                IPAddress address = IPAddress.Parse("192.168.110.106");
                client.Connect(address, 5000);
                Console.WriteLine("--> ");
                byte[] bytes = Encoding.UTF8.GetBytes(Console.ReadLine());
                client.Send(bytes, bytes.Length);
                client.Close();
            }
           
        }
    }
}