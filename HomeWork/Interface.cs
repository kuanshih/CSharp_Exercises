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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hello hello = new Hello();
            hello.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(hello);
            hello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Frm_Loan loan = new Frm_Loan();
            loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void btnBarPos_Click(object sender, EventArgs e)
        {
            Barpos barpos = new Barpos();
            barpos.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(barpos);
            barpos.Show();
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            Student_StructForm student_StructForm = new Student_StructForm();
            student_StructForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(student_StructForm);
            student_StructForm.Show();
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            StudentGrade studentGrade = new StudentGrade();
            studentGrade.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(studentGrade);
            studentGrade.Show();
        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            StudentGrade_list studentGrade_List = new StudentGrade_list();
            studentGrade_List.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(studentGrade_List);
            studentGrade_List.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            MyClac myClac = new MyClac();  
            myClac.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(myClac);
            myClac.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile doWhile = new ForDoWhile();  
            doWhile.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(doWhile);
            doWhile.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOGame XOGame = new XOGame();
            XOGame.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(XOGame);
            XOGame.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver screenSaver = new ScreenSaver();
            screenSaver.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(guess);
            guess.Show();
        }

        private void btnStudentGrade1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Frm_Alarm frm_Alarm = new Frm_Alarm();
            frm_Alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm_Alarm);
            frm_Alarm.Show();

        }
    }
}
