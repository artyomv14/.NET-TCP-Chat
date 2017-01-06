namespace ClientSideChatApp
{
    partial class ChatWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.conUsersLbl = new System.Windows.Forms.Label();
            this.serverStatusLbl = new System.Windows.Forms.Label();
            this.srvrOffLbl = new System.Windows.Forms.Label();
            this.prvtSendBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.srvrOnLabel = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.chatRoomBox = new System.Windows.Forms.RichTextBox();
            this.chtRoomLbl = new System.Windows.Forms.Label();
            this.ClientPanel = new System.Windows.Forms.Panel();
            this.conUsersBox = new System.Windows.Forms.CheckedListBox();
            this.ClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(9, 401);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(680, 43);
            this.messageBox.TabIndex = 2;
            this.messageBox.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(12, 448);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(141, 57);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disconnectBtn.Location = new System.Drawing.Point(794, 478);
            this.disconnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(141, 31);
            this.disconnectBtn.TabIndex = 4;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // conUsersLbl
            // 
            this.conUsersLbl.AutoSize = true;
            this.conUsersLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conUsersLbl.Location = new System.Drawing.Point(763, 5);
            this.conUsersLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conUsersLbl.Name = "conUsersLbl";
            this.conUsersLbl.Size = new System.Drawing.Size(127, 19);
            this.conUsersLbl.TabIndex = 5;
            this.conUsersLbl.Text = "Connected Users";
            // 
            // serverStatusLbl
            // 
            this.serverStatusLbl.AutoSize = true;
            this.serverStatusLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusLbl.Location = new System.Drawing.Point(301, 472);
            this.serverStatusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverStatusLbl.Name = "serverStatusLbl";
            this.serverStatusLbl.Size = new System.Drawing.Size(108, 19);
            this.serverStatusLbl.TabIndex = 6;
            this.serverStatusLbl.Text = "Server Status:";
            // 
            // srvrOffLbl
            // 
            this.srvrOffLbl.AutoSize = true;
            this.srvrOffLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvrOffLbl.ForeColor = System.Drawing.Color.Crimson;
            this.srvrOffLbl.Location = new System.Drawing.Point(407, 472);
            this.srvrOffLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srvrOffLbl.Name = "srvrOffLbl";
            this.srvrOffLbl.Size = new System.Drawing.Size(37, 19);
            this.srvrOffLbl.TabIndex = 7;
            this.srvrOffLbl.Text = "OFF";
            // 
            // prvtSendBtn
            // 
            this.prvtSendBtn.Enabled = false;
            this.prvtSendBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prvtSendBtn.Location = new System.Drawing.Point(734, 28);
            this.prvtSendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prvtSendBtn.Name = "prvtSendBtn";
            this.prvtSendBtn.Size = new System.Drawing.Size(174, 57);
            this.prvtSendBtn.TabIndex = 8;
            this.prvtSendBtn.Text = "Private";
            this.prvtSendBtn.UseVisualStyleBackColor = true;
            this.prvtSendBtn.Click += new System.EventHandler(this.prvtSendBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBtn.Location = new System.Drawing.Point(649, 478);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(141, 31);
            this.signInBtn.TabIndex = 9;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // srvrOnLabel
            // 
            this.srvrOnLabel.AutoSize = true;
            this.srvrOnLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvrOnLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.srvrOnLabel.Location = new System.Drawing.Point(448, 472);
            this.srvrOnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srvrOnLabel.Name = "srvrOnLabel";
            this.srvrOnLabel.Size = new System.Drawing.Size(32, 19);
            this.srvrOnLabel.TabIndex = 10;
            this.srvrOnLabel.Text = "ON";
            this.srvrOnLabel.Visible = false;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(301, 448);
            this.userLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(41, 19);
            this.userLbl.TabIndex = 11;
            this.userLbl.Text = "User";
            // 
            // chatRoomBox
            // 
            this.chatRoomBox.Location = new System.Drawing.Point(12, 28);
            this.chatRoomBox.Name = "chatRoomBox";
            this.chatRoomBox.Size = new System.Drawing.Size(677, 331);
            this.chatRoomBox.TabIndex = 12;
            this.chatRoomBox.Text = "";
            // 
            // chtRoomLbl
            // 
            this.chtRoomLbl.AutoSize = true;
            this.chtRoomLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtRoomLbl.Location = new System.Drawing.Point(281, 5);
            this.chtRoomLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chtRoomLbl.Name = "chtRoomLbl";
            this.chtRoomLbl.Size = new System.Drawing.Size(88, 19);
            this.chtRoomLbl.TabIndex = 13;
            this.chtRoomLbl.Text = "Chat Room";
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientPanel.Controls.Add(this.conUsersBox);
            this.ClientPanel.Controls.Add(this.chtRoomLbl);
            this.ClientPanel.Controls.Add(this.chatRoomBox);
            this.ClientPanel.Controls.Add(this.userLbl);
            this.ClientPanel.Controls.Add(this.srvrOnLabel);
            this.ClientPanel.Controls.Add(this.signInBtn);
            this.ClientPanel.Controls.Add(this.prvtSendBtn);
            this.ClientPanel.Controls.Add(this.srvrOffLbl);
            this.ClientPanel.Controls.Add(this.serverStatusLbl);
            this.ClientPanel.Controls.Add(this.conUsersLbl);
            this.ClientPanel.Controls.Add(this.disconnectBtn);
            this.ClientPanel.Controls.Add(this.sendBtn);
            this.ClientPanel.Controls.Add(this.messageBox);
            this.ClientPanel.Location = new System.Drawing.Point(0, 2);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(946, 524);
            this.ClientPanel.TabIndex = 15;
            // 
            // conUsersBox
            // 
            this.conUsersBox.FormattingEnabled = true;
            this.conUsersBox.Location = new System.Drawing.Point(734, 102);
            this.conUsersBox.Name = "conUsersBox";
            this.conUsersBox.Size = new System.Drawing.Size(174, 199);
            this.conUsersBox.TabIndex = 14;
            this.conUsersBox.Visible = false;
            this.conUsersBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.conUsersBox_ItemCheck_1);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 522);
            this.Controls.Add(this.ClientPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatWindow";
            this.Text = "TCP Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatWindow_FormClosed);
            this.Load += new System.EventHandler(this.ChatWindow_Load);
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Label conUsersLbl;
        private System.Windows.Forms.Label serverStatusLbl;
        private System.Windows.Forms.Label srvrOffLbl;
        private System.Windows.Forms.Button prvtSendBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label srvrOnLabel;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.RichTextBox chatRoomBox;
        private System.Windows.Forms.Label chtRoomLbl;
        private System.Windows.Forms.Panel ClientPanel;
        private System.Windows.Forms.CheckedListBox conUsersBox;
    }
}