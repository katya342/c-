using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
namespace Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public async Task InitializeAsync()
        {
            List<string> list = new List<string> { "Broadcast", "Multicast" };
            cmbBox1.ItemsSource = list;
            UserLib.UserInfo userInfo = new UserLib.UserInfo();
            string imageUrl = await userInfo.Reader();
            img1.Source = new BitmapImage(new Uri(imageUrl));
        }
        
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
           
            StartServer();
        }
      
        private async void StartServer()
        {
            try
            {
                //if (cmbBox1.SelectedItem.ToString() == "Multicast")
                //{
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                // int port = int.Parse(txtBx2.Text.ToString());
                    IPAddress ip = IPAddress.Parse("225.4.5.6");
                    IPEndPoint endPoint = new IPEndPoint(ip, 3245);
                    socket.Connect(endPoint);
                    //socket.Bind(endPoint);
                    socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));
                    byte[] data = new byte[1024];

                    int bytesRead = socket.Receive(data);
                    string recieveMessage = Encoding.UTF8.GetString(data);


                    MessageBox.Show(recieveMessage);
                    socket.Receive(data);
       
                    socket.Close();
                }
                //else
                //{
                //    MessageBox.Show("Error");
                //}
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

           

        }
    }
   
   

}
