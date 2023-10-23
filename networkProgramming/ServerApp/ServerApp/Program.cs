using System.Net.Sockets;

namespace ServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("192.168.1.13", 6767);
                Console.WriteLine(socket.Connected);
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}