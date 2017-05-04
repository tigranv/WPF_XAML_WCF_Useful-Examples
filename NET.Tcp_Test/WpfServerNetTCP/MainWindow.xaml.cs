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

namespace WpfServerNetTCP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

    public partial class MainWindow : Window, IMessage
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static List<IMessageCallback> subscribers = new List<IMessageCallback>();
        public ServiceHost host = null;

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            using (ServiceHost host = new ServiceHost(
                typeof(MainWindow),
                new Uri("net.tcp://localhost:8000")))
            {
                //notice the NetTcpBinding?  This allows programs instead of web stuff
                // to communicate with each other
                host.AddServiceEndpoint(typeof(IMessage), new NetTcpBinding(), "ISubscribe");

                try
                {
                    host.Open();
                    labelStatus.Content = "Successfully opened port 8000.";
                   
                }
                catch (Exception)
                {
                    labelStatus.Content = "Error";
                }
            }
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            if (host != null)
            {
                host.Close();
            }
            labelStatus.Content = "Successfully closed port 8000.";
        }

        public bool Subscribe()
        {
            try
            {
                //Get the hashCode of the connecting app and store it as a connection
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Add(callback);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Unsubscribe()
        {
            try
            {
                //remove any connection that is leaving
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AddMessage(String message)
        {
            //Go through the list of connections and call their callback funciton
            subscribers.ForEach(delegate (IMessageCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    TxBlockOperations.Text = $"Calling OnMessageAdded on callback ({callback.GetHashCode()}).";
                    callback.OnMessageAdded(message, DateTime.Now);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });

        }
    }
}
