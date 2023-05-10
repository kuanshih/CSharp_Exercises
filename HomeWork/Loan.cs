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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }
        static Double Loan = 0;
        static Double Year = 0;
        static Double Rate = 0;
        static Double DPTM = 0;
        static double LoanShouldreturn = 0;
        static Double r = 0;
        static Double m = 0;
        static Double rpn = 0;
        static Double PMT = 0;
        static double total = 0;
        static int finalPMT = 0;
        static int finalTotal = 0;

        public void method()
        {
            Loan = Double.Parse(txt_Num.Text);
            Year = Double.Parse(txt_Year.Text);
            Rate = Double.Parse(txt_Rate.Text);
            DPTM = Double.Parse(txt_DnPy.Text);
            LoanShouldreturn = Loan - DPTM;
            r = 1 + Rate / 12 / 100; //月利率+1
            m = Year * 12;   //月數
            rpn = Math.Pow(r, m); //(1+月利率)^月數
            PMT = LoanShouldreturn * rpn * (r - 1) / (rpn - 1);
        }


        public object Environmental { get; private set; }
        public void btn_Month_Click(object sender, EventArgs e)
        {
            //Loan = Double.Parse(txt_Num.Text);
            //Year = Double.Parse(txt_Year.Text);
            //Rate = Double.Parse(txt_Rate.Text);
            //DPTM = Double.Parse(txt_DnPy.Text);

            //r = 1 + Rate / 12 / 100; //月利率+1
            //m = Year * 12;   //月數
            //rpn = Math.Pow(r, m); //(1+月利率)^月數
            //PMT = Loan * rpn * (r - 1) / (rpn - 1);   //貸款金額*(1+月利率)^月數*(r-1)/{[(1+月利率)^月數]-1}  因r有加一，因此要減1回來
            method();

            MessageBox.Show("每月應繳: " + (int)PMT);
            //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
        }


        private void btn_Tottal_Click_1(object sender, EventArgs e)
        {
            method();

            total = PMT * Year * 12;
            MessageBox.Show("總付款金額: " + (int)total);
        }

        private void btn_Report_Click_1(object sender, EventArgs e)
        {
            method();
            finalPMT = Convert.ToInt32(PMT);
            total = PMT * Year * 12;
            finalTotal = Convert.ToInt32(total);


            Loan_Report r = new Loan_Report();
            r.txtLoan.Text = txt_Num.Text;
            r.txtYear.Text = txt_Year.Text;
            r.txtRate.Text = txt_Rate.Text;
            r.txtMonthPMT.Text = finalPMT.ToString();
            r.txtTotal.Text = finalTotal.ToString();
            r.Show();
        }
    }
}
