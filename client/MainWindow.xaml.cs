using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace client
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient client = new WebClient(); client.Encoding = Encoding.UTF8;
                Uri uri = new Uri("http://localhost/web/server.ashx", UriKind.Absolute);
                textBox1.Text = client.DownloadString(uri);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
