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
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sizeW = 10;
        int sizeH = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnPic.Left += sizeW;
            btnPic.Top += sizeH;
            if (btnPic.Location.X + btnPic.Width > Screen.PrimaryScreen.Bounds.Width || btnPic.Location.X < 0)
                sizeW *= -1;
            if (btnPic.Location.Y + btnPic.Height > Screen.PrimaryScreen.Bounds.Height || btnPic.Location.Y < 0)
                sizeH *= -1;
        }
    }
}
