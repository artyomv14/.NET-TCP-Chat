using System;
using System.Windows.Forms;
using CommonLib;
using ServerBL;

namespace ServerSideChatApp
{
    public partial class ServerUI : Form
    {
        private static readonly object locker = new object();
        internal Server ServerData = new Server();
        public ServerUI()
        {
            InitializeComponent();
            shtdwnBtn.Enabled = false;
        }

        private void bootBtn_Click(object sender, EventArgs e)
        {
            ServerLogic.OnServerShutDown -= NoConnectionHandler;
            ServerLogic.OnServerShutDown += NoConnectionHandler;
            var setting = new ServerSettings(ServerData);
            setting.ShowDialog();

            if (ServerData.IpAddress != null && ServerData.Port != 0)
            {
                offLbl.Visible = false;
                onLbl.Visible = true;
                ServerLogic.BootServer(ServerData);
                bootBtn.Enabled = false;
                shtdwnBtn.Enabled = true;
            }
        }

        private void shtdwnBtn_Click(object sender, EventArgs e)
        {
            ServerLogic.IsManuallyDisconnected = true;
            ServerLogic.StopListening();
            bootBtn.Enabled = true;
            shtdwnBtn.Enabled = false;
            onLbl.Visible = false;
            offLbl.Visible = true;
        }

        private void ServerUI_Load(object sender, EventArgs e)
        {
            ServerEventHandlers.OnNewUserConnected += NewUserHandler;
            ServerEventHandlers.OnMessageSent += MessageSentHandler;
            ServerEventHandlers.OnUserRemoval += UserDisconnectHandler;
        }

        private void ServerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerLogic.IsManuallyDisconnected = true;
            ServerLogic.StopListening();
        }

        private void ServerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerEventHandlers.OnUserRemoval -= UserDisconnectHandler;
            Dispose();
        }

        //EventHandlers
        private void NoConnectionHandler()
        {
            try
            {
                if (panelServer.InvokeRequired)
                {
                    Action disconn = NoConnectionHandler;
                    Invoke(disconn, new object[] { });
                }
                else
                {
                    lock (locker)
                    {
                        conUsBox.Items.Clear();
                        histBox.Items.Clear();
                        chatBox.Items.Clear();
                    }
                    offLbl.Visible = true;
                    onLbl.Visible = false;
                    bootBtn.Enabled = true;
                    shtdwnBtn.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection could not be established!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void NewUserHandler(CommonLib.Message message)
        {
            if (conUsBox.InvokeRequired || histBox.InvokeRequired)
            {
                Action<CommonLib.Message> update = NewUserHandler;
                Invoke(update, message);
            }
            else
            {
                lock (locker)
                {
                    conUsBox.Items.Add(message.User.Username + " IP: " + message.User.IpAddress +
                                " Port: " + message.User.Port);
                    histBox.Items.Add(message.MessageText + message.Time.ToLongTimeString()); 
                }
            }
        }

        public static void WrongSocketHandler()
        {
            MessageBox.Show("Server cannot boot on this socket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ServerLogic.OnWrongSocket -= WrongSocketHandler;
        }

        private void MessageSentHandler(CommonLib.Message message)
        {
            var currentTime = DateTime.Now;
            if (conUsBox.InvokeRequired || chatBox.InvokeRequired || histBox.InvokeRequired)
            {
                Action<CommonLib.Message> processMessage = MessageSentHandler;
                Invoke(processMessage, message);
            }
            else
            {
                lock (locker)
                {
                    if (message.Tags == NetworkTags.TcpResponse)
                    {
                        chatBox.Items.Add("Server says: \n" + message.MessageText);
                    }
                    else if (message.Tags == NetworkTags.UserDisconnect)
                    {
                        chatBox.Items.Add("Server says: \n" + message.User.Username + " was disconnected...");
                        for (var index = 0; index < conUsBox.Items.Count; index++)
                        {
                            if (conUsBox.Items[index].ToString().Contains(message.User.Username))
                            {
                                conUsBox.Items.Remove(conUsBox.Items[index]);
                                break;
                            }
                        }
                        histBox.Items.Add(message.User.Username + " was disconnected..." + currentTime.ToLongTimeString());
                    }
                    else if (message.Tags == NetworkTags.SeverDisconnect)
                    {
                        chatBox.Items.Add(message.MessageText);
                    }
                    else
                    {
                        chatBox.Items.Add(message.User.Username + " says: \n" + message.MessageText);
                    } 
                }
            }
        }

        private void UserDisconnectHandler(User user)
        {
            if (panelServer.InvokeRequired)
            {
                Action<User> disconnect = UserDisconnectHandler;
                Invoke(disconnect, user);
            }
            else
            {
                var currentTime = DateTime.Now;
                for (var index = 0; index < conUsBox.Items.Count; index++)
                {
                    if (conUsBox.Items[index].ToString().Contains(user.Username))
                    {
                        conUsBox.Items.Remove(conUsBox.Items[index]);
                        break;
                    }
                }
                lock (locker)
                {
                    histBox.Items.Add(user.Username + " was disconnected " + currentTime.ToLongTimeString());
                    chatBox.Items.Add("Server says: \n" + user.Username + " was disconnected..."); 
                }
            }

        }
    }
}
