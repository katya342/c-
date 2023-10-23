using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AppTcpClien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
              //  IPAddress address = IPAddress.Parse("127.0.0.1");
             //   IPEndPoint endPoint = new IPEndPoint(address, 9595);
                //создаем tcpClient
                //TcpClient client = new TcpClient();
               // client.Connect(endPoint);
                TcpClient client = new TcpClient(AddressFamily.InterNetwork);
                IPAddress[] IPAddresses = Dns.GetHostAddresses("192.168.110.106");
                client.Connect(IPAddresses, 9595);
                // будет ли сооединение оставаться открытым после закрытия сокета и как долго
               // client.LingerState = new LingerOption(false, 0);
                // каскеленская маршрутка
               // client.NoDelay = true;
                //client.ReceiveBufferSize = 1024;
                //client.ReceiveTimeout = 1000;
                //client.SendTimeout = 10000;
                Console.Write("-> ");
                string message = Console.ReadLine();

                // переводим собщение в bytes
                byte[] data = Encoding.UTF8.GetBytes(message);

                // Получаем поток для чтения и записи
                NetworkStream stream = client.GetStream();

                //отправляем сообщение нашему клиенту
                stream.Write(data, 0, data.Length);
                Console.WriteLine();

                // Получаем ответ от сервера
                data = new byte[256];
                string responseData = "";

                // считаем первый пакет ответа сервера
                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);

                Console.WriteLine("-> {0}", responseData);
                // закрываем все
                stream.Close();
                client.Close();


            

            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           
            

        }
    }
}