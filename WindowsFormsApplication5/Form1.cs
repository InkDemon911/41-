using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer2.Enabled = true;
            timer2.Interval = 2000;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random r = new Random();
            int i = r.Next(1, 39);
            string b = Convert.ToString(i);
            textBox1.Text =(b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
