using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace UserInterface
{
    public partial class Form2 : Form
    {  public string hostname;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void ipadd()
        {
            StringBuilder sb = new StringBuilder();
           
            hostname = this.textBox1.Text;
            var address = Dns.GetHostAddresses(hostname)[0];
            sb.Append("the address is:" +address.ToString());
            IPHostEntry ip = Dns.GetHostEntry(address);
            string hostnam = ip.HostName;
            sb.Append(System.Environment.NewLine);
            sb.Append("the hostname is:"+hostnam);
            string s = sb.ToString();
            MessageBox.Show(s); 
           // MessageBox.Show("IP Address of current domain is: " +address.ToString(), "and hostname is:" +hostnam);
           // MessageBox.Show("hostname is:"+hostnam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipadd();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
