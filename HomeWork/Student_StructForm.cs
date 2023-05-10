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
    public partial class Student_StructForm : Form
    {
        int num = 0;
        int num1 = 1;
        public Student_StructForm()
        {
            InitializeComponent();
        }

        private void BntSave_Click(object sender, EventArgs e)
        {
            num1 = num++;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (num1 != num)
            {
                txtList.Text = $"姓名: {txtName.Text} {Environment.NewLine}" +
                    $"國文 :  {txtChinese.Text}分{Environment.NewLine}" +
                    $"英文 : {txtEng.Text}分{Environment.NewLine}" +
                    $"數學 : {txtMath.Text}分";
                num1 = num;
            }
            else
            {
                return;
            }
        }

        private void btnHightLow_Click(object sender, EventArgs e)
        {
            int largest = 0;
            int smallest = 0;
            string largest1 = "";
            string smallest1 = "";
            //txtHightLow.Clear();

            if (int.Parse(txtChinese.Text) > int.Parse(txtMath.Text) && int.Parse(txtChinese.Text) > int.Parse(txtEng.Text))
            {
                largest = int.Parse(txtChinese.Text);
                largest1 = "中文" + txtChinese.Text + "分";
            }
            if (int.Parse(txtMath.Text) > int.Parse(txtChinese.Text) && int.Parse(txtMath.Text) > int.Parse(txtEng.Text))
            {
                largest = int.Parse(txtMath.Text);
                largest1 = "數學" + txtMath.Text + "分";
            }
            if (int.Parse(txtEng.Text) > int.Parse(txtMath.Text) && int.Parse(txtEng.Text) > int.Parse(txtChinese.Text))
            {
                largest = int.Parse(txtEng.Text);
                largest1 = "英文" + txtEng.Text + "分";
            }


            if (int.Parse(txtChinese.Text) < int.Parse(txtMath.Text) && int.Parse(txtChinese.Text) < int.Parse(txtEng.Text))
            {
                smallest = int.Parse(txtChinese.Text);
                smallest1 = "中文" + txtChinese.Text + "分";
            }
            if (int.Parse(txtEng.Text) < int.Parse(txtMath.Text) && int.Parse(txtEng.Text) < int.Parse(txtChinese.Text))
            {
                smallest = int.Parse(txtEng.Text);
                smallest1 = "英文" + txtEng.Text + "分";
            }
            if (int.Parse(txtMath.Text) < int.Parse(txtChinese.Text) && int.Parse(txtMath.Text) < int.Parse(txtEng.Text))
            {
                smallest = int.Parse(txtEng.Text);
                smallest1 = "數學" + txtMath.Text + "分";
            }

            txtHightLow.Text = $"最高科目成績為:{largest1}{Environment.NewLine}最低科目成績為: {smallest1}";
        
        
    
        }
    
    }
}
