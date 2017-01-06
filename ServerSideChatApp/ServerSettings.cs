using System;
using System.Net;
using System.Windows.Forms;
using CommonLib;
using ServerBL;

namespace ServerSideChatApp
{
    public partial class ServerSettings : Form
    {
        internal Server ServerData;
        internal IPAddress ServerIpAddress;
        internal string IpParse;
        public ServerSettings(Server server)
        {
            ServerData = server;
            InitializeComponent();
        }

        private void ipCnfrmBtn_Click(object sender, EventArgs e)
        {
            IpParse = ipBox.Text;
            var ipCheck = IPAddress.TryParse(IpParse, out ServerIpAddress);
            if (ipCheck)
            {
                ServerData.IpAddress = IpParse;
                MessageBox.Show("IP Address is valid!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ServerValidationHelper.IsIpValid = true;
            }
            else
            {
                MessageBox.Show("IP Address is invalid! Please, enter a correct address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void portCnfmBtn_Click(object sender, EventArgs e)
        {
            int portNum;
            var portCheck = int.TryParse(portBox.Text, out portNum);
            if (portCheck)
            {
                if (portNum.IsPortInRange())
                {
                    ServerData.Port = portNum;
                    MessageBox.Show("Port is valid!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ServerValidationHelper.IsPortValid = true;
                }
                else
                {
                    MessageBox.Show("Port number is illegal \n Please, choose port \n from 13000 to 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Illegal input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (ServerValidationHelper.IsServerValid)

                Close();
            else
            {
                MessageBox.Show("Please confirm IP address and port before booting the server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ipClrBtn_Click(object sender, EventArgs e)
        {
            ipBox.Clear();
            ServerValidationHelper.IsIpValid = false;
        }

        private void portClrBtn_Click(object sender, EventArgs e)
        {
            portBox.Clear();
            ServerValidationHelper.IsPortValid = false;
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {
            ServerLogic.OnWrongSocket += ServerUI.WrongSocketHandler;
        }

        private void ServerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ipBox.Clear();
            portBox.Clear();
        }
    }
}
