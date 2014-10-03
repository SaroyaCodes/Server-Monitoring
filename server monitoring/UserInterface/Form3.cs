using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace UserInterface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void portcalc()
        {
            
            string port = this.textBox2.Text;
            bool isAvailable = true;
            int a = Convert.ToInt32(port);
            
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == a)
                {
                    isAvailable = false;
                   
                }
            }

            if(isAvailable)
            {MessageBox.Show("Port is available");
            }
                else
                {
                    MessageBox.Show("Port is not available");
                
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            portcalc();
        }
        }
    }

