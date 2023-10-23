using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            try
            {
                TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
                IPAddress[] IPAddresses = Dns.GetHostAddresses("192.168.1.10");
                tcpClient.Connect(IPAddresses, 8080);
                Debug.WriteLine("Client connected to the server");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "*.txt";
            if(openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;
                txtbx1.Text = selectedFilePath;
                string fileName = System.IO.Path.GetFileName(selectedFilePath);
                //string destinationPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, fileName);
                string destinationPath = @"C:\Proggramming\project\hm1_parser\ex2\files\" + fileName;
                File.Copy(selectedFilePath, destinationPath, true);
            }
            
        }
    }
}
