using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace AppTcpListener
{
    internal class Program
    {
        public static List<PortInfo> GetOpenPort()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndPoints = properties.GetActiveTcpListeners();
            TcpConnectionInformation [] tcpConnections = properties.GetActiveTcpConnections();

            var data = tcpConnections.Select(s => new PortInfo(s.LocalEndPoint.Port,
                string.Format("{0}: {1}", s.LocalEndPoint.Address,
                s.LocalEndPoint.Port), string.Format("{0}: {1}", s.RemoteEndPoint.Address, s.RemoteEndPoint.Port), s.State.ToString())).ToList();

            return data;
        }
        static void Main(string[] args)
        {
            List<PortInfo> ports = GetOpenPort();
            foreach (PortInfo port in ports) 
            {
                Console.WriteLine("Port: {0} - {1}", port.PortNumber, port.State);
            }
            //Ping myping = new Ping();
            //PingReply reply = myping.Send("192.168.111.187", 9595);
            //Console.WriteLine("Status: {0}/n Time: {1}", reply.Status, reply.RoundtripTime.ToString());
            TcpListener server = null;
            try
            {
                IPAddress localAdr = IPAddress.Parse("192.168.110.106");
                server = new TcpListener(localAdr, 9595);
                //Привязывает к EndPoint и ожидает передачи входящих попыток
                server.Start();
                byte[] bytes = new byte[1024];
                string data = "";
                NetworkStream stream = null;
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected");
                    stream = client.GetStream();
                    int i = 0;
                    while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.UTF8.GetString(bytes, 0, i);
                        Console.WriteLine("->  {0}", data);
                        data = "Message Recieved!";
                        byte[] recieveData = Encoding.UTF8.GetBytes(data);
                        stream.Write(recieveData, 0, recieveData.Length);
                    }
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                server.Stop();
                
            }
        }
    }

    public class PortInfo
    {
        public PortInfo(int portNumber, string local, string remote, string state)
        {
            PortNumber = portNumber;
            Local = local;
            Remote = remote;
            State = state;
        }
    
        public int PortNumber { get; set; }
        public string Local { get; set; }
        public string Remote { get; set; }  
        public string State { get; set; }
    }
}