using System;
using System.Windows;
using System.ServiceModel;
using System.ServiceModel.PeerResolvers;

namespace WpfServer
{
    public partial class MainWindow : Window
    {
        private CustomPeerResolverService cprs;
        private ServiceHost host;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cprs = new CustomPeerResolverService();
                cprs.RefreshInterval = TimeSpan.FromSeconds(5);
                host = new ServiceHost(cprs);
                cprs.ControlShape = true;
                cprs.Open();
                host.Open(TimeSpan.FromDays(1000000));
                labelStatus.Content = "Server started successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cprs.Close();
                host.Close();
                labelStatus.Content = "Server stopped successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
