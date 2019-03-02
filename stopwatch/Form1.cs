using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        private DateTime startTime, startTime2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (buttStart.Text == "Start")
            {
                buttStart.Text = "Pause";
                startTime = DateTime.Now;
            }
            else if (buttStart.Text == "Pause")
            {
                buttStart.Text = "Start";
                startTime2 = DateTime.Parse(lblST.Text);
            }

            timerST.Enabled = !timerST.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime2 = default(DateTime);
            lblST.Text = ("00:00:00.0000");
            timerST.Stop();
            buttStart.Text = "Start";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(DateTime.Now.Ticks - startTime.Ticks + startTime2.Ticks);
            lblST.Text = span.ToString("hh\\.mm\\.ss\\.ffff");
        }
    }
}
