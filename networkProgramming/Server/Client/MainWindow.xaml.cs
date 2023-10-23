using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserLib;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public async Task InitializeAsync()
        {
            UserInfo userInfo = new UserInfo();

            string imageUrl_1 = await userInfo.Reader();
            string imageUrl_2 = await userInfo.Reader();
            // Set the image source
            img1.Source = new BitmapImage(new Uri(imageUrl_1));
            img2.Source = new BitmapImage(new Uri(imageUrl_2));
        }
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
            IPAddress destAddr = IPAddress.Parse("225.4.5.6");
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(destAddr));
            IPEndPoint desPoint = new IPEndPoint(destAddr, 3245);
            socket.Connect(desPoint);
            string selectedOption = ComboBox.SelectedItemProperty.ToString();
            byte[] data = Encoding.UTF8.GetBytes(selectedOption); 
            socket.Send(data);

            socket.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
