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
    public partial class Guess : Form
    {
        public static Guess Instance;
        public Label lab1;
        public int test = 120;
        int ram = 0;
        public Guess()
        {
            InitializeComponent();
            Instance = this;
            lab1 = labtitle;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ram = rnd.Next(101);
            test = ram;
            staticlab.correctanswer = test;

            Guess_Plus frm = new Guess_Plus();
            frm.Owner = this;
            frm.Show();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (ram != test)
            {
                Random rnd = new Random();
                ram = rnd.Next(101);
                test = ram;
                staticlab.correctanswer = test;
            }
            MessageBox.Show("Answer: " + test.ToString());
        }
    }
}
