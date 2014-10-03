using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace UserInterface
{
    public partial class MailAlert : Form
    {
        public MailAlert()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty && textBox2.Text != string.Empty && textBox8.Text != string.Empty)
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
                if (appSettingsSection != null)
                {
                    appSettingsSection.Settings["Email"].Value = textBox2.Text;
                    appSettingsSection.Settings["SMTP_server"].Value = textBox3.Text;
                    appSettingsSection.Settings["Port"].Value = textBox1.Text;
                    appSettingsSection.Settings["Count"].Value = textBox8.Text;
                    appSettingsSection.Settings["Emailto"].Value = textBox4.Text;
                    appSettingsSection.Settings["UserName"].Value = textBox5.Text;
                    appSettingsSection.Settings["Password"].Value = textBox6.Text;
                    
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.SectionName);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("SMTP Server, Email and Port cann't be Empty");
            }




            //str= this.textBox6.Text.ToString();
           /* SmtpClient client = new SmtpClient(this.textBox3.Text,587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress(this.textBox2.Text, "admin");
            MailAddress to = new MailAddress(this.textBox4.Text, "");
            MailMessage message = new MailMessage(from, to);
            //message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = this.textBox7.Text;
            NetworkCredential myCreds = new NetworkCredential(this.textBox5.Text,this.textBox6.Text, "");
            client.Credentials = myCreds;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {

            }*/
        }

        private void MailAlert_Load(object sender, EventArgs e)
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
            textBox3.Text = appSettingsSection.Settings["SMTP_server"].Value;
            textBox2.Text = appSettingsSection.Settings["Email"].Value;
           textBox1.Text = appSettingsSection.Settings["Port"].Value;
            textBox8.Text = appSettingsSection.Settings["Count"].Value;
        }
    }
}
