using System.Configuration;
namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtReportloc = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endrange = new System.Windows.Forms.TextBox();
            this.startrange = new System.Windows.Forms.TextBox();
            this.rbIPAddressrange = new System.Windows.Forms.RadioButton();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.rbIPAddress = new System.Windows.Forms.RadioButton();
            this.rbCurrentSystem = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chkboxServices = new System.Windows.Forms.CheckBox();
            this.chkboxClient = new System.Windows.Forms.CheckBox();
            this.chkboxServers = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReportloc
            // 
            this.txtReportloc.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtReportloc.Location = new System.Drawing.Point(75, 28);
            this.txtReportloc.Name = "txtReportloc";
            this.txtReportloc.Size = new System.Drawing.Size(182, 22);
            this.txtReportloc.TabIndex = 1;
            this.txtReportloc.Text = ConfigurationSettings.AppSettings["FILEPATH"].ToString();
            // 
            // browsebutton
            // 
            this.browsebutton.Font = new System.Drawing.Font("Calibri", 9F);
            this.browsebutton.Location = new System.Drawing.Point(257, 28);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(70, 22);
            this.browsebutton.TabIndex = 1;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtfilename);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.browsebutton);
            this.groupBox1.Controls.Add(this.txtReportloc);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSave.Location = new System.Drawing.Point(257, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtfilename
            // 
            this.txtfilename.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtfilename.Location = new System.Drawing.Point(75, 56);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(182, 22);
            this.txtfilename.TabIndex = 4;
            this.txtfilename.Text = ConfigurationSettings.AppSettings["FILENAME"].ToString();
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F);
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.endrange);
            this.groupBox3.Controls.Add(this.startrange);
            this.groupBox3.Controls.Add(this.rbIPAddressrange);
            this.groupBox3.Controls.Add(this.txtIPAddress);
            this.groupBox3.Controls.Add(this.rbIPAddress);
            this.groupBox3.Controls.Add(this.rbCurrentSystem);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F);
            this.label4.Location = new System.Drawing.Point(199, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(35, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "From:";
            // 
            // endrange
            // 
            this.endrange.Font = new System.Drawing.Font("Calibri", 9F);
            this.endrange.Location = new System.Drawing.Point(228, 48);
            this.endrange.Name = "endrange";
            this.endrange.Size = new System.Drawing.Size(99, 22);
            this.endrange.TabIndex = 8;
            // 
            // startrange
            // 
            this.startrange.Font = new System.Drawing.Font("Calibri", 9F);
            this.startrange.Location = new System.Drawing.Point(99, 48);
            this.startrange.Name = "startrange";
            this.startrange.Size = new System.Drawing.Size(94, 22);
            this.startrange.TabIndex = 7;
            // 
            // rbIPAddressrange
            // 
            this.rbIPAddressrange.AutoSize = true;
            this.rbIPAddressrange.Location = new System.Drawing.Point(17, 50);
            this.rbIPAddressrange.Name = "rbIPAddressrange";
            this.rbIPAddressrange.Size = new System.Drawing.Size(14, 13);
            this.rbIPAddressrange.TabIndex = 7;
            this.rbIPAddressrange.TabStop = true;
            this.rbIPAddressrange.UseVisualStyleBackColor = true;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtIPAddress.Location = new System.Drawing.Point(99, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(228, 22);
            this.txtIPAddress.TabIndex = 6;
            // 
            // rbIPAddress
            // 
            this.rbIPAddress.AutoSize = true;
            this.rbIPAddress.Font = new System.Drawing.Font("Calibri", 9F);
            this.rbIPAddress.Location = new System.Drawing.Point(17, 77);
            this.rbIPAddress.Name = "rbIPAddress";
            this.rbIPAddress.Size = new System.Drawing.Size(82, 18);
            this.rbIPAddress.TabIndex = 5;
            this.rbIPAddress.TabStop = true;
            this.rbIPAddress.Text = "IP Address";
            this.rbIPAddress.UseVisualStyleBackColor = true;
            this.rbIPAddress.CheckedChanged += new System.EventHandler(this.radioButtongrp_CheckedChanged);
            // 
            // rbCurrentSystem
            // 
            this.rbCurrentSystem.AutoSize = true;
            this.rbCurrentSystem.Checked = true;
            this.rbCurrentSystem.Font = new System.Drawing.Font("Calibri", 9F);
            this.rbCurrentSystem.Location = new System.Drawing.Point(17, 24);
            this.rbCurrentSystem.Name = "rbCurrentSystem";
            this.rbCurrentSystem.Size = new System.Drawing.Size(105, 18);
            this.rbCurrentSystem.TabIndex = 0;
            this.rbCurrentSystem.TabStop = true;
            this.rbCurrentSystem.Text = "Current system";
            this.rbCurrentSystem.UseVisualStyleBackColor = true;
            this.rbCurrentSystem.CheckedChanged += new System.EventHandler(this.radioButtongrp_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.chkboxServices);
            this.groupBox4.Controls.Add(this.chkboxClient);
            this.groupBox4.Controls.Add(this.chkboxServers);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 134);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report Details";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Calibri", 9F);
            this.radioButton4.Location = new System.Drawing.Point(244, 49);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 18);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Adobe PDF";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 9F);
            this.radioButton1.Location = new System.Drawing.Point(167, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 18);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MS Excel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkboxServices
            // 
            this.chkboxServices.AutoSize = true;
            this.chkboxServices.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkboxServices.Location = new System.Drawing.Point(25, 97);
            this.chkboxServices.Name = "chkboxServices";
            this.chkboxServices.Size = new System.Drawing.Size(70, 18);
            this.chkboxServices.TabIndex = 7;
            this.chkboxServices.Text = "Services";
            this.chkboxServices.UseVisualStyleBackColor = true;
            // 
            // chkboxClient
            // 
            this.chkboxClient.AutoSize = true;
            this.chkboxClient.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkboxClient.Location = new System.Drawing.Point(25, 73);
            this.chkboxClient.Name = "chkboxClient";
            this.chkboxClient.Size = new System.Drawing.Size(64, 18);
            this.chkboxClient.TabIndex = 6;
            this.chkboxClient.Text = "Clients";
            this.chkboxClient.UseVisualStyleBackColor = true;
            // 
            // chkboxServers
            // 
            this.chkboxServers.AutoSize = true;
            this.chkboxServers.Enabled = false;
            this.chkboxServers.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkboxServers.Location = new System.Drawing.Point(25, 49);
            this.chkboxServers.Name = "chkboxServers";
            this.chkboxServers.Size = new System.Drawing.Size(65, 18);
            this.chkboxServers.TabIndex = 5;
            this.chkboxServers.Text = "Servers";
            this.chkboxServers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Report about:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(149, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the format for the report:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 449);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "SystemInfoUtility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtReportloc;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbIPAddress;
        private System.Windows.Forms.RadioButton rbCurrentSystem;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkboxServices;
        private System.Windows.Forms.CheckBox chkboxClient;
        private System.Windows.Forms.CheckBox chkboxServers;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbIPAddressrange;
        private System.Windows.Forms.TextBox endrange;
        private System.Windows.Forms.TextBox startrange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;

    }
}

