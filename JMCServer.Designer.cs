
namespace Activity4Server
{
    partial class JMCServer
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
            this.TextboxPipeName = new System.Windows.Forms.TextBox();
            this.ButtonStartServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListboxUsers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextboxNewUserName = new System.Windows.Forms.TextBox();
            this.TextboxNewUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextboxValidator = new System.Windows.Forms.TextBox();
            this.ButtonValidateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxValidatePass = new System.Windows.Forms.TextBox();
            this.TextboxValidateName = new System.Windows.Forms.TextBox();
            this.ListboxOutput = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TextboxClientsConnected = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxPipeName
            // 
            this.TextboxPipeName.Location = new System.Drawing.Point(6, 19);
            this.TextboxPipeName.Name = "TextboxPipeName";
            this.TextboxPipeName.Size = new System.Drawing.Size(189, 20);
            this.TextboxPipeName.TabIndex = 0;
            this.TextboxPipeName.Text = "\\\\.\\pipe\\JMCServer";
            // 
            // ButtonStartServer
            // 
            this.ButtonStartServer.Location = new System.Drawing.Point(201, 16);
            this.ButtonStartServer.Name = "ButtonStartServer";
            this.ButtonStartServer.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartServer.TabIndex = 1;
            this.ButtonStartServer.Text = "Start Server";
            this.ButtonStartServer.UseVisualStyleBackColor = true;
            this.ButtonStartServer.Click += new System.EventHandler(this.ButtonStartServer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextboxPipeName);
            this.groupBox1.Controls.Add(this.ButtonStartServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Address";
            // 
            // ListboxUsers
            // 
            this.ListboxUsers.FormattingEnabled = true;
            this.ListboxUsers.Location = new System.Drawing.Point(7, 19);
            this.ListboxUsers.Name = "ListboxUsers";
            this.ListboxUsers.Size = new System.Drawing.Size(269, 485);
            this.ListboxUsers.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListboxUsers);
            this.groupBox2.Location = new System.Drawing.Point(301, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 520);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UserList";
            // 
            // TextboxNewUserName
            // 
            this.TextboxNewUserName.Location = new System.Drawing.Point(72, 19);
            this.TextboxNewUserName.Name = "TextboxNewUserName";
            this.TextboxNewUserName.Size = new System.Drawing.Size(100, 20);
            this.TextboxNewUserName.TabIndex = 4;
            // 
            // TextboxNewUserPass
            // 
            this.TextboxNewUserPass.Location = new System.Drawing.Point(72, 46);
            this.TextboxNewUserPass.Name = "TextboxNewUserPass";
            this.TextboxNewUserPass.PasswordChar = '*';
            this.TextboxNewUserPass.Size = new System.Drawing.Size(100, 20);
            this.TextboxNewUserPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(178, 44);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddUser.TabIndex = 8;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextboxNewUserName);
            this.groupBox3.Controls.Add(this.ButtonAddUser);
            this.groupBox3.Controls.Add(this.TextboxNewUserPass);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextboxValidator);
            this.groupBox4.Controls.Add(this.ButtonValidateUser);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TextboxValidatePass);
            this.groupBox4.Controls.Add(this.TextboxValidateName);
            this.groupBox4.Location = new System.Drawing.Point(12, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 128);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Validate User";
            // 
            // TextboxValidator
            // 
            this.TextboxValidator.Enabled = false;
            this.TextboxValidator.Location = new System.Drawing.Point(89, 89);
            this.TextboxValidator.Name = "TextboxValidator";
            this.TextboxValidator.Size = new System.Drawing.Size(187, 20);
            this.TextboxValidator.TabIndex = 5;
            // 
            // ButtonValidateUser
            // 
            this.ButtonValidateUser.Location = new System.Drawing.Point(8, 87);
            this.ButtonValidateUser.Name = "ButtonValidateUser";
            this.ButtonValidateUser.Size = new System.Drawing.Size(75, 23);
            this.ButtonValidateUser.TabIndex = 4;
            this.ButtonValidateUser.Text = "Validate";
            this.ButtonValidateUser.UseVisualStyleBackColor = true;
            this.ButtonValidateUser.Click += new System.EventHandler(this.ButtonValidateUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // TextboxValidatePass
            // 
            this.TextboxValidatePass.Location = new System.Drawing.Point(77, 47);
            this.TextboxValidatePass.Name = "TextboxValidatePass";
            this.TextboxValidatePass.PasswordChar = '*';
            this.TextboxValidatePass.Size = new System.Drawing.Size(100, 20);
            this.TextboxValidatePass.TabIndex = 1;
            // 
            // TextboxValidateName
            // 
            this.TextboxValidateName.Location = new System.Drawing.Point(77, 19);
            this.TextboxValidateName.Name = "TextboxValidateName";
            this.TextboxValidateName.Size = new System.Drawing.Size(100, 20);
            this.TextboxValidateName.TabIndex = 0;
            // 
            // ListboxOutput
            // 
            this.ListboxOutput.FormattingEnabled = true;
            this.ListboxOutput.Location = new System.Drawing.Point(6, 19);
            this.ListboxOutput.Name = "ListboxOutput";
            this.ListboxOutput.Size = new System.Drawing.Size(270, 160);
            this.ListboxOutput.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ListboxOutput);
            this.groupBox5.Location = new System.Drawing.Point(12, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 193);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TextboxClientsConnected);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(12, 489);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 43);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connected";
            // 
            // TextboxClientsConnected
            // 
            this.TextboxClientsConnected.Enabled = false;
            this.TextboxClientsConnected.Location = new System.Drawing.Point(72, 13);
            this.TextboxClientsConnected.Name = "TextboxClientsConnected";
            this.TextboxClientsConnected.Size = new System.Drawing.Size(100, 20);
            this.TextboxClientsConnected.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Clients";
            // 
            // JMCServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 544);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JMCServer";
            this.Text = "JMC Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxPipeName;
        private System.Windows.Forms.Button ButtonStartServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListboxUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxNewUserPass;
        private System.Windows.Forms.TextBox TextboxNewUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TextboxValidator;
        private System.Windows.Forms.Button ButtonValidateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxValidatePass;
        private System.Windows.Forms.TextBox TextboxValidateName;
        private System.Windows.Forms.ListBox ListboxOutput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TextboxClientsConnected;
        private System.Windows.Forms.Label label5;
    }
}

