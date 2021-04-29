using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfApp0429
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationIdCredentialsProvider Provider { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            var appId = ConfigurationManager.AppSettings["BingToken"];
            var serverIp = IPAddress.Parse(ConfigurationManager.AppSettings["ServerIp"]);
            Provider = new ApplicationIdCredentialsProvider(appId);
        }
    }
}
