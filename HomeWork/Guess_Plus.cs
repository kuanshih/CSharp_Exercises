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
    public partial class Guess_Plus : Form
    {
        public static Guess_Plus Instance;
        public Guess_Plus()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //Frm_Guess.Instance.lab1.Text = "jwfoeifjweof";
            staticlab.guess = int.Parse(txtGuess.Text);

            if (staticlab.guess < staticlab.correctanswer)
            {
                Guess.Instance.lab1.Text = $"Too Small!!!{Environment.NewLine}between{staticlab.guess} to 100";
                //MessageBox.Show("larger");

            }
            else if (staticlab.guess > staticlab.correctanswer)
            {
                Guess.Instance.lab1.Text = $"Too large!!!{Environment.NewLine}between  0 to {staticlab.guess} ";
            }
            else if (staticlab.guess == staticlab.correctanswer)
            {
                Guess.Instance.lab1.Text = $"correct, conget!! The answer is {staticlab.correctanswer}";
                Guess.Instance.test = 120;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
