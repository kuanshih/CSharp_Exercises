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
    public partial class Barpos : Form
    {
        public Barpos()
        {
            InitializeComponent();
     
        }
        int Cola = 0;
        int Juice = 0;
        int Wisky = 0;
        int Beer = 0;
        int total = 0;
        string colaorder = "", juiceorder = "", wiskyorder = "", beerorder = "", display = "尚未點餐";


        //internal Display()
        //{
        //    if 
        //}

        private void btnCola_Click_1(object sender, EventArgs e)
        {
            Cola += 1;
            //colaorder = "可樂Cola x "+Cola+"共NT$"+Cola*100+"元";
            colaorder = $"可樂Cola x {Cola} 共NT$ {Cola * 100}元{Environment.NewLine}";
            total += 100;
            display = $"{colaorder}{juiceorder}{wiskyorder}{beerorder}";
            txtOrderList.Text = display;
            txtTotalPrice.Text = "NT$" + total.ToString();
        }

        private void btnJuice_Click_1(object sender, EventArgs e)
        {
            Juice += 1;
            //juiceorder = "果汁Juice x " + Juice + "共NT$" + Juice * 120 + "元";
            juiceorder = $"果汁Juice x {Juice} 共NT$ {Juice * 120}元{Environment.NewLine}";
            total += 120;
            display = $"{colaorder}{juiceorder}{wiskyorder}{beerorder}";
            txtOrderList.Text = display;
            txtTotalPrice.Text = "NT$" + total.ToString();
        }

        private void btnWisky_Click_1(object sender, EventArgs e)
        {
            Wisky += 1;
            //wiskyorder = "威士忌Wisky x " + Wisky + "共NT$" + Wisky * 350 + "元";
            wiskyorder = $"威士忌Wisky x {Wisky} 共NT${Wisky * 350}元{Environment.NewLine}";
            total += 350;
            display = $"{colaorder}{juiceorder}{wiskyorder}{beerorder}";
            txtOrderList.Text = display;
            txtTotalPrice.Text = "NT$" + total.ToString();
        }

        private void btnBeer_Click_1(object sender, EventArgs e)
        {
            Beer += 1;
            //beerorder = "啤酒Beer x " + Beer + "共NT$" + Beer * 350 + "元";
            beerorder = $"啤酒Beer x {Beer} 共NT${Beer * 350}元{Environment.NewLine}";
            total += 150;
            display = $"{colaorder}{juiceorder}{wiskyorder}{beerorder}";
            txtOrderList.Text = display;
            txtTotalPrice.Text = "NT$" + total.ToString();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            colaorder = "";
            juiceorder = "";
            wiskyorder = "";
            beerorder = "";
            display = "";
            txtOrderList.Text = "尚未點餐";
            Cola = 0;
            Juice = 0;
            Wisky = 0;
            Beer = 0;
            total = 0;
            txtTotalPrice.Text = "NT$0" + total.ToString();
        }

        private void btnCraditCard_Click_1(object sender, EventArgs e)
        {
            double Discount = total * 0.9;
            if (total > 0)
            {
                MessageBox.Show("總金額NT$:" + total.ToString() + Environment.NewLine + "折扣金額NT$:" + Discount.ToString());
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
        }

        private void btnCash_Click_1(object sender, EventArgs e)
        {
            if (total > 0)
            {
                MessageBox.Show("總金額NT$:" + total.ToString());
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
        }
    }

}
