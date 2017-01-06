namespace ClientSideChatApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.nickLbl = new System.Windows.Forms.Label();
            this.colorLbl = new System.Windows.Forms.Label();
            this.ipLbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.chatVers = new System.Windows.Forms.Label();
            this.chooseClrBtn = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.connectBtn = new System.Windows.Forms.Button();
            this.usernameClrBtn = new System.Windows.Forms.Button();
            this.ipClrBtn = new System.Windows.Forms.Button();
            this.portClrBtn = new System.Windows.Forms.Button();
            this.verifyDataBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.crctPortRangeLbl = new System.Windows.Forms.Label();
            this.nameCnfrmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickLbl
            // 
            this.nickLbl.AutoSize = true;
            this.nickLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickLbl.Location = new System.Drawing.Point(33, 207);
            this.nickLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nickLbl.Name = "nickLbl";
            this.nickLbl.Size = new System.Drawing.Size(89, 19);
            this.nickLbl.TabIndex = 4;
            this.nickLbl.Text = "Nickname";
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLbl.Location = new System.Drawing.Point(33, 250);
            this.colorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(52, 19);
            this.colorLbl.TabIndex = 5;
            this.colorLbl.Text = "Color";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLbl.Location = new System.Drawing.Point(33, 58);
            this.ipLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(97, 19);
            this.ipLbl.TabIndex = 6;
            this.ipLbl.Text = "IP Address";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLbl.Location = new System.Drawing.Point(33, 95);
            this.portLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(44, 19);
            this.portLbl.TabIndex = 7;
            this.portLbl.Text = "Port";
            this.portLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatVers
            // 
            this.chatVers.AutoSize = true;
            this.chatVers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatVers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.chatVers.Location = new System.Drawing.Point(141, 19);
            this.chatVers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chatVers.Name = "chatVers";
            this.chatVers.Size = new System.Drawing.Size(211, 19);
            this.chatVers.TabIndex = 8;
            this.chatVers.Text = "Artyom\'s TCP Chat v1.0a";
            // 
            // chooseClrBtn
            // 
            this.chooseClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseClrBtn.Location = new System.Drawing.Point(246, 246);
            this.chooseClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chooseClrBtn.Name = "chooseClrBtn";
            this.chooseClrBtn.Size = new System.Drawing.Size(106, 29);
            this.chooseClrBtn.TabIndex = 9;
            this.chooseClrBtn.Text = "Choose Color";
            this.chooseClrBtn.UseVisualStyleBackColor = true;
            this.chooseClrBtn.Click += new System.EventHandler(this.chooseClrBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.connectBtn.Enabled = false;
            this.connectBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(379, 282);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(119, 58);
            this.connectBtn.TabIndex = 10;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // usernameClrBtn
            // 
            this.usernameClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameClrBtn.Location = new System.Drawing.Point(435, 221);
            this.usernameClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.usernameClrBtn.Name = "usernameClrBtn";
            this.usernameClrBtn.Size = new System.Drawing.Size(54, 28);
            this.usernameClrBtn.TabIndex = 13;
            this.usernameClrBtn.Text = "Clear";
            this.usernameClrBtn.UseVisualStyleBackColor = true;
            this.usernameClrBtn.Click += new System.EventHandler(this.usernameClrBtn_Click);
            // 
            // ipClrBtn
            // 
            this.ipClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipClrBtn.Location = new System.Drawing.Point(435, 54);
            this.ipClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ipClrBtn.Name = "ipClrBtn";
            this.ipClrBtn.Size = new System.Drawing.Size(54, 28);
            this.ipClrBtn.TabIndex = 14;
            this.ipClrBtn.Text = "Clear";
            this.ipClrBtn.UseVisualStyleBackColor = true;
            this.ipClrBtn.Click += new System.EventHandler(this.ipClrBtn_Click);
            // 
            // portClrBtn
            // 
            this.portClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portClrBtn.Location = new System.Drawing.Point(435, 92);
            this.portClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.portClrBtn.Name = "portClrBtn";
            this.portClrBtn.Size = new System.Drawing.Size(54, 27);
            this.portClrBtn.TabIndex = 15;
            this.portClrBtn.Text = "Clear";
            this.portClrBtn.UseVisualStyleBackColor = true;
            this.portClrBtn.Click += new System.EventHandler(this.portClrBtn_Click);
            // 
            // verifyDataBtn
            // 
            this.verifyDataBtn.BackColor = System.Drawing.SystemColors.Info;
            this.verifyDataBtn.Enabled = false;
            this.verifyDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verifyDataBtn.Location = new System.Drawing.Point(207, 135);
            this.verifyDataBtn.Margin = new System.Windows.Forms.Padding(2);
            this.verifyDataBtn.Name = "verifyDataBtn";
            this.verifyDataBtn.Size = new System.Drawing.Size(177, 29);
            this.verifyDataBtn.TabIndex = 16;
            this.verifyDataBtn.Text = "Verify IP and Port";
            this.verifyDataBtn.UseVisualStyleBackColor = false;
            this.verifyDataBtn.Click += new System.EventHandler(this.verifyDataBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(188, 206);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(213, 20);
            this.nameBox.TabIndex = 17;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(188, 57);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(213, 20);
            this.ipBox.TabIndex = 18;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(188, 97);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(213, 20);
            this.portBox.TabIndex = 19;
            this.portBox.TextChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // crctPortRangeLbl
            // 
            this.crctPortRangeLbl.AutoSize = true;
            this.crctPortRangeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crctPortRangeLbl.Location = new System.Drawing.Point(81, 99);
            this.crctPortRangeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crctPortRangeLbl.Name = "crctPortRangeLbl";
            this.crctPortRangeLbl.Size = new System.Drawing.Size(99, 14);
            this.crctPortRangeLbl.TabIndex = 20;
            this.crctPortRangeLbl.Text = "(13000 - 65535)";
            this.crctPortRangeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameCnfrmBtn
            // 
            this.nameCnfrmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCnfrmBtn.Location = new System.Drawing.Point(428, 189);
            this.nameCnfrmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nameCnfrmBtn.Name = "nameCnfrmBtn";
            this.nameCnfrmBtn.Size = new System.Drawing.Size(67, 28);
            this.nameCnfrmBtn.TabIndex = 21;
            this.nameCnfrmBtn.Text = "Confirm";
            this.nameCnfrmBtn.UseVisualStyleBackColor = true;
            this.nameCnfrmBtn.Click += new System.EventHandler(this.nameCnfrmBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(509, 351);
            this.Controls.Add(this.nameCnfrmBtn);
            this.Controls.Add(this.crctPortRangeLbl);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.verifyDataBtn);
            this.Controls.Add(this.portClrBtn);
            this.Controls.Add(this.ipClrBtn);
            this.Controls.Add(this.usernameClrBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.chooseClrBtn);
            this.Controls.Add(this.chatVers);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.ipLbl);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.nickLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "TCP Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nickLbl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label chatVers;
        private System.Windows.Forms.Button chooseClrBtn;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button usernameClrBtn;
        private System.Windows.Forms.Button ipClrBtn;
        private System.Windows.Forms.Button portClrBtn;
        private System.Windows.Forms.Button verifyDataBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label crctPortRangeLbl;
        private System.Windows.Forms.Button nameCnfrmBtn;
    }
}

