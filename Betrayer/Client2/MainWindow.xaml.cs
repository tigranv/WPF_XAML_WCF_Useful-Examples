using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WCFService;

namespace Client2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri address = new Uri("http://localhost:4000/ISender");

        BasicHttpBinding binding = new BasicHttpBinding();

        ServiceHost service;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                if (service == null)
                {
                    service = new ServiceHost(typeof(ClientService));

                    service.AddServiceEndpoint(typeof(ISender), binding, address);

                    service.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ServiceSender proxy = new ServiceSender();
            
            textBlock.Text = proxy.GetData(5);
        }
    }
}
