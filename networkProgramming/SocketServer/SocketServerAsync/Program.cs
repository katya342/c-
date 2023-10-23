using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketServerAsync
{
    internal class Program
    {
        private static ManualResetEvent manualResetEvent;
        static Program()
        {
            manualResetEvent = new ManualResetEvent(false);
        }
        static void Main(string[] args)
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
                manualResetEvent.Reset(); // блокируем поток
                Console.WriteLine("Waiting a connection...");
                socket.BeginAccept(AcceptCallBack, socket);
                manualResetEvent.WaitOne();
            }

        }
        private static void AcceptCallBack(IAsyncResult ar)
        {
            Socket socket = ar.AsyncState as Socket;
            Socket endSocket = socket.EndAccept(ar);

            State state = new State()
            {
                socket = endSocket,
                buffer = new byte[10],
                data = new StringBuilder()
            };

            endSocket.BeginReceive(state.buffer,
                0,
                state.buffer.Length, SocketFlags.None, RecieveCallBack, state);
        }
        private static void RecieveCallBack(IAsyncResult ar)
        {
            State state = ar.AsyncState as State;
            Socket socket = state.socket as Socket;

            int readBytes = socket.EndReceive(ar);
            if(readBytes > 0)
            {
                state.data.Append(Encoding.UTF8.GetString(state.buffer, 0, readBytes));
                if(state.data.ToString().Contains("<END>"))
                {
                    string answer = string.Format("THANKS RECIEVED {0} BYTES RECEIVED", state.data.Length);
                    byte[] recieveMsg = Encoding.UTF8.GetBytes(answer);
                    socket.BeginSend(recieveMsg, 0, recieveMsg.Length, SocketFlags.None, SendCallBack, socket);
                }
                else
                {
                    socket.BeginReceive(state.buffer,
                0,
                state.buffer.Length, SocketFlags.None, RecieveCallBack, state);
                }
            }
        }
        private static void SendCallBack(IAsyncResult ar)
        {
            Socket socket = ar.AsyncState as Socket;
            int sendBytes = socket.EndSend(ar);
            Console.WriteLine("Send {0} to client", sendBytes);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            manualResetEvent.Set();
        }
    }
    public class State
    {
        public Socket socket { get; set; }
        public byte[] buffer { get; set; }
        public StringBuilder data { get; set; }
    }
}
