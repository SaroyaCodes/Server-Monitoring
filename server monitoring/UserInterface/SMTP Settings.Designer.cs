namespace UserInterface
{
    partial class SMTP_Settings
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
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.SMTPserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthenticationGroup = new System.Windows.Forms.GroupBox();
            this.Pass = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.AuthenticationUser = new System.Windows.Forms.TextBox();
            this.AuthenticationPass = new System.Windows.Forms.TextBox();
            this.IsAuthentication = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortSetting = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortNo = new System.Windows.Forms.TextBox();
            this.CloseSmtpForm = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.countergroupbox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.AuthenticationGroup.SuspendLayout();
            this.PortSetting.SuspendLayout();
            this.countergroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmailAddress);
            this.groupBox1.Controls.Add(this.SMTPserver);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(107, 41);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(177, 20);
            this.EmailAddress.TabIndex = 3;
            // 
            // SMTPserver
            // 
            this.SMTPserver.Location = new System.Drawing.Point(107, 15);
            this.SMTPserver.Name = "SMTPserver";
            this.SMTPserver.Size = new System.Drawing.Size(177, 20);
            this.SMTPserver.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Server:";
            // 
            // AuthenticationGroup
            // 
            this.AuthenticationGroup.Controls.Add(this.Pass);
            this.AuthenticationGroup.Controls.Add(this.User);
            this.AuthenticationGroup.Controls.Add(this.AuthenticationUser);
            this.AuthenticationGroup.Controls.Add(this.AuthenticationPass);
            this.AuthenticationGroup.Controls.Add(this.IsAuthentication);
            this.AuthenticationGroup.Location = new System.Drawing.Point(2, 101);
            this.AuthenticationGroup.Name = "AuthenticationGroup";
            this.AuthenticationGroup.Size = new System.Drawing.Size(290, 105);
            this.AuthenticationGroup.TabIndex = 1;
            this.AuthenticationGroup.TabStop = false;
            this.AuthenticationGroup.Text = "Authentication";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(11, 77);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(56, 13);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password:";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(11, 51);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(60, 13);
            this.User.TabIndex = 3;
            this.User.Text = "UserName:";
            // 
            // AuthenticationUser
            // 
            this.AuthenticationUser.Location = new System.Drawing.Point(107, 48);
            this.AuthenticationUser.Name = "AuthenticationUser";
            this.AuthenticationUser.Size = new System.Drawing.Size(174, 20);
            this.AuthenticationUser.TabIndex = 2;
            // 
            // AuthenticationPass
            // 
            this.AuthenticationPass.Location = new System.Drawing.Point(107, 74);
            this.AuthenticationPass.Name = "AuthenticationPass";
            this.AuthenticationPass.Size = new System.Drawing.Size(174, 20);
            this.AuthenticationPass.TabIndex = 1;
            // 
            // IsAuthentication
            // 
            this.IsAuthentication.AutoSize = true;
            this.IsAuthentication.Location = new System.Drawing.Point(37, 21);
            this.IsAuthentication.Name = "IsAuthentication";
            this.IsAuthentication.Size = new System.Drawing.Size(149, 17);
            this.IsAuthentication.TabIndex = 0;
            this.IsAuthentication.Text = "   Authentication Required";
            this.IsAuthentication.UseVisualStyleBackColor = true;
            this.IsAuthentication.CheckedChanged += new System.EventHandler(this.IsAuthentication_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter SMTP Settings Below";
            // 
            // PortSetting
            // 
            this.PortSetting.Controls.Add(this.label4);
            this.PortSetting.Controls.Add(this.PortNo);
            this.PortSetting.Location = new System.Drawing.Point(2, 212);
            this.PortSetting.Name = "PortSetting";
            this.PortSetting.Size = new System.Drawing.Size(290, 62);
            this.PortSetting.TabIndex = 3;
            this.PortSetting.TabStop = false;
            this.PortSetting.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMTP Port :";
            // 
            // PortNo
            // 
            this.PortNo.Location = new System.Drawing.Point(163, 24);
            this.PortNo.Name = "PortNo";
            this.PortNo.Size = new System.Drawing.Size(37, 20);
            this.PortNo.TabIndex = 0;
            // 
            // CloseSmtpForm
            // 
            this.CloseSmtpForm.Location = new System.Drawing.Point(216, 350);
            this.CloseSmtpForm.Name = "CloseSmtpForm";
            this.CloseSmtpForm.Size = new System.Drawing.Size(70, 23);
            this.CloseSmtpForm.TabIndex = 4;
            this.CloseSmtpForm.Text = "Close";
            this.CloseSmtpForm.UseVisualStyleBackColor = true;
            this.CloseSmtpForm.Click += new System.EventHandler(this.CloseSmtpForm_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(140, 350);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(70, 23);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // countergroupbox
            // 
            this.countergroupbox.Controls.Add(this.label5);
            this.countergroupbox.Controls.Add(this.counter);
            this.countergroupbox.Location = new System.Drawing.Point(2, 280);
            this.countergroupbox.Name = "countergroupbox";
            this.countergroupbox.Size = new System.Drawing.Size(290, 64);
            this.countergroupbox.TabIndex = 6;
            this.countergroupbox.TabStop = false;
            this.countergroupbox.Text = "Counter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Send Mail on Fail Count :";
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(163, 25);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(37, 20);
            this.counter.TabIndex = 0;
            // 
            // SMTP_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 373);
            this.Controls.Add(this.countergroupbox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.CloseSmtpForm);
            this.Controls.Add(this.PortSetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthenticationGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "SMTP_Settings";
            this.Text = "SMTP_Settings";
            this.Load += new System.EventHandler(this.SMTP_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AuthenticationGroup.ResumeLayout(false);
            this.AuthenticationGroup.PerformLayout();
            this.PortSetting.ResumeLayout(false);
            this.PortSetting.PerformLayout();
            this.countergroupbox.ResumeLayout(false);
            this.countergroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox SMTPserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AuthenticationGroup;
        private System.Windows.Forms.CheckBox IsAuthentication;
        private System.Windows.Forms.TextBox AuthenticationUser;
        private System.Windows.Forms.TextBox AuthenticationPass;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PortSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortNo;
        private System.Windows.Forms.Button CloseSmtpForm;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.GroupBox countergroupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox counter;

    }
}
