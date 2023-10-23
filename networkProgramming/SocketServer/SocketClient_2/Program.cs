using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry("localhost");
                IPAddress address = hostEntry.AddressList[0];
                address = IPAddress.Parse("192.168.1.13");
                IPEndPoint endPoint = new IPEndPoint(address, 23456);

                Socket socket = new Socket(AddressFamily.InterNetwork,
                 SocketType.Stream,
                 ProtocolType.Tcp);
                socket.Connect(endPoint);
                Console.WriteLine("Connecting....");
                Console.WriteLine("Input message: ");
                string message = Console.ReadLine();
                int sentBytes = socket.Send(Encoding.UTF8.GetBytes(message + "<END>"));

                // поулчаем ответ от сервера
                byte[] data = new byte[1024];
                int recieveBytes = socket.Receive(data);
                Console.WriteLine("Answer: {0}", Encoding.UTF8.GetString(data, 0, recieveBytes));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();               
              


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }

