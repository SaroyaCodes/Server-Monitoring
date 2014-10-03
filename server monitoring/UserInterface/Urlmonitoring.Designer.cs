using System.Windows.Forms;
using System.Drawing;
namespace UserInterface
{
    partial class urlmonitoringform
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem reset;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urlmonitoringform));
            this.URLMonitoredGroupbox = new System.Windows.Forms.GroupBox();
            this.ViewAll = new System.Windows.Forms.Button();
            this.urltobemonitored = new System.Windows.Forms.ListBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.Trigger = new System.Windows.Forms.Timer(this.components);
            this.MonitoringStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.MonitorStatus = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clearstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.buttontoolstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.disablebutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Addbutton = new System.Windows.Forms.ToolStripButton();
            reset = new System.Windows.Forms.ToolStripMenuItem();
            this.URLMonitoredGroupbox.SuspendLayout();
            this.MonitoringStatusGroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.buttontoolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reset
            // 
            reset.BackColor = System.Drawing.SystemColors.MenuBar;
            reset.ForeColor = System.Drawing.SystemColors.ControlText;
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(152, 22);
            reset.Text = "Reset";
            reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // URLMonitoredGroupbox
            // 
            this.URLMonitoredGroupbox.Controls.Add(this.ViewAll);
            this.URLMonitoredGroupbox.Controls.Add(this.urltobemonitored);
            this.URLMonitoredGroupbox.Location = new System.Drawing.Point(0, 64);
            this.URLMonitoredGroupbox.Name = "URLMonitoredGroupbox";
            this.URLMonitoredGroupbox.Size = new System.Drawing.Size(504, 160);
            this.URLMonitoredGroupbox.TabIndex = 0;
            this.URLMonitoredGroupbox.TabStop = false;
            this.URLMonitoredGroupbox.Text = "Url Monitored";
            // 
            // ViewAll
            // 
            this.ViewAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewAll.Location = new System.Drawing.Point(386, 63);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(112, 23);
            this.ViewAll.TabIndex = 3;
            this.ViewAll.Text = "View All URL Details";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // urltobemonitored
            // 
            this.urltobemonitored.FormattingEnabled = true;
            this.urltobemonitored.HorizontalScrollbar = true;
            this.urltobemonitored.Location = new System.Drawing.Point(11, 19);
            this.urltobemonitored.Name = "urltobemonitored";
            this.urltobemonitored.Size = new System.Drawing.Size(369, 121);
            this.urltobemonitored.TabIndex = 2;
            // 
            // closebutton
            // 
            this.closebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closebutton.Location = new System.Drawing.Point(441, 470);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(57, 23);
            this.closebutton.TabIndex = 4;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Trigger
            // 
            this.Trigger.Enabled = true;
            this.Trigger.Interval = 1000;
            this.Trigger.Tick += new System.EventHandler(this.Trigger_Tick);
            // 
            // MonitoringStatusGroupBox
            // 
            this.MonitoringStatusGroupBox.Controls.Add(this.MonitorStatus);
            this.MonitoringStatusGroupBox.Location = new System.Drawing.Point(0, 230);
            this.MonitoringStatusGroupBox.Name = "MonitoringStatusGroupBox";
            this.MonitoringStatusGroupBox.Size = new System.Drawing.Size(504, 213);
            this.MonitoringStatusGroupBox.TabIndex = 10;
            this.MonitoringStatusGroupBox.TabStop = false;
            this.MonitoringStatusGroupBox.Text = "Monitoring Statistic";
            // 
            // MonitorStatus
            // 
            this.MonitorStatus.FormattingEnabled = true;
            this.MonitorStatus.HorizontalScrollbar = true;
            this.MonitorStatus.Location = new System.Drawing.Point(6, 16);
            this.MonitorStatus.Name = "MonitorStatus";
            this.MonitorStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MonitorStatus.Size = new System.Drawing.Size(492, 186);
            this.MonitorStatus.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            reset,
            this.Clearstatus,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.applicationToolStripMenuItem.Text = "File";
            // 
            // Clearstatus
            // 
            this.Clearstatus.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearstatus.Name = "Clearstatus";
            this.Clearstatus.Size = new System.Drawing.Size(152, 22);
            this.Clearstatus.Text = "Clear Status";
            this.Clearstatus.Click += new System.EventHandler(this.Clearstatus_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMTPSettingsToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // SMTPSettingsToolStripMenuItem
            // 
            this.SMTPSettingsToolStripMenuItem.Name = "SMTPSettingsToolStripMenuItem";
            this.SMTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SMTPSettingsToolStripMenuItem.Text = "SMTP Settings";
            this.SMTPSettingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SMTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.SMTPSettingsToolStripMenuItem_Click_1);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(516, 24);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "File Menu";
            // 
            // buttontoolstrip
            // 
            this.buttontoolstrip.AutoSize = false;
            this.buttontoolstrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttontoolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addbutton,
            this.toolStripSeparator2,
            this.editbutton,
            this.toolStripSeparator1,
            this.disablebutton,
            this.toolStripSeparator3});
            this.buttontoolstrip.Location = new System.Drawing.Point(0, 24);
            this.buttontoolstrip.Name = "buttontoolstrip";
            this.buttontoolstrip.Size = new System.Drawing.Size(516, 37);
            this.buttontoolstrip.TabIndex = 12;
            this.buttontoolstrip.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // editbutton
            // 
            this.editbutton.AutoSize = false;
            this.editbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editbutton.Image = ((System.Drawing.Image)(resources.GetObject("editbutton.Image")));
            this.editbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(43, 36);
            this.editbutton.Text = "Edit URL";
            this.editbutton.ToolTipText = "Edit URL\r\n";
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // disablebutton
            // 
            this.disablebutton.AutoSize = false;
            this.disablebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disablebutton.Image = ((System.Drawing.Image)(resources.GetObject("disablebutton.Image")));
            this.disablebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disablebutton.Name = "disablebutton";
            this.disablebutton.Size = new System.Drawing.Size(43, 36);
            this.disablebutton.Text = "disablebutton";
            this.disablebutton.ToolTipText = "Disable";
            this.disablebutton.Click += new System.EventHandler(this.disablebutton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // Addbutton
            // 
            this.Addbutton.AutoSize = false;
            this.Addbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Addbutton.Image = ((System.Drawing.Image)(resources.GetObject("Addbutton.Image")));
            this.Addbutton.ImageTransparentColor = System.Drawing.Color.Black;
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Addbutton.Size = new System.Drawing.Size(44, 36);
            this.Addbutton.Text = "Add URL";
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // urlmonitoringform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 505);
            this.Controls.Add(this.buttontoolstrip);
            this.Controls.Add(this.MonitoringStatusGroupBox);
            this.Controls.Add(this.URLMonitoredGroupbox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "urlmonitoringform";
            this.Text = "URL Monitoring";
            this.Load += new System.EventHandler(this.urlmonitoringform_Load);
            this.URLMonitoredGroupbox.ResumeLayout(false);
            this.MonitoringStatusGroupBox.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.buttontoolstrip.ResumeLayout(false);
            this.buttontoolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox URLMonitoredGroupbox;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ListBox urltobemonitored;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Timer Trigger;
        private System.Windows.Forms.GroupBox MonitoringStatusGroupBox;
        private System.Windows.Forms.ListBox MonitorStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMTPSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Clearstatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip buttontoolstrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton editbutton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ToolStripButton disablebutton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Addbutton;

    }
}

