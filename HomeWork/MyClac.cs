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
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal num1 = Convert.ToDecimal(txtNum1.Text) + Convert.ToDecimal(txtNum2.Text);
            txtAnswer.Text = num1.ToString();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Decimal num2 = Convert.ToDecimal(txtNum1.Text) - Convert.ToDecimal(txtNum2.Text);
            txtAnswer.Text = num2.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Decimal num3 = Convert.ToDecimal(txtNum1.Text) * Convert.ToDecimal(txtNum2.Text);
            txtAnswer.Text = num3.ToString();
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            Decimal num4 = Convert.ToDecimal(txtNum1.Text) / Convert.ToDecimal(txtNum2.Text);
            txtAnswer.Text = num4.ToString();
        }
    }
}
