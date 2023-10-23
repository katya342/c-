using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace WpfApp1
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

        private void btnopenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileeDialog = new OpenFileDialog();
            if(fileeDialog.ShowDialog() == true)
            {
                tbxFile.Text = fileeDialog.FileName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] bytes = null;
            TcpClient client = null;
            NetworkStream stream = null;
            try
            {
                client = new TcpClient("localhost", 8088);
                MessageBox.Show("Connecte to the Server");
                stream = client.GetStream();
                FileStream fs = new FileStream(tbxFile.Text, FileMode.Open, FileAccess.Read);
                fs.Read(bytes, 0, bytes.Length);
                stream.Write(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
                client.Close();
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
