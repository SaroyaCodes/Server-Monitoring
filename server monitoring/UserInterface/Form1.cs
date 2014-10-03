using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryPerformanceMonitoring;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 window = new Form11();
            window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 window = new Form12();
            window.ShowDialog();
            //Application.Run(new Form12());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
