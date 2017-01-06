using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ClientBL;
using CommonLib;
using Message = CommonLib.Message;

namespace ClientSideChatApp
{
    public partial class RegistrationForm : Form
    {
        internal IPAddress IpAddress;
        internal string IpParse;
        internal Color UserColor;
        internal User NewUser;
        internal Message MessageData;
        internal string Nickname;
        internal int Port;
        internal List<User> ListOfUsers;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void verifyDataBtn_Click(object sender, EventArgs e)
        {
            IpParse = ipBox.Text;
            var isIpCorrect = IPAddress.TryParse(IpParse, out IpAddress);
            var isPortCorrect = int.TryParse(portBox.Text, out Port);
            if (!isPortCorrect && !isIpCorrect && !Port.CheckPort())
            {
                MessageBox.Show("Please, enter a correct port number (13000 - 65535) and a valid IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ipBox.Clear();
                portBox.Clear();
            }
            else
            {
                MessageData = new Message(new User(IpParse, Port), NetworkTags.Validate);
                ClientLogic.SocketDataValidation(MessageData);
                if (ClientLogic.IsSocketDataValid)
                {
                    MessageBox.Show("Socket data valid and confirmed", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    verifyDataBtn.Enabled = false;
                    ListOfUsers = ClientLogic.ListOfUsersConnected;
                    ClientHelper.IsIpAndPortConfirm = ClientLogic.IsSocketDataValid;
                }
                else
                {
                    MessageBox.Show("No active server found on this socket, please retry", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }

        }

        private void usernameClrBtn_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
        }

        private void ipClrBtn_Click(object sender, EventArgs e)
        {
            verifyDataBtn.Enabled = true;
            ipBox.Clear();
        }

        private void portClrBtn_Click(object sender, EventArgs e)
        {
            verifyDataBtn.Enabled = true;
            portBox.Clear();
        }

        private void chooseClrBtn_Click(object sender, EventArgs e)
        {
            var result = colorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                UserColor = colorPicker.Color;
                chatVers.ForeColor = colorPicker.Color;
                MessageData.Color = colorPicker.Color;
                connectBtn.Enabled = true;
            }
        }

        private void ClearAllBoxes()
        {
            ipBox.Clear();
            nameBox.Clear();
            portBox.Clear();
            verifyDataBtn.Enabled = true;
        }

        private void nameCnfrmBtn_Click(object sender, EventArgs e)
        {
            if (ClientHelper.IsIpAndPortConfirm)
            {
                var names = from n in ListOfUsers 
                            where n != null
                            select (n.Username);

                var isNickNameEntered = names.Contains(nameBox.Text);

                if (nameBox.Text != "")
                {
                    if (!isNickNameEntered)
                    {
                        MessageBox.Show("Nickname confirmed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nickname = nameBox.Text;
                        ClientHelper.ActivateUserName = Nickname;
                        ClientHelper.IsNickConfirm = true;
                    }

                    else
                    {
                        MessageBox.Show("This nickname is already in use, please choose another", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No nickname chosen, please enter a valid nickname", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No socket data entered, please enter valid data before registering a nickname", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void portBox_TextChanged(object sender, EventArgs e)
        {
            if (ipBox.Text != "")
            {
                verifyDataBtn.Enabled = true;
            }
            else
            {
                verifyDataBtn.Enabled = false;
            }
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
            if (portBox.Text != "")
            {
                verifyDataBtn.Enabled = true;
            }
            else
            {
                verifyDataBtn.Enabled = false;
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientHelper.IsUserValid)
                {
                    NewUser = new User(IpParse, Port, Nickname, UserColor);
                    var messageData = new Message(NewUser)
                    {
                        Tags = NetworkTags.Connect
                    };
                    ClientLogic.Tags = NetworkTags.Connect;
                    ClientLogic.ConnectToServer(messageData, NewUser);
                    ClientLogic.IsConnectionDown = false;
                    ClearAllBoxes();
                    Close(); 
                }
                else
                {
                    ClientHelper.ResetFlags();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No user data has been validated", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            verifyDataBtn.Enabled = true;
            ClearAllBoxes();
        }
    }
}
