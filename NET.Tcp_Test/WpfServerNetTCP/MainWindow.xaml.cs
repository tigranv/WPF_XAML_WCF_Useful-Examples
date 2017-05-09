using ServiceClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.Windows;

namespace WpfServerNetTCP
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public partial class MainWindow : Window, IMessage
    {
        private static List<IMessageCallback> subscribers = new List<IMessageCallback>();
        private static ObservableCollection<string> onlineusers = new ObservableCollection<string>();
        public ServiceHost host = null;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            host = new ServiceHost(typeof(MainWindow), new Uri("net.tcp://localhost:7000"));
            host.AddServiceEndpoint(typeof(IMessage), new NetTcpBinding(), "ISubscribe");
            host.Open();
            labelStatus.Content = "connected";
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            host.Close();
            labelStatus.Content = "Disconnected";
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

        public void AddMessage(string message)
        {
            //Go through the list of connections and call their callback funciton
            subscribers.ForEach(delegate (IMessageCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.OnMessageAdded(message, DateTime.Now);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
        }

        public ObservableCollection<string> OnlineUsers()
        {
            foreach (var item in subscribers)
            {
                onlineusers.Add(item.GetHashCode().ToString());
            }
            return onlineusers;
        }
    }
}
