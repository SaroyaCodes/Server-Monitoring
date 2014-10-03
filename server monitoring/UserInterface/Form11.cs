using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using NetWatch;
//using IpHIpApi.net;

namespace UserInterface
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Run(new urlmonitoringform());
            urlmonitoringform window= new urlmonitoringform();
            //window.Text = "a";
            window.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 window = new Form2();
            window.Show();
            

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 window = new Form3();
            window.Show();
        }
        
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm window = new MainForm();
           window.Show();
            //SMTP_Settings window = new SMTP_Settings();
            //window.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form13 window = new Form13();
            //window.Show();

        }


    }
}
