namespace ServerSideChatApp
{
    partial class ServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSettings));
            this.chatVers = new System.Windows.Forms.Label();
            this.ipLbl = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.crctPortRangeLbl = new System.Windows.Forms.Label();
            this.ipClrBtn = new System.Windows.Forms.Button();
            this.portClrBtn = new System.Windows.Forms.Button();
            this.ipCnfrmBtn = new System.Windows.Forms.Button();
            this.portCnfmBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatVers
            // 
            this.chatVers.AutoSize = true;
            this.chatVers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatVers.ForeColor = System.Drawing.Color.BlueViolet;
            this.chatVers.Location = new System.Drawing.Point(206, 7);
            this.chatVers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chatVers.Name = "chatVers";
            this.chatVers.Size = new System.Drawing.Size(211, 19);
            this.chatVers.TabIndex = 9;
            this.chatVers.Text = "Artyom\'s TCP Chat v1.0a";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLbl.Location = new System.Drawing.Point(34, 76);
            this.ipLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(97, 19);
            this.ipLbl.TabIndex = 10;
            this.ipLbl.Text = "IP Address";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(182, 78);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(213, 20);
            this.ipBox.TabIndex = 19;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLbl.Location = new System.Drawing.Point(34, 148);
            this.portLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(44, 19);
            this.portLbl.TabIndex = 20;
            this.portLbl.Text = "Port";
            this.portLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(182, 152);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(213, 20);
            this.portBox.TabIndex = 21;
            // 
            // crctPortRangeLbl
            // 
            this.crctPortRangeLbl.AutoSize = true;
            this.crctPortRangeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crctPortRangeLbl.Location = new System.Drawing.Point(78, 152);
            this.crctPortRangeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crctPortRangeLbl.Name = "crctPortRangeLbl";
            this.crctPortRangeLbl.Size = new System.Drawing.Size(99, 14);
            this.crctPortRangeLbl.TabIndex = 22;
            this.crctPortRangeLbl.Text = "(13000 - 65535)";
            this.crctPortRangeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipClrBtn
            // 
            this.ipClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipClrBtn.Location = new System.Drawing.Point(503, 72);
            this.ipClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ipClrBtn.Name = "ipClrBtn";
            this.ipClrBtn.Size = new System.Drawing.Size(54, 28);
            this.ipClrBtn.TabIndex = 23;
            this.ipClrBtn.Text = "Clear";
            this.ipClrBtn.UseVisualStyleBackColor = true;
            this.ipClrBtn.Click += new System.EventHandler(this.ipClrBtn_Click);
            // 
            // portClrBtn
            // 
            this.portClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portClrBtn.Location = new System.Drawing.Point(503, 146);
            this.portClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.portClrBtn.Name = "portClrBtn";
            this.portClrBtn.Size = new System.Drawing.Size(54, 27);
            this.portClrBtn.TabIndex = 24;
            this.portClrBtn.Text = "Clear";
            this.portClrBtn.UseVisualStyleBackColor = true;
            this.portClrBtn.Click += new System.EventHandler(this.portClrBtn_Click);
            // 
            // ipCnfrmBtn
            // 
            this.ipCnfrmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipCnfrmBtn.Location = new System.Drawing.Point(411, 72);
            this.ipCnfrmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ipCnfrmBtn.Name = "ipCnfrmBtn";
            this.ipCnfrmBtn.Size = new System.Drawing.Size(67, 28);
            this.ipCnfrmBtn.TabIndex = 25;
            this.ipCnfrmBtn.Text = "Confirm";
            this.ipCnfrmBtn.UseVisualStyleBackColor = true;
            this.ipCnfrmBtn.Click += new System.EventHandler(this.ipCnfrmBtn_Click);
            // 
            // portCnfmBtn
            // 
            this.portCnfmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portCnfmBtn.Location = new System.Drawing.Point(411, 146);
            this.portCnfmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.portCnfmBtn.Name = "portCnfmBtn";
            this.portCnfmBtn.Size = new System.Drawing.Size(67, 28);
            this.portCnfmBtn.TabIndex = 26;
            this.portCnfmBtn.Text = "Confirm";
            this.portCnfmBtn.UseVisualStyleBackColor = true;
            this.portCnfmBtn.Click += new System.EventHandler(this.portCnfmBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.connectBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(238, 223);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(119, 58);
            this.connectBtn.TabIndex = 27;
            this.connectBtn.Text = "BOOT";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(605, 290);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portCnfmBtn);
            this.Controls.Add(this.ipCnfrmBtn);
            this.Controls.Add(this.portClrBtn);
            this.Controls.Add(this.ipClrBtn);
            this.Controls.Add(this.crctPortRangeLbl);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.ipLbl);
            this.Controls.Add(this.chatVers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerSettings";
            this.Text = "ServerSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerSettings_FormClosing);
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chatVers;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label crctPortRangeLbl;
        private System.Windows.Forms.Button ipClrBtn;
        private System.Windows.Forms.Button portClrBtn;
        private System.Windows.Forms.Button ipCnfrmBtn;
        private System.Windows.Forms.Button portCnfmBtn;
        private System.Windows.Forms.Button connectBtn;
    }
}