using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UserInterface
{
    public partial class AddUrl : Form
    {
        public static string EditMonitor { get; set; }

        private void AddUrl_Load(object sender, EventArgs e)
        {
            if (EditMonitor != string.Empty)
            {
                this.Text = "Edit Url";
                UrlDetailsGroupbox.Text = "Url Details";
                PollTimeGroupBox.Text = "Poll Time";
                addbutton.Text = "Save";
                resetbutton.Enabled = false;
                //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
                SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
                try
                {
                    connection.Open();
                    SqlCommand mysql = new SqlCommand("SELECT URL,UserName,PassWord,Email,PollTime FROM [URLDetails] Where MonitorName=@monitorvalue", connection);
                    mysql.Parameters.AddWithValue("@monitorvalue", EditMonitor);
                    SqlDataReader data = mysql.ExecuteReader();
                    if (data.HasRows)
                    {
                        data.Read();
                        MonitorName.Text = EditMonitor.Trim();
                        MonitorName.ReadOnly = true;
                        URL.Text = data["URL"].ToString();
                        Username.Text = data["UserName"].ToString();
                        password.Text = data["PassWord"].ToString();
                        SentEmailTo.Text = data["Email"].ToString();
                        PollTime.Value = Convert.ToDecimal(data["PollTime"]);
                    }
                }
                catch
                {
                    //
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                this.Text = "Add Url";
                UrlDetailsGroupbox.Text = "Enter URL Detail";
                PollTimeGroupBox.Text = "Select Poll Time";
                addbutton.Text = "Add";
                resetbutton.Enabled = true;
                MonitorName.Text = string.Empty;
                MonitorName.ReadOnly = false;
                URL.Text = string.Empty;
                Username.Text = string.Empty;
                password.Text = string.Empty;
                SentEmailTo.Text = string.Empty;
                PollTime.Value = 0;

            }
        }

        public AddUrl()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if ((MonitorName.Text != string.Empty) && (MonitorName.Text != string.Empty) && (SentEmailTo.Text != string.Empty) && (PollTime.Value != 0))
            {
                errorpoll.Text = string.Empty;
                error.Text = string.Empty;
                urlmonitoringform.monitor = MonitorName.Text;
                urlmonitoringform.url = URL.Text;
                urlmonitoringform.username = Username.Text;
                urlmonitoringform.password = password.Text;
                urlmonitoringform.email = SentEmailTo.Text;
                urlmonitoringform.poll = PollTime.Value;
                if (EditMonitor == string.Empty)
                {
                    urlmonitoringform.Ischanged = "Add";
                    MonitorName.Text = string.Empty;
                    URL.Text = string.Empty;
                    Username.Text = string.Empty;
                    password.Text = string.Empty;
                    SentEmailTo.Text = string.Empty;
                    PollTime.Value = 0;
                }
                else
                {
                    urlmonitoringform.Ischanged = "Save";
                    EditMonitor = string.Empty;
                    this.Close();
                }
            }
            else if (PollTime.Value == 0)
            { errorpoll.Text = "Poll Time can't be 0"; }
            else
            {
                errorpoll.Text = string.Empty;
                error.Text = "Monitor Name, URL and Send Email To are Mendatory";
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            MonitorName.Text = string.Empty;
            URL.Text = string.Empty;
            Username.Text = string.Empty;
            password.Text = string.Empty;
            SentEmailTo.Text = string.Empty;
            PollTime.Value = 0;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            EditMonitor = string.Empty;
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            EditMonitor = string.Empty;
        }
    }
}
