using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry("localhost");
                IPAddress address = hostEntry.AddressList[0];
              
                IPEndPoint endPoint = new IPEndPoint(address, 23456);

                Socket socket = new Socket(AddressFamily.InterNetwork,
                 SocketType.Stream,
                 ProtocolType.Tcp);

                // связывает для ожидания входящий запросов
                socket.Bind(endPoint);
                // помещает сокет в режим прослушивания
                socket.Listen(5);

                while (true)
                {
                    Console.WriteLine("Listening.......");
                    // ожидает входящее сообщение
                    Socket acceptSocket = socket.Accept();

                    StringBuilder sb = new StringBuilder();
                    byte[] bytes;
                    int byteRec;

                    int marker;
                    while (true)
                    {
                        bytes = new byte[1024];
                        byteRec = acceptSocket.Receive(bytes);
                        sb.Append(Encoding.UTF8.GetString(bytes, 0, byteRec));
                        marker = sb.ToString().LastIndexOf("<END>");
                        if (marker >= 1)
                            break;
                    }
                    Console.WriteLine("Message: {0}", sb.ToString().Substring(0, marker));
                    string answer = string.Format("Thanks received {0} bytes received", sb.Length);
                    byte[] recieveMsg = Encoding.UTF8.GetBytes(answer);
                    acceptSocket.Send(recieveMsg);
                    acceptSocket.Shutdown(SocketShutdown.Both);
                    acceptSocket.Close();
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}