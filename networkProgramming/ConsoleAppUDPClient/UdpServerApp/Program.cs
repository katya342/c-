using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("server RUN");
            try
            {
                while (true)
                {
                    UdpClient server = new UdpClient(5000);
                    IPEndPoint remoteEndPoint = null;
                    //Получение данных
                    byte[] bytes = server.Receive(ref remoteEndPoint);
                    string message = Encoding.UTF8.GetString(bytes);
                    Console.WriteLine("---> {0}: {1}", remoteEndPoint.Address, message);
                    server.Close();
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

               
            }
        }
    }
}