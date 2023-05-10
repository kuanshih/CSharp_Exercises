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
    public partial class StudentGrade_list : Form
    {
        studentG isStu;
        List<studentG> stu = new List<studentG>();
        string max3 = "";
        string min3 = "";
        int max1 = 0;
        int max2 = 0;
        int min1 = 0;
        int min2 = 0;
        int count = 0;
        int ChiTotal = 0;
        int EngTotal = 0;
        int MathTotal = 0;
        int finalCMax = 0;
        int finalEMax = 0;
        int finalMMax = 0;
        int finalCMin = 100;
        int finalEMin = 100;
        int finalMMin = 100;
        internal int max(int a, int b, int c)
        {

            max1 = (a > b) ? a : b;
            max2 = (max1 > c) ? max1 : c;
            return max2;
        }
        internal int min(int a, int b, int c)
        {

            min1 = (a < b) ? a : b;
            min2 = (min1 < c) ? min1 : c;
            return min2;
        }
        internal void minMethod()
        {
            if (min2 == isStu.Chi)
            {
                min3 = "國文";
            }
            else if (min2 == isStu.Engl)
            {
                min3 = "英文";
            }
            else if (min2 == isStu.Math)
            {
                min3 = "數學";
            }
        }
        internal void maxMethod()
        {
            if (max2 == isStu.Chi)
            {
                max3 = "國文";
            }
            else if (max2 == isStu.Engl)
            {
                max3 = "英文";
            }
            else if (max2 == isStu.Math)
            {
                max3 = "數學";
            }


        }
        internal void Dispaly()
        {
            foreach (studentG isStu in stu)
            {
                labShow.Text += $"{isStu.Name}                  {isStu.Chi}        {isStu.Engl}        {isStu.Math}        總分:{isStu.Total} 平均:{isStu.Average} {isStu.min}:{isStu.Lowest}   {isStu.max}:{isStu.Highest}\n";
                if (isStu.Chi > finalCMax)
                {
                    finalCMax = isStu.Chi;
                }
                if (isStu.Engl > finalEMax)
                {
                    finalEMax = isStu.Engl;
                }
                if (isStu.Math > finalMMax)
                {
                    finalMMax = isStu.Math;
                }
                if (isStu.Chi < finalCMin)
                {
                    finalCMin = isStu.Chi;
                }
                if (isStu.Engl < finalEMin)
                {
                    finalEMin = isStu.Engl;
                }
                if (isStu.Math < finalMMin)
                {
                    finalMMin = isStu.Math;
                }
            }
        }
        public StudentGrade_list()
        {
            InitializeComponent();
        }

        private void btnAddStudnetData_Click(object sender, EventArgs e)
        {
            isStu.Name = txtName.Text;
            isStu.Chi = int.Parse(txtChinese.Text);
            isStu.Engl = int.Parse(txtEnglish.Text);
            isStu.Math = int.Parse(txtMath.Text);
            isStu.Total = isStu.Chi + isStu.Engl + isStu.Math;
            isStu.Average = ((isStu.Chi + isStu.Engl + isStu.Math) / 3);
            isStu.Lowest = min(isStu.Chi, isStu.Engl, isStu.Math).ToString();
            isStu.Highest = max(isStu.Chi, isStu.Engl, isStu.Math).ToString();
            count += 1;
            maxMethod();
            minMethod();
            isStu.min = min3;
            isStu.max = max3;
            stu.Add(isStu);
            ChiTotal += isStu.Chi;
            EngTotal += isStu.Engl;
            MathTotal += isStu.Math;
            labShow.Text = "";
            Dispaly();
        }

        private void btnRamdomSaveData_Click(object sender, EventArgs e)
        {
            count += 1;
            Random rnd = new Random();
            int ram = rnd.Next(101);
            isStu.Name = count.ToString();
            isStu.Chi = rnd.Next(101);
            isStu.Engl = rnd.Next(101);
            isStu.Math = rnd.Next(101);
            isStu.Total = isStu.Chi + isStu.Engl + isStu.Math;
            isStu.Average = ((isStu.Chi + isStu.Engl + isStu.Math) / 3);
            isStu.Lowest = min(isStu.Chi, isStu.Engl, isStu.Math).ToString();
            isStu.min = min3;
            isStu.Highest = max(isStu.Chi, isStu.Engl, isStu.Math).ToString();
            maxMethod();
            minMethod();
            isStu.min = min3;
            isStu.max = max3;
            stu.Add(isStu);
            ChiTotal += isStu.Chi;
            EngTotal += isStu.Engl;
            MathTotal += isStu.Math;
            labShow.Text = "";
            Dispaly();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            labResult.Text = $"總分:     {ChiTotal}     {EngTotal}     {MathTotal}\n" +
$"平均:     {ChiTotal / count}     {EngTotal / count}     {MathTotal / count}\n" +
$"最高分:     {finalCMax}     {finalEMax}     {finalMMax}\n" +
$"最低分:     {finalCMin}     {finalEMin}     {finalMMin}";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            stu.Clear();
            labShow.Text = "";
            labResult.Text = "";
            count = 0;
            max3 = "";
            min3 = "";
            max1 = 0;
            max2 = 0;
            min1 = 0;
            min2 = 0;
            count = 0;
            ChiTotal = 0;
            EngTotal = 0;
            MathTotal = 0;
            finalCMax = 0;
            finalEMax = 0;
            finalMMax = 0;
            finalCMin = 100;
            finalEMin = 100;
            finalMMin = 100;
        }

        private void btnRamdomAdd20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                btnRamdomSaveData.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int ChiLow = int.Parse(txtChiLow.Text) ;
            int ChiHigh = int.Parse(txtChiHieght.Text);
            //for()
            //    if (ChiLow <= isStu.Chi && isStu.Chi <= ChiHigh)
            //{
            //    Show();

            //}
                

        }
    }
}
