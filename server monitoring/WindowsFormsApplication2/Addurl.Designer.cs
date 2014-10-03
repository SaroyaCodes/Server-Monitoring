namespace WindowsFormsApplication2
{
    partial class Addurl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SentEmailTo = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonitorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorpoll = new System.Windows.Forms.Label();
            this.PollTime = new System.Windows.Forms.NumericUpDown();
            this.Poll = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PollTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SentEmailTo);
            this.groupBox2.Controls.Add(this.error);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Controls.Add(this.URL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MonitorName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter URL Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monitor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Send Email To";
            // 
            // SentEmailTo
            // 
            this.SentEmailTo.Location = new System.Drawing.Point(112, 140);
            this.SentEmailTo.Name = "SentEmailTo";
            this.SentEmailTo.Size = new System.Drawing.Size(213, 20);
            this.SentEmailTo.TabIndex = 11;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Firebrick;
            this.error.Location = new System.Drawing.Point(60, 20);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(112, 114);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(213, 20);
            this.password.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(112, 88);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(213, 20);
            this.Username.TabIndex = 2;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(112, 62);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(213, 20);
            this.URL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // MonitorName
            // 
            this.MonitorName.Location = new System.Drawing.Point(112, 36);
            this.MonitorName.Name = "MonitorName";
            this.MonitorName.Size = new System.Drawing.Size(213, 20);
            this.MonitorName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.errorpoll);
            this.groupBox3.Controls.Add(this.PollTime);
            this.groupBox3.Controls.Add(this.Poll);
            this.groupBox3.Location = new System.Drawing.Point(0, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Poll Time";
            // 
            // errorpoll
            // 
            this.errorpoll.AutoSize = true;
            this.errorpoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorpoll.ForeColor = System.Drawing.Color.Firebrick;
            this.errorpoll.Location = new System.Drawing.Point(102, 16);
            this.errorpoll.Name = "errorpoll";
            this.errorpoll.Size = new System.Drawing.Size(0, 13);
            this.errorpoll.TabIndex = 3;
            // 
            // PollTime
            // 
            this.PollTime.Location = new System.Drawing.Point(100, 33);
            this.PollTime.Name = "PollTime";
            this.PollTime.Size = new System.Drawing.Size(58, 20);
            this.PollTime.TabIndex = 2;
            // 
            // Poll
            // 
            this.Poll.AutoSize = true;
            this.Poll.BackColor = System.Drawing.SystemColors.Control;
            this.Poll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poll.Location = new System.Drawing.Point(164, 33);
            this.Poll.Name = "Poll";
            this.Poll.Size = new System.Drawing.Size(121, 15);
            this.Poll.TabIndex = 1;
            this.Poll.Text = "Poll Time in seconds";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(129, 280);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(58, 23);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(193, 280);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(61, 23);
            this.resetbutton.TabIndex = 11;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(260, 280);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 306);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Add URL";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PollTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SentEmailTo;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MonitorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label errorpoll;
        private System.Windows.Forms.NumericUpDown PollTime;
        private System.Windows.Forms.Label Poll;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button Close;
    }
}

