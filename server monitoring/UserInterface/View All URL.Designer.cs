namespace UserInterface
{
    partial class View_All_URL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urlgroup = new System.Windows.Forms.GroupBox();
            this.ActiveUrlGrid = new System.Windows.Forms.DataGridView();
            this.MonitorActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PollActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeactivateURL = new System.Windows.Forms.DataGridViewImageColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            this.urlgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveUrlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // urlgroup
            // 
            this.urlgroup.Controls.Add(this.ActiveUrlGrid);
            this.urlgroup.Location = new System.Drawing.Point(2, 7);
            this.urlgroup.Name = "urlgroup";
            this.urlgroup.Size = new System.Drawing.Size(664, 381);
            this.urlgroup.TabIndex = 0;
            this.urlgroup.TabStop = false;
            this.urlgroup.Text = "Url Monitored";
            // 
            // ActiveUrlGrid
            // 
            this.ActiveUrlGrid.AllowUserToAddRows = false;
            this.ActiveUrlGrid.AllowUserToDeleteRows = false;
            this.ActiveUrlGrid.AllowUserToResizeRows = false;
            this.ActiveUrlGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ActiveUrlGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ActiveUrlGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveUrlGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonitorActive,
            this.UrlActive,
            this.PollActive,
            this.Status,
            this.DeactivateURL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveUrlGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ActiveUrlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveUrlGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActiveUrlGrid.Location = new System.Drawing.Point(3, 16);
            this.ActiveUrlGrid.Name = "ActiveUrlGrid";
            this.ActiveUrlGrid.ReadOnly = true;
            this.ActiveUrlGrid.Size = new System.Drawing.Size(658, 362);
            this.ActiveUrlGrid.TabIndex = 0;
            this.ActiveUrlGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiveUrlGrid_CellContentClick);
            // 
            // MonitorActive
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MonitorActive.DefaultCellStyle = dataGridViewCellStyle1;
            this.MonitorActive.DividerWidth = 1;
            this.MonitorActive.HeaderText = "Name";
            this.MonitorActive.Name = "MonitorActive";
            this.MonitorActive.ReadOnly = true;
            this.MonitorActive.Width = 85;
            // 
            // UrlActive
            // 
            this.UrlActive.HeaderText = "URL";
            this.UrlActive.Name = "UrlActive";
            this.UrlActive.ReadOnly = true;
            this.UrlActive.Width = 110;
            // 
            // PollActive
            // 
            this.PollActive.HeaderText = "Poll Time";
            this.PollActive.Name = "PollActive";
            this.PollActive.ReadOnly = true;
            this.PollActive.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // DeactivateURL
            // 
            this.DeactivateURL.FillWeight = 10F;
            this.DeactivateURL.HeaderText = "";
            this.DeactivateURL.Name = "DeactivateURL";
            this.DeactivateURL.ReadOnly = true;
            this.DeactivateURL.ToolTipText = "DeactivateURL";
            this.DeactivateURL.Width = 24;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(156, 394);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // View_All_URL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 425);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.urlgroup);
            this.Name = "View_All_URL";
            this.Text = "All URL Monitored";
            this.Load += new System.EventHandler(this.View_All_URL_Load);
            this.urlgroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveUrlGrid)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.GroupBox urlgroup;
        private System.Windows.Forms.DataGridView ActiveUrlGrid;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PollActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn DeactivateURL;
       
    }
}