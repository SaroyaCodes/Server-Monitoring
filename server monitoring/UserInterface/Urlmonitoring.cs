using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Net.Mail;
//using log4net;
//using log4net.Config;

public delegate void Indexchanging();
public delegate void Addmonitorstatus(string status);

namespace UserInterface
{
    public partial class urlmonitoringform : Form
    {
        private static NotifyIcon trayIcon;
        private static ContextMenu trayMenu;
        private static List<monitoringdetails> monitorurl = new List<monitoringdetails>();
       // private static readonly ILog logger = LogManager.GetLogger(typeof(urlmonitoringform));

        public static string Ischanged { get; set; }
        public static string monitor { get; set; }
        public static string url { get; set; }
        public static string email { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static decimal poll { get; set; }

        public urlmonitoringform()
        {
            InitializeComponent();
            //log4net.Config.XmlConfigurator.Configure();
        }

        public void addurl()
        {
            Ischanged = string.Empty;
            bool ifurlexist = checkifexist();

            if (!ifurlexist)
            {
                SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
                try
                {
                    connection.Open();
                    SqlCommand CmdSql = new SqlCommand("INSERT INTO [URLDetails] (MonitorName, URL, UserName, PassWord, Email, PollTime,Createdon) VALUES (@MonitorName, @URL, @UserName, @PassWord, @Email, @PollTime, @createdon)", connection);
                    DateTime dt = DateTime.Now;
                    CmdSql.Parameters.AddWithValue("@MonitorName", monitor);
                    CmdSql.Parameters.AddWithValue("@URL", url);
                    CmdSql.Parameters.AddWithValue("@UserName", username);
                    CmdSql.Parameters.AddWithValue("@PassWord", password);
                    CmdSql.Parameters.AddWithValue("@Email", email);
                    CmdSql.Parameters.AddWithValue("@PollTime", poll);
                    CmdSql.Parameters.AddWithValue("@createdon", dt);
                    CmdSql.ExecuteNonQuery();
                    MessageBox.Show("URL Detailes Saved Sucessfully");
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
                monitor = string.Empty;
                url = string.Empty;
                email = string.Empty;
                username = string.Empty;
                password = string.Empty;
                poll = 0;
            }
        }

        public void SaveInDatabase()
        {
            Ischanged = string.Empty;
            //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            try
            {
                connection.Open();
                SqlCommand CmdSql = new SqlCommand("UPDATE URLDetails SET URL=@URL,UserName=@UserName,PassWord=@PassWord,Email=@Email,PollTime=@PollTime Where MonitorName=@Monitor", connection);
                CmdSql.Parameters.AddWithValue("@Monitor", monitor);
                CmdSql.Parameters.AddWithValue("@URL", url);
                CmdSql.Parameters.AddWithValue("@UserName", username);
                CmdSql.Parameters.AddWithValue("@PassWord", password);
                CmdSql.Parameters.AddWithValue("@Email", email);
                CmdSql.Parameters.AddWithValue("@PollTime", poll);
                CmdSql.ExecuteNonQuery();
                MessageBox.Show("URL Detailes Saved Sucessfully");
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
            monitor = string.Empty;
            url = string.Empty;
            email = string.Empty;
            username = string.Empty;
            password = string.Empty;
            poll = 0;
        }

        private bool checkifexist()
        {
            List<string> allurl = new List<string>();
            //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            try
            {
                connection.Open();
                SqlCommand mysql = new SqlCommand("SELECT URL FROM [URLDetails] Where URL=@urlvalue OR MonitorName=@monitorvalue", connection);
                mysql.Parameters.AddWithValue("@urlvalue", url);
                mysql.Parameters.AddWithValue("@monitorvalue", monitor);
                SqlDataReader data = mysql.ExecuteReader();
                if (data.HasRows)
                {
                    MessageBox.Show("URL or Monitor Name Already Exist");
                    connection.Close();
                    return true;

                }
                connection.Close();
                return false;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            MoveToTray();
        }

        private static void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnShow(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
            trayIcon.Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //MoveToTray();
            //e.Cancel = true;

        }

        private void MoveToTray()
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Show", OnShow);
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);
            trayIcon.ContextMenu = trayMenu;
            trayIcon.DoubleClick += OnShow;
            trayIcon.Visible = true;
            Visible = false;
            ShowInTaskbar = false;
        }

        public void DisplayMonitorList()
        {
            List<String> urllist = new List<string>();
            //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            try
            {
                connection.Open();
                SqlCommand CmdSql = new SqlCommand("SELECT MonitorName FROM [URLDetails] Where Isactive=1", connection);
                SqlDataReader data = CmdSql.ExecuteReader();

                while (data.Read())
                {
                    urllist.Add(data["MonitorName"].ToString());
                }
            }
            catch (Exception e)
            {
                //urllist.Add(e.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            //urltobemonitored.Items.Clear();
            urltobemonitored.DataSource = urllist;
            //urltobemonitored.Refresh();
        }

        private void urlmonitoringform_Load(object sender, EventArgs e)
        {
            Ischanged = string.Empty;
            monitorurl = FillUrlMonitorList();
            DisplayMonitorList();
        }
        private void disablebutton_Click(object sender, EventArgs e)
        { //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            try
            {
                connection.Open();
                DateTime dt = DateTime.Now;
                SqlCommand CmdSql = new SqlCommand("UPDATE URLDetails SET Isactive=0,ModifiedOn=@date Where MonitorName=@Monitor", connection);
                CmdSql.Parameters.AddWithValue("@Monitor", urltobemonitored.SelectedItem);
                CmdSql.Parameters.AddWithValue("@date", dt);
                CmdSql.ExecuteNonQuery();
                monitorurl = FillUrlMonitorList();
                DisplayMonitorList();


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
       
      
        private void Trigger_Tick(object sender, EventArgs e)
        {
            if (Ischanged != string.Empty)
            {
                if (Ischanged == "Add")
                { addurl(); }
                else
                {
                    if (Ischanged == "Save")
                        SaveInDatabase();
                }
                DisplayMonitorList();
                monitorurl = FillUrlMonitorList();
                Ischanged = string.Empty;
            }
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        private void Testurl()
        {
            foreach (monitoringdetails tobemonitored in monitorurl)
            {
                string user = tobemonitored.username.Trim();
                string pass = tobemonitored.password.Trim();
                DateTime dt = tobemonitored.time;
                user.ToString();
                if ((tobemonitored.time.AddSeconds(tobemonitored.polltime)) <= DateTime.Now)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tobemonitored.url);
                    if (tobemonitored.username.ToString() != string.Empty)
                    {
                        CredentialCache credcache = new CredentialCache();
                        credcache.Add(new Uri(tobemonitored.url), "Digest", new NetworkCredential(user, pass));
                        request.Credentials = credcache;
                    }
                    System.Diagnostics.Stopwatch timer = new Stopwatch();
                    timer.Start();
                    MonitorStatus.Invoke(new Addmonitorstatus(AddtoMonitor),new object[]{string.Format("Monitoring URL: {0}", tobemonitored.url)});
                    this.Invoke(new Indexchanging(onindexchanging));
                    try
                    {
                                              
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        timer.Stop();
                        response.Close();
                        
                        TimeSpan timeTaken = timer.Elapsed;
                        MonitorStatus.Invoke(new Addmonitorstatus(AddtoMonitor), new object[] { string.Format("Status: " + response.StatusCode.ToString()) });
                        MonitorStatus.Invoke(new Addmonitorstatus(AddtoMonitor), new object[] { string.Format("Response Time: " +timeTaken) });
                        this.Invoke(new Indexchanging(onindexchanging));
                    }
                    catch (WebException ex)
                    {
                        MonitorStatus.Invoke(new Addmonitorstatus(AddtoMonitor), new object[] { string.Format("Status: " + ex.ToString()) });
                        this.Invoke(new Indexchanging(onindexchanging));
                        if (tobemonitored.counter == tobemonitored.countto)
                        {
                            tobemonitored.counter = 0;
                            sendmail(tobemonitored.Monitor, tobemonitored.url, tobemonitored.email, ex.ToString());
                        }
                        else
                            tobemonitored.counter++;

                        //LogErrorMessage(string.Format("{0} not responding", tobemonitored.url.Trim()), ex);
                    }
                    tobemonitored.time = DateTime.Now;
                }
            }
        }

        public void AddtoMonitor(string status)
        {
            MonitorStatus.Items.Add(status);
        }

        private static List<monitoringdetails> FillUrlMonitorList()
        {
            List<monitoringdetails> templist = new List<monitoringdetails>();
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            try
            {
                connection.Open();
                DateTime dt = DateTime.Now;
                SqlCommand CmdSql = new SqlCommand("SELECT MonitorName,URL,UserName,PassWord,Email,PollTime FROM [URLDetails] Where Isactive=1", connection);
                SqlDataReader data = CmdSql.ExecuteReader();
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
                while (data.Read())
                {
                    monitoringdetails temp = new monitoringdetails();
                    temp.Monitor = data["MonitorName"].ToString();
                    temp.url = data["URL"].ToString();
                    temp.username = data["UserName"].ToString();
                    temp.password = data["PassWord"].ToString();
                    temp.email = data["Email"].ToString().Split(',');
                    temp.polltime = Convert.ToDouble(data["PollTime"]);
                    temp.time = dt;
                    temp.counter = 0;
                    temp.countto = Convert.ToInt32(appSettingsSection.Settings["Count"].Value);
                    templist.Add(temp);
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
            return templist;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddUrl.EditMonitor = string.Empty;
            AddUrl window = new AddUrl();
            window.Show();

        }

       

        public void onindexchanging()
        {
            int NumberOfItems = MonitorStatus.ClientSize.Height / MonitorStatus.ItemHeight;
            if (MonitorStatus.TopIndex == MonitorStatus.Items.Count - NumberOfItems - 1)
            {
                MonitorStatus.TopIndex = MonitorStatus.Items.Count - NumberOfItems + 1;
            }
            if (MonitorStatus.Items.Count >= 3000)
            {
                MonitorStatus.Items.RemoveAt(0);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }
       

        private void Clearstatus_Click(object sender, EventArgs e)
        {
            MonitorStatus.Items.Clear();
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            EditUrlDetails();
        
        }
        
        private void EditUrlDetails()
        {
            AddUrl.EditMonitor = urltobemonitored.Text;
            AddUrl window = new AddUrl();
            window.Show();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            View_All_URL window = new View_All_URL();
            window.Show();
        }

        private void SMTPSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MailAlert window = new MailAlert();
            window.Show();
            //SMTP_Settings window = new SMTP_Settings();
            //window.Show();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Testurl();
        }

        private void sendmail(string monitor,string url,string[] emailto,string error)
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
            string emailfrom = appSettingsSection.Settings["Email"].Value;
            SmtpClient client = new SmtpClient(appSettingsSection.Settings["SMTP_server"].Value, 587);
            string sub = "Failure Report";
            client.EnableSsl = true;
            string msg = string.Format("Monitoring of {0}failed", monitor);
            string emailtoo = appSettingsSection.Settings["Emailto"].Value;
            MailAddress from = new MailAddress(emailfrom, "admin");
            MailAddress to = new MailAddress(emailtoo, "");
            MailMessage message = new MailMessage(from.ToString(), to.ToString(), sub, msg);
           // MailMessage message = new MailMessage(from,to,sub,msg);
            //message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = sub;
            
            message.Body = msg;
            string user = appSettingsSection.Settings["UserName"].Value;
            string pass = appSettingsSection.Settings["Password"].Value;
            NetworkCredential myCreds = new NetworkCredential(user,pass, "");
            client.Credentials = myCreds;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {

            }




           // StreamReader reader = new StreamReader(ConfigurationSettings.AppSettings["MailPath"]);
            //string mailbody = reader.ReadToEnd();
           
            //string Subject = string.Format("Monitoring of {0} failed", monitor);
            //SmtpClient client = new SmtpClient(appSettingsSection.Settings["SMTP_server"].Value,Convert.ToInt32(appSettingsSection.Settings["Port"].Value));
           /* foreach (string emailtovalue in emailto)
            {
                try
                {
                    MailMessage message = new MailMessage(emailfrom, emailtovalue.Trim(), Subject, mailbody);
                    message.Body.Replace("@MonitorName", monitor);
                    message.Body.Replace("@MonitorUrl", url);
                    message.Body.Replace("@Status", "Not Working");
                    message.Body.Replace("@Error", error);
                    message.IsBodyHtml = true;
                    client.Send(message);
                }
                catch ( Exception ex)
                {
                    LogErrorMessage(ex.Message, ex);
                }
            }*/

        }

       /* public void LogErrorMessage(String message, Exception ex)
        {
            logger.Error(message, ex);
        }*/

       
       
        

      
       

        

       
    }
}