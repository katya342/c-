using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleAppUDPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(11000);
            try
            {
                udpClient.Connect("HOST", 11000);
                Byte[] sendBytes = Encoding.UTF8.GetBytes("Who s here?");
                udpClient.Send(sendBytes, sendBytes.Length);


                UdpClient udpClientB = new UdpClient(11000);
                udpClientB.Send(sendBytes, sendBytes.Length, "HOST", 11000);


                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] recieved = udpClient.Receive(ref remoteEndPoint);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}