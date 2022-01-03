
namespace JMCClient
{
    partial class JMCClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxLoginPass = new System.Windows.Forms.TextBox();
            this.TextboxLoginName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.TextboxServerAddress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MediaPlayerButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListboxMessages = new System.Windows.Forms.ListBox();
            this.NameSortLaunch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextboxLoginPass);
            this.groupBox1.Controls.Add(this.TextboxLoginName);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(59, 92);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // TextboxLoginPass
            // 
            this.TextboxLoginPass.Location = new System.Drawing.Point(76, 56);
            this.TextboxLoginPass.Name = "TextboxLoginPass";
            this.TextboxLoginPass.PasswordChar = '*';
            this.TextboxLoginPass.Size = new System.Drawing.Size(100, 20);
            this.TextboxLoginPass.TabIndex = 1;
            // 
            // TextboxLoginName
            // 
            this.TextboxLoginName.Location = new System.Drawing.Point(76, 30);
            this.TextboxLoginName.Name = "TextboxLoginName";
            this.TextboxLoginName.Size = new System.Drawing.Size(100, 20);
            this.TextboxLoginName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonConnect);
            this.groupBox2.Controls.Add(this.ButtonDisconnect);
            this.groupBox2.Controls.Add(this.TextboxServerAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JMC Server Address";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(20, 45);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(101, 45);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonDisconnect.TabIndex = 3;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // TextboxServerAddress
            // 
            this.TextboxServerAddress.Location = new System.Drawing.Point(6, 19);
            this.TextboxServerAddress.Name = "TextboxServerAddress";
            this.TextboxServerAddress.Size = new System.Drawing.Size(180, 20);
            this.TextboxServerAddress.TabIndex = 2;
            this.TextboxServerAddress.Text = "\\\\.\\pipe\\JMCServer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NameSortLaunch);
            this.groupBox3.Controls.Add(this.MediaPlayerButton);
            this.groupBox3.Location = new System.Drawing.Point(215, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applications";
            // 
            // MediaPlayerButton
            // 
            this.MediaPlayerButton.Enabled = false;
            this.MediaPlayerButton.Location = new System.Drawing.Point(6, 16);
            this.MediaPlayerButton.Name = "MediaPlayerButton";
            this.MediaPlayerButton.Size = new System.Drawing.Size(81, 23);
            this.MediaPlayerButton.TabIndex = 0;
            this.MediaPlayerButton.Text = "Media Player";
            this.MediaPlayerButton.UseVisualStyleBackColor = true;
            this.MediaPlayerButton.Click += new System.EventHandler(this.MediaPlayerButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListboxMessages);
            this.groupBox4.Location = new System.Drawing.Point(9, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 161);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Messages";
            // 
            // ListboxMessages
            // 
            this.ListboxMessages.FormattingEnabled = true;
            this.ListboxMessages.Location = new System.Drawing.Point(6, 19);
            this.ListboxMessages.Name = "ListboxMessages";
            this.ListboxMessages.Size = new System.Drawing.Size(287, 134);
            this.ListboxMessages.TabIndex = 0;
            // 
            // NameSortLaunch
            // 
            this.NameSortLaunch.Enabled = false;
            this.NameSortLaunch.Location = new System.Drawing.Point(6, 45);
            this.NameSortLaunch.Name = "NameSortLaunch";
            this.NameSortLaunch.Size = new System.Drawing.Size(81, 23);
            this.NameSortLaunch.TabIndex = 1;
            this.NameSortLaunch.Text = "Name Sort";
            this.NameSortLaunch.UseVisualStyleBackColor = true;
            this.NameSortLaunch.Click += new System.EventHandler(this.NameSortLaunch_Click);
            // 
            // JMCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 404);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JMCClient";
            this.Text = "JMC Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxLoginPass;
        private System.Windows.Forms.TextBox TextboxLoginName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextboxServerAddress;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button MediaPlayerButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox ListboxMessages;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button NameSortLaunch;
    }
}

