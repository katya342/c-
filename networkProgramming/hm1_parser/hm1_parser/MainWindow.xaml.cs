using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

namespace hm1_parser
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
            try
            {
                WebRequest request = WebRequest.Create(requestUriString: txtBx1.Text.ToString());
                WebResponse response = request.GetResponse();
                Dictionary<string, int> words = new Dictionary<string, int>();
                using (Stream data = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(data);
                    string content = reader.ReadToEnd();
                    string pattern = @"\b\w+\b";
                    MatchCollection matches = Regex.Matches(content, pattern);
                    foreach (Match match in matches)
                    {
                        string word = match.Value.ToLower();
                        if(words.ContainsKey(word))
                        {
                            words[word] += 1;
                        }
                        else
                        {
                            words[word] = 1;
                        }
                    }
                    lstBox1.ItemsSource = words.Select(pair => $"Word: {pair.Key} its frequency is: {pair.Value}");
                }
              
               
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
