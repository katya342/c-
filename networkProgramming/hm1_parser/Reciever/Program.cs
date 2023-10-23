using System.Net;
using System.Net.Sockets;

namespace Reciever
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
            //    IPAddress[] IPAddresses = Dns.GetHostAddresses("192.168.1.10");
            //    tcpClient.Connect(IPAddresses, 8080);
            //    Console.WriteLine("Client connected to the server");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                TcpListener server = null;
                IPAddress localAddr = IPAddress.Parse("192.168.1.10");
                server = new TcpListener(localAddr, 8080);
                server.Start();
                NetworkStream stream = null;
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected");
                    stream = client.GetStream();


                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }


        }
    }
}