using System;
using System.Collections;
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
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }
        ArrayList listcircle = new ArrayList();
        ArrayList listforks = new ArrayList();

        circle Cir;
        fork For;
        int n = 0;
        internal void Win()
        {
            if (Cir.cir1 == true && Cir.cir2 == true && Cir.cir3 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir4 == true && Cir.cir5 == true && Cir.cir6 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir7 == true && Cir.cir8 == true && Cir.cir9 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir1 == true && Cir.cir4 == true && Cir.cir7 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir2 == true && Cir.cir5 == true && Cir.cir8 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir3 == true && Cir.cir6 == true && Cir.cir9 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir1 == true && Cir.cir5 == true && Cir.cir9 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (Cir.cir3 == true && Cir.cir5 == true && Cir.cir7 == true)
            {
                MessageBox.Show("O選手獲勝");
                Reset();
            }
            else if (For.fork1 == true && For.fork2 == true && For.fork3 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork4 == true && For.fork5 == true && For.fork6 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork7 == true && For.fork8 == true && For.fork9 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork1 == true && For.fork4 == true && For.fork7 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork2 == true && For.fork5 == true && For.fork8 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork3 == true && For.fork6 == true && For.fork9 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork1 == true && For.fork5 == true && For.fork9 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (For.fork3 == true && For.fork5 == true && For.fork7 == true)
            {
                MessageBox.Show("X選手獲勝");
                Reset();
            }
            else if (n == 9)
            {
                MessageBox.Show("平局!按下確定重新開始", "完局");
                Reset();
            }
        }
        internal void Reset()
        {
            n = 0;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;
            Cir.cir1 = false;
            Cir.cir2 = false;
            Cir.cir3 = false;
            Cir.cir4 = false;
            Cir.cir5 = false;
            Cir.cir6 = false;
            Cir.cir7 = false;
            Cir.cir8 = false;
            Cir.cir9 = false;
            For.fork1 = false;
            For.fork2 = false;
            For.fork3 = false;
            For.fork4 = false;
            For.fork5 = false;
            For.fork6 = false;
            For.fork7 = false;
            For.fork8 = false;
            For.fork9 = false;
            listcircle.Clear();
            listforks.Clear();
        }
        bool Click = true;

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir1 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork1 = true;
                listforks.Add(For);
            }
            n += 1;
            btn1.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir2 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork2 = true;
                listforks.Add(For);
            }
            n += 1;
            btn2.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir3 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork3 = true;
                listforks.Add(For);
            }
            n += 1;
            btn3.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir4 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork4 = true;
                listforks.Add(For);
            }
            n += 1;
            btn4.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir5 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork5 = true;
                listforks.Add(For);
            }
            n += 1;
            btn5.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir6 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork6 = true;
                listforks.Add(For);
            }
            n += 1;
            btn6.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir7 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork7 = true;
                listforks.Add(For);
            }
            n += 1;
            btn7.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir8 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork8 = true;
                listforks.Add(For);
            }
            n += 1;
            btn8.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.BackgroundImage = Click ? Properties.Resources.circle : Properties.Resources.fork;
            if (Click == true)
            {
                Cir.cir9 = true;
                listcircle.Add(Cir);
            }
            else
            {
                For.fork9 = true;
                listforks.Add(For);
            }
            n += 1;
            btn9.Enabled = false;
            Win();
            Click = !Click;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
