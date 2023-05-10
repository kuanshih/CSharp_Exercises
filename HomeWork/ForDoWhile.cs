using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }
        int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtOddOrEven.Text);       //todo 要做放一個try catch
            if (n % 2 == 0)
            {
                labShow.Text = $"輸入的數{n}為偶數";
            }
            else
            {
                labShow.Text = $"輸入的數{n}為奇數";
            }
        }

        private void btnBiggistanSmallest_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int big = 0;
            int count = 0;
            int small = 1000;
            foreach (int i in arr)
            {

                labShow.Text += i + ", ";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                count += arr[i];
                if (arr[i] > big)
                {
                    big = arr[i];
                }
                if (arr[i] < small)
                {
                    small = arr[i];
                }
            }
            labShow.Text = $"int陣列arr0711[{labShow.Text}]\n" +
                $"最大值:{big}\n" +
                $"最小值:{small}\n" +
                $"Sum= {count}";
        }

        private void btnArrayOddEven_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int countodd = 0;
            int counteven = 0;
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counteven++;
                }
                if (arr[i] % 2 != 0)
                {
                    countodd++;
                }
                labShow.Text += i + ", ";
            }
            labShow.Text = $"int陣列arr0711[{labShow.Text}]\n" +
            $"奇數共:{countodd}\n" +
            $"偶數共:{counteven}";
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            string[] arrstr = { "mother張", " emma", " 迪克蕭", "j40", "Candy", "Canada", "Coconat", "MotherFucker" };
            string str = "";
            int count = 0;
            foreach (string s in arrstr)
            {
                str += s + "   ";
            }
            foreach (char c in str)
            {
                if (c == 'c' ^ c == 'C')
                {
                    count++;
                }
            }
            labShow.Text = $"str陣列arr0711[{str}]\n有'c' 及'C'共有:{count}";
        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            string[] arrstr = { "mother張", " emma", " 迪克蕭", "j40", "Candy", "Canada", "Coconat", "MotherFucker" };
            string longest = "";
            string str = "";
            foreach (string s in arrstr)
            {
                str += s + "   ";
                if (longest.Length < s.Length)
                {
                    longest = s;
                }
            }
            labShow.Text = $"str陣列arr0711[{str}]\n最長的名字為:{longest}";
        }

        private void btnsideOne_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                if(i == 0|| i==9)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        arr2[i, j] = 1;
                        labShow.Text += arr2[i, j] + "    ";
                    }
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if(j == 0|| j==9)
                        {
                            arr2[i, j] = 1;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                        else
                        {
                            arr2[i, j] = 0;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                    }
                }

                labShow.Text += Environment.NewLine;
            }
            //int[] arrstr = new int[5];
            //for (int i = 0; i < arrstr.Length; i++)
            //{
            //    arrstr[i] = i;
            //    labShow.Text += arrstr[i];
            //}

        }

        private void btnsideZero_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(i==0|| i==9|| j==0|| j == 9)
                    {
                        arr2[i, j] = 0;
                        labShow.Text += arr2[i, j] + "    ";
                    }
                    else
                    {
                        arr2[i, j] = 1;
                        labShow.Text += arr2[i, j] + "    ";
                    }
                }
                labShow.Text += Environment.NewLine;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                if(i%2 == 1)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if(j%2 == 1)
                        {
                            arr2[i, j] = 1;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                        else
                        {
                            arr2[i, j] = 0;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                    }
                }
                else 
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j % 2 == 1)
                        {
                            arr2[i, j] = 0;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                        else
                        {
                            arr2[i, j] = 1;
                            labShow.Text += arr2[i, j] + "    ";
                        }
                    }
                }
                labShow.Text += Environment.NewLine;
            }

        }
    }
}
