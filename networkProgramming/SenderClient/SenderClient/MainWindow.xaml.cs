using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SenderClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon icon;
        public MainWindow()
        {
            InitializeComponent();

            icon = new N
        }

        private void StartListeningButton_Click(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            icon.Icon = new System.Drawing.Icon
        }
    }
}
