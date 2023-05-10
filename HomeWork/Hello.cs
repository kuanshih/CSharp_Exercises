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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            String Name = txt_Name.Text;
            String EngName = txt_EngName.Text;
            String Sex = txt_Sex.Text;
            String StarSign = txt_starSign.Text;
            MessageBox.Show("Hello, " + "我是" + Name + "," + "\n " + "我的英文名字是" + EngName + "\n " + "我的性別是" + Sex + "," + "\n " + "我的星座是" + StarSign + "," + "\n " + "很高興認識你。");
        }

        private void txt_Sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EngName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_starSign_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            String Name = txt_Name.Text;
            String EngName = txt_EngName.Text;
            String Sex = txt_Sex.Text;
            String StarSign = txt_starSign.Text;
            MessageBox.Show("Hi, " + "我是" + Name + "," + "\n " + "我的英文名字是" + EngName + "\n " + "我的性別是" + Sex + "," + "\n " + "我的星座是" + StarSign + "," + "\n " + "很高興認識你。");
        }

        private void lbl_StarSign_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Sex_Click(object sender, EventArgs e)
        {

        }

        private void lbl_EngName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
