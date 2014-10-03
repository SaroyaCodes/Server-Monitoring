using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace UserInterface
{
    public partial class SMTP_Settings : Form
    {
        public SMTP_Settings()
        {
            InitializeComponent();
        }

        private void SMTP_Settings_Load(object sender, EventArgs e)
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
            SMTPserver.Text = appSettingsSection.Settings["SMTP_server"].Value;
            EmailAddress.Text = appSettingsSection.Settings["Email"].Value;
            if (appSettingsSection.Settings["UserName"].Value !=string.Empty)
            {
                IsAuthentication.Checked = true;
                AuthenticationUser.Text = appSettingsSection.Settings["UserName"].Value;
                AuthenticationPass.Text = appSettingsSection.Settings["Password"].Value;
            }
            else
            {
                AuthenticationPass.ReadOnly =true;
                AuthenticationUser.ReadOnly = true;
            }
            PortNo.Text = appSettingsSection.Settings["Port"].Value;
            counter.Text = appSettingsSection.Settings["Count"].Value;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (SMTPserver.Text != string.Empty && EmailAddress.Text != string.Empty && PortNo.Text != string.Empty)
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                AppSettingsSection appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
                if (appSettingsSection != null)
                {
                    appSettingsSection.Settings["Email"].Value = EmailAddress.Text;
                    appSettingsSection.Settings["SMTP_server"].Value = SMTPserver.Text;
                    appSettingsSection.Settings["Port"].Value = PortNo.Text;
                    appSettingsSection.Settings["Count"].Value = counter.Text;
                    if (IsAuthentication.Checked)
                    {
                        appSettingsSection.Settings["UserName"].Value = AuthenticationUser.Text;
                        appSettingsSection.Settings["Password"].Value = AuthenticationPass.Text;
                    }
                    else
                    {
                        appSettingsSection.Settings["UserName"].Value = string.Empty;
                        appSettingsSection.Settings["Password"].Value = string.Empty;
                    }
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.SectionName);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("SMTP Server, Email and Port cann't be Empty");
            }
        }

        private void IsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsAuthentication.Checked)
            {
                AuthenticationPass.Text = string.Empty;
                AuthenticationPass.ReadOnly = true;
                AuthenticationUser.Text = string.Empty;
                AuthenticationUser.ReadOnly = true;
            }
            else
            {
                AuthenticationPass.Text = ConfigurationSettings.AppSettings["Password"];
                AuthenticationPass.ReadOnly = false;
                AuthenticationUser.Text = ConfigurationSettings.AppSettings["UserName"];
                AuthenticationUser.ReadOnly = false;
            }
        }

        private void CloseSmtpForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

