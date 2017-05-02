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
using System.ComponentModel;

namespace WpfClient
{
    [ServiceContract(CallbackContract = typeof(IChatService))]
    public interface IChatService
    {
        [OperationContract(IsOneWay = true)]
        void Join(string memberName);
        [OperationContract(IsOneWay = true)]
        void Leave(string memberName);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string memberName, string message);
    }

    public interface IChatChannel : IChatService, IClientChannel
    {
    }

    public partial class MainWindow : Window, IChatService
    {
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);

        private static event UserJoined NewJoin;
        private static event UserSendMessage MessageSent;
        private static event UserLeft RemoveUser;

        private string userName;
        private IChatChannel channel;
        private DuplexChannelFactory<IChatChannel> factory;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string userName)
        {
            this.userName = userName;
        }

        private void Bt_LogIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                try
                {
                    NewJoin += new UserJoined(ChatClient_NewJoin);
                    MessageSent += new UserSendMessage(ChatClient_MessageSent);
                    RemoveUser += new UserLeft(ChatClient_RemoveUser);

                    channel = null;
                    this.userName = txtUserName.Text.Trim();
                    InstanceContext context = new InstanceContext( new MainWindow(txtUserName.Text.Trim()));
                    factory = new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");
                    channel = factory.CreateChannel();
                    IOnlineStatus status = channel.GetProperty<IOnlineStatus>();
                    status.Offline += new EventHandler(Offline);
                    status.Online += new EventHandler(Online);
                    channel.Open();
                    channel.Join(this.userName);
                    rtbMessages.AppendText("*****************************WEL-COME to Chat Application*****************************\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        void ChatClient_RemoveUser(string name)
        {
            try
            {
                rtbMessages.AppendText("\r\n");
                rtbMessages.AppendText(name + " left at " + DateTime.Now.ToString());
                //lstUsers.Items.Remove(name);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }

        void ChatClient_MessageSent(string name, string message)
        {
            //if (!lstUsers.Items.Contains(name))
            //{
            //    lstUsers.Items.Add(name);
            //}
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " says: " + message);
        }

        void ChatClient_NewJoin(string name)
        {
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " joined at: [" + DateTime.Now.ToString() + "]");
            //lstUsers.Items.Add(name);
        }

        void Online(object sender, EventArgs e)
        {
            ListBox_OnlineUsers.Items.Add(this.userName);
        }

        void Offline(object sender, EventArgs e)
        {
            ListBox_OnlineUsers.Items.Remove(this.userName);
        }

        #region IChatService Members

        public void Join(string memberName)
        {
            NewJoin?.Invoke(memberName);
        }

        public void Leave(string memberName)
        {
            RemoveUser?.Invoke(memberName);
        }

        public void SendMessage(string memberName, string message)
        {
            MessageSent?.Invoke(memberName, message);
        }

        #endregion

        private void Bt_Send_Click(object sender, EventArgs e)
        {
            channel.SendMessage(this.userName, messageTextbox.Text.Trim());
            messageTextbox.Clear();
            messageTextbox.Focus();
        }

        private void ChatClient_FormClosing(object sender, EventArgs e)
        {
            try
            {
                if (channel != null)
                {
                    channel.Leave(this.userName);
                    channel.Close();
                }
                if (factory != null)
                {
                    factory.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

