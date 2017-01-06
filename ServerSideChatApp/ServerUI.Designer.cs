namespace ServerSideChatApp
{
    partial class ServerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerUI));
            this.tabConnected = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bootBtn = new System.Windows.Forms.Button();
            this.shtdwnBtn = new System.Windows.Forms.Button();
            this.statLbl = new System.Windows.Forms.Label();
            this.offLbl = new System.Windows.Forms.Label();
            this.onLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.conUsBox = new System.Windows.Forms.ListBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.histBox = new System.Windows.Forms.ListBox();
            this.panelServer = new System.Windows.Forms.Panel();
            this.tabConnected.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConnected
            // 
            this.tabConnected.Controls.Add(this.tabPage1);
            this.tabConnected.Controls.Add(this.tabPage2);
            this.tabConnected.Controls.Add(this.tabPage3);
            this.tabConnected.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabConnected.Location = new System.Drawing.Point(9, 10);
            this.tabConnected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabConnected.Name = "tabConnected";
            this.tabConnected.SelectedIndex = 0;
            this.tabConnected.Size = new System.Drawing.Size(728, 491);
            this.tabConnected.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.conUsBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(720, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connected Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bootBtn
            // 
            this.bootBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.bootBtn.Location = new System.Drawing.Point(756, 34);
            this.bootBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bootBtn.Name = "bootBtn";
            this.bootBtn.Size = new System.Drawing.Size(120, 45);
            this.bootBtn.TabIndex = 1;
            this.bootBtn.Text = "BOOT";
            this.bootBtn.UseVisualStyleBackColor = true;
            this.bootBtn.Click += new System.EventHandler(this.bootBtn_Click);
            // 
            // shtdwnBtn
            // 
            this.shtdwnBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shtdwnBtn.ForeColor = System.Drawing.Color.Maroon;
            this.shtdwnBtn.Location = new System.Drawing.Point(756, 453);
            this.shtdwnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shtdwnBtn.Name = "shtdwnBtn";
            this.shtdwnBtn.Size = new System.Drawing.Size(120, 45);
            this.shtdwnBtn.TabIndex = 2;
            this.shtdwnBtn.Text = "SHUT DOWN";
            this.shtdwnBtn.UseVisualStyleBackColor = true;
            this.shtdwnBtn.Click += new System.EventHandler(this.shtdwnBtn_Click);
            // 
            // statLbl
            // 
            this.statLbl.AutoSize = true;
            this.statLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statLbl.Location = new System.Drawing.Point(742, 90);
            this.statLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(96, 17);
            this.statLbl.TabIndex = 3;
            this.statLbl.Text = "Server Status:";
            // 
            // offLbl
            // 
            this.offLbl.AutoSize = true;
            this.offLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offLbl.ForeColor = System.Drawing.Color.Crimson;
            this.offLbl.Location = new System.Drawing.Point(842, 90);
            this.offLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offLbl.Name = "offLbl";
            this.offLbl.Size = new System.Drawing.Size(32, 17);
            this.offLbl.TabIndex = 4;
            this.offLbl.Text = "OFF";
            // 
            // onLbl
            // 
            this.onLbl.AutoSize = true;
            this.onLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onLbl.ForeColor = System.Drawing.Color.Green;
            this.onLbl.Location = new System.Drawing.Point(842, 90);
            this.onLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onLbl.Name = "onLbl";
            this.onLbl.Size = new System.Drawing.Size(27, 17);
            this.onLbl.TabIndex = 5;
            this.onLbl.Text = "ON";
            this.onLbl.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chatBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.histBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(720, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // conUsBox
            // 
            this.conUsBox.FormattingEnabled = true;
            this.conUsBox.ItemHeight = 17;
            this.conUsBox.Location = new System.Drawing.Point(1, 0);
            this.conUsBox.Name = "conUsBox";
            this.conUsBox.Size = new System.Drawing.Size(718, 446);
            this.conUsBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 17;
            this.chatBox.Location = new System.Drawing.Point(1, 7);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(718, 446);
            this.chatBox.TabIndex = 1;
            // 
            // histBox
            // 
            this.histBox.FormattingEnabled = true;
            this.histBox.ItemHeight = 17;
            this.histBox.Location = new System.Drawing.Point(1, 7);
            this.histBox.Name = "histBox";
            this.histBox.Size = new System.Drawing.Size(718, 446);
            this.histBox.TabIndex = 1;
            // 
            // panelServer
            // 
            this.panelServer.Controls.Add(this.onLbl);
            this.panelServer.Controls.Add(this.offLbl);
            this.panelServer.Controls.Add(this.statLbl);
            this.panelServer.Controls.Add(this.shtdwnBtn);
            this.panelServer.Controls.Add(this.bootBtn);
            this.panelServer.Controls.Add(this.tabConnected);
            this.panelServer.Location = new System.Drawing.Point(0, 0);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(898, 559);
            this.panelServer.TabIndex = 6;
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(890, 523);
            this.Controls.Add(this.panelServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServerUI";
            this.Text = "TCP Chat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerUI_FormClosed);
            this.Load += new System.EventHandler(this.ServerUI_Load);
            this.tabConnected.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConnected;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bootBtn;
        private System.Windows.Forms.Button shtdwnBtn;
        private System.Windows.Forms.Label statLbl;
        private System.Windows.Forms.Label offLbl;
        private System.Windows.Forms.Label onLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox conUsBox;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.ListBox histBox;
        private System.Windows.Forms.Panel panelServer;
    }
}

