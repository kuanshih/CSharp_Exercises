using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm_Alarm : Form
    {
        System.Timers.Timer timer;
        public Frm_Alarm()
        {
            InitializeComponent();
        }
        private void Alarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer1.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if(currentTime.Hour == userTime.Hour &&  currentTime.Minute == userTime.Minute &&currentTime.Second==userTime.Second)
            {
                timer.Stop();
                MessageBox.Show("Ring ring ring......");
                
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            labStatus.Text = "Running";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            labStatus.Text = "Stop";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
