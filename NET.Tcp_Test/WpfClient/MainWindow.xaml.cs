using System;
using System.Collections.Generic;
using System.Linq;
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
using System.ServiceModel;
using ServiceClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMessageCallback, IDisposable
    {
        IMessage pipeProxy = null;
        ObservableCollection<string> list;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bt_LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (Connect() == true)
            {
                //if (list != null) list.Clear();

                //Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                //(Action)(() =>
                //{


                //    ListBox_OnlineUsers.DataContext = list;

                //    Binding binding = new Binding();
                //    ListBox_OnlineUsers.SetBinding(ItemsControl.ItemsSourceProperty, binding);

                //    (ListBox_OnlineUsers.ItemsSource as ObservableCollection<string>).RemoveAt(0);
                //}));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Bt_Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pipeProxy.AddMessage(messageTextbox.Text);
                messageTextbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public bool Connect()
        {
            //note the "DuplexChannelFactory".  This is necessary for Callbacks.
            // A regular "ChannelFactory" won't work with callbacks.
            DuplexChannelFactory<IMessage> pipeFactory =
                      new DuplexChannelFactory<IMessage>(
                      new InstanceContext(this),
                      new NetTcpBinding(),
                      new EndpointAddress("net.tcp://localhost:7000/ISubscribe"));

            try
            {
                //Open the channel to the server
                pipeProxy = pipeFactory.CreateChannel();
                //Now tell the server who is connecting
                pipeProxy.Subscribe();
                //list.Clear();
                //list = pipeProxy.OnlineUsers();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public new void Close()
        {
            pipeProxy.Unsubscribe();
        }
   

        //This is the function that the SERVER will call
        public void OnMessageAdded(string message, DateTime timestamp)
        {
            rtbMessages.Text = message + ": " + timestamp.ToString("hh:mm:ss") +"\n";
        }

        //We need to tell the server that we are leaving
        public void Dispose()
        {
            pipeProxy.Unsubscribe();
        }
       
    }
}
