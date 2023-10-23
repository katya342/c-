using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;

namespace TcpFileServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Any, 8088);
                listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            byte[] bytes = new byte[1024];
            int recBytes = 0;
            try
            {
                TcpListener client = null;
                NetworkStream stream = null;
                client = listener.AcceptTcpClient();
                stream = client.GetStream();
                Console.WriteLine("Connect to client");
                stream.Read(bytes, 0, bytes.Length);
                string message = Encoding.UTF8.GetString(bytes);
                FileInfo fileinfo = JsonConvert.DeserializeObject<FileInfo>(message);
                string path = @"C:\Users\katya\Pictures" + fileinfo.FileName;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Write(fileinfo.File, 0, fileinfo.File.Length);
                }
            }
            catch (Exception)
            {

               
            }
            finally
            {
               
            }
          
                
            
            
        }
    }
    public class FileInfo
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public byte[] File { get; set; }
    }
}