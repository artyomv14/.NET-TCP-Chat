using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ClientBL;
using CommonLib;
using Message = CommonLib.Message;

namespace ClientSideChatApp
{
    public partial class ChatWindow : Form
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        internal static List<string> PrivateUsers = new List<string>();
        internal Message Data = new Message();
        internal RegistrationForm RegistrationWindow = new RegistrationForm();
        internal User User;

        private void signInBtn_Click(object sender, EventArgs e)
        {
            RegistrationWindow.ShowDialog();
            if (ClientHelper.IsUserValid)
            {
                sendBtn.Enabled = true;
                prvtSendBtn.Enabled = true;
                srvrOffLbl.Visible = false;
                srvrOnLabel.Visible = true;
                User = RegistrationWindow.NewUser;
                userLbl.Text = ClientHelper.ActivateUserName;
                signInBtn.Enabled = false;
                ClientHelper.ResetFlags();
                Thread.Sleep(1000);
                disconnectBtn.Enabled = true; 
            }
            else
            {
                ClientHelper.ResetFlags();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!ClientHelper.IsPrivateMessage)
            {
                Data.Time = DateTime.Now;
                Data.MessageText = messageBox.Text;
                Data.User = User;
                Data.Tags = NetworkTags.Send;
                messageBox.Clear();
                ClientLogic.SendMessages(Data);
            }
            else
            {
                Data.Time = DateTime.Now;
                Data.MessageText = messageBox.Text;
                Data.User = User;
                Data.Tags = NetworkTags.SendPrivate;
                chatRoomBox.SelectionColor = Color.Black;
                chatRoomBox.AppendText("\n\t You sent a private message: " + messageBox.Text);
                messageBox.Clear();
                Data.PrivMessageUsernames = PrivateUsers;
                ClientLogic.SendMessages(Data);
                ClientHelper.IsPrivateMessage = false;
                conUsersBox.ClearSelected();
                conUsersBox.Visible = false;
                PrivateUsers.Clear();
                conUsersBox.Items.Clear();
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            UiShutDownHandler();
            ClientLogic.IsUserOnline = false;
            ClientLogic.IsConnectionDown = true;
            ClientLogic.Disconnect(User);
            
        }

        private void prvtSendBtn_Click(object sender, EventArgs e)
        {
            if (!ClientHelper.IsPrivateMessage)
            {
                ClientHelper.IsPrivateMessage = true;
                Data.Tags = NetworkTags.UserList;
                ClientLogic.SendMessages(Data);
                conUsersBox.Visible = true;
                ClientHelper.IsSentPrivate = true;
            }
            else
            {
                ClientHelper.IsPrivateMessage = false;
                conUsersBox.ClearSelected();
                conUsersBox.Visible = false;
                PrivateUsers.Clear();
                conUsersBox.Items.Clear();
            }
        }

        private void conUsersBox_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (PrivateUsers.Contains(conUsersBox.Text))
            {

                PrivateUsers.Remove(conUsersBox.Text);
            }

            else
            {
                PrivateUsers.Add(conUsersBox.Text);

            }
        }

        /// <summary>
        /// This event is necessary to prevent duplicate event firing in case of unexpected session termination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChatWindow_Load(object sender, EventArgs e)
        {
            UnsubscribeFromEvents();

            SubscribeToEvents();
        }

        private void ChatWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnsubscribeFromEvents();
        }

        private void ChatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (srvrOnLabel.Visible)
            {
                ClientLogic.Disconnect(User);
                ClientLogic.IsUserOnline = false; 
            }
            else
            {
                ClientLogic.IsUserOnline = false;
            }
        }

        private void SubscribeToEvents()
        {
            ClientLogic.NotConnectedToServer += NoConnectionToServerHandler;
            ClientLogic.OnMessageReceived += MessageHandler;
            ClientLogic.ServerDisconnected += UiShutDownHandler;
        }

        private void UnsubscribeFromEvents()
        {
            ClientLogic.NotConnectedToServer -= NoConnectionToServerHandler;
            ClientLogic.OnMessageReceived -= MessageHandler;
            ClientLogic.ServerDisconnected -= UiShutDownHandler;
        }

        private void UiShutDownHandler()
        {
            if (ClientPanel.InvokeRequired)
            {
                Action del = UiShutDownHandler;
                Invoke(del, new object[] { });
            }
            else
            {
                srvrOnLabel.Visible = false;
                srvrOffLbl.Visible = true;
                signInBtn.Enabled = true;
                disconnectBtn.Enabled = false;
                sendBtn.Enabled = false;
                prvtSendBtn.Enabled = false;
            }
        }

        private void NoConnectionToServerHandler(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UiShutDownHandler();
        }

        private void MessageHandler(Message data)
        {
            if (chatRoomBox.InvokeRequired)
            {
                Action<Message> sent = MessageHandler;
                Invoke(sent, data);
            }
            else
            {
                switch (data.Tags)
                {
                    case NetworkTags.UserList:
                        var names = from n in data.ListOfUsers
                                    select n.Username;

                        for (var index = 0; index < data.ListOfUsers.Count; index++)
                        {
                            conUsersBox.Items.Add(names.ToArray()[index]);
                        }
                        break;
                    case NetworkTags.TcpResponse:
                        chatRoomBox.SelectionColor = Color.Black;
                        chatRoomBox.AppendText("\nServer says: ");
                        chatRoomBox.SelectionColor = Color.Green;
                        chatRoomBox.AppendText("\n\t" + data.MessageText);
                        break;
                    case NetworkTags.UserDisconnect:
                        chatRoomBox.SelectionColor = Color.Black;
                        chatRoomBox.AppendText("\n Server says: ");
                        chatRoomBox.SelectionColor = Color.Red;
                        chatRoomBox.AppendText("\n\t" + data.MessageText);
                        break;
                    case NetworkTags.SeverDisconnect:
                        chatRoomBox.SelectionColor = Color.Black;
                        chatRoomBox.AppendText("\n Server says: ");
                        chatRoomBox.SelectionColor = Color.Red;
                        chatRoomBox.AppendText("\n\t" + data.MessageText);
                        chatRoomBox.SelectionColor = Color.Black;
                        break;
                    default:
                        chatRoomBox.SelectionColor = data.User.Color;
                        chatRoomBox.AppendText("\n" + data.User.Username + " says: ");
                        chatRoomBox.SelectionColor = data.User.Color;
                        chatRoomBox.AppendText("\n\t" + data.MessageText);
                        chatRoomBox.SelectionColor = Color.Black;
                        break;
                }
            }
        }
    }
}
