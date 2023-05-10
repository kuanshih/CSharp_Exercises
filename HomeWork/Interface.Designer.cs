namespace HomeWork
{
    partial class Interface
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.btnXOGame = new System.Windows.Forms.Button();
            this.btnForDoWhile = new System.Windows.Forms.Button();
            this.btnMyClac = new System.Windows.Forms.Button();
            this.btnStudentGradeList = new System.Windows.Forms.Button();
            this.btnStudentGrade = new System.Windows.Forms.Button();
            this.btnStudentStructForm = new System.Windows.Forms.Button();
            this.btnBarPos = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.BackgroundImage = global::HomeWork.Properties.Resources.Background1;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 564);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.btnXOGame);
            this.splitContainer2.Panel1.Controls.Add(this.btnForDoWhile);
            this.splitContainer2.Panel1.Controls.Add(this.btnMyClac);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGradeList);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGrade);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentStructForm);
            this.splitContainer2.Panel1.Controls.Add(this.btnBarPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(800, 419);
            this.splitContainer2.SplitterDistance = 234;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuess.Location = new System.Drawing.Point(0, 280);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(10);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(234, 28);
            this.btnGuess.TabIndex = 10;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScreenSaver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreenSaver.Location = new System.Drawing.Point(0, 252);
            this.btnScreenSaver.Margin = new System.Windows.Forms.Padding(10);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(234, 28);
            this.btnScreenSaver.TabIndex = 9;
            this.btnScreenSaver.Text = "Screen Saver";
            this.btnScreenSaver.UseVisualStyleBackColor = true;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // btnXOGame
            // 
            this.btnXOGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXOGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXOGame.Location = new System.Drawing.Point(0, 224);
            this.btnXOGame.Margin = new System.Windows.Forms.Padding(10);
            this.btnXOGame.Name = "btnXOGame";
            this.btnXOGame.Size = new System.Drawing.Size(234, 28);
            this.btnXOGame.TabIndex = 8;
            this.btnXOGame.Text = "XOGame";
            this.btnXOGame.UseVisualStyleBackColor = true;
            this.btnXOGame.Click += new System.EventHandler(this.btnXOGame_Click);
            // 
            // btnForDoWhile
            // 
            this.btnForDoWhile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForDoWhile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForDoWhile.Location = new System.Drawing.Point(0, 196);
            this.btnForDoWhile.Margin = new System.Windows.Forms.Padding(10);
            this.btnForDoWhile.Name = "btnForDoWhile";
            this.btnForDoWhile.Size = new System.Drawing.Size(234, 28);
            this.btnForDoWhile.TabIndex = 7;
            this.btnForDoWhile.Text = "ForDoWhile";
            this.btnForDoWhile.UseVisualStyleBackColor = true;
            this.btnForDoWhile.Click += new System.EventHandler(this.btnForDoWhile_Click);
            // 
            // btnMyClac
            // 
            this.btnMyClac.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMyClac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyClac.Location = new System.Drawing.Point(0, 168);
            this.btnMyClac.Margin = new System.Windows.Forms.Padding(10);
            this.btnMyClac.Name = "btnMyClac";
            this.btnMyClac.Size = new System.Drawing.Size(234, 28);
            this.btnMyClac.TabIndex = 6;
            this.btnMyClac.Text = "MyClac";
            this.btnMyClac.UseVisualStyleBackColor = true;
            this.btnMyClac.Click += new System.EventHandler(this.btnMyClac_Click);
            // 
            // btnStudentGradeList
            // 
            this.btnStudentGradeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentGradeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentGradeList.Location = new System.Drawing.Point(0, 140);
            this.btnStudentGradeList.Margin = new System.Windows.Forms.Padding(10);
            this.btnStudentGradeList.Name = "btnStudentGradeList";
            this.btnStudentGradeList.Size = new System.Drawing.Size(234, 28);
            this.btnStudentGradeList.TabIndex = 5;
            this.btnStudentGradeList.Text = "Student_Grade_List";
            this.btnStudentGradeList.UseVisualStyleBackColor = true;
            this.btnStudentGradeList.Click += new System.EventHandler(this.btnStudentGradeList_Click);
            // 
            // btnStudentGrade
            // 
            this.btnStudentGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentGrade.Location = new System.Drawing.Point(0, 112);
            this.btnStudentGrade.Margin = new System.Windows.Forms.Padding(10);
            this.btnStudentGrade.Name = "btnStudentGrade";
            this.btnStudentGrade.Size = new System.Drawing.Size(234, 28);
            this.btnStudentGrade.TabIndex = 4;
            this.btnStudentGrade.Text = "Student_Grade";
            this.btnStudentGrade.UseVisualStyleBackColor = true;
            this.btnStudentGrade.Click += new System.EventHandler(this.btnStudentGrade_Click);
            // 
            // btnStudentStructForm
            // 
            this.btnStudentStructForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentStructForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentStructForm.Location = new System.Drawing.Point(0, 84);
            this.btnStudentStructForm.Margin = new System.Windows.Forms.Padding(10);
            this.btnStudentStructForm.Name = "btnStudentStructForm";
            this.btnStudentStructForm.Size = new System.Drawing.Size(234, 28);
            this.btnStudentStructForm.TabIndex = 3;
            this.btnStudentStructForm.Text = "Student_StructForm";
            this.btnStudentStructForm.UseVisualStyleBackColor = true;
            this.btnStudentStructForm.Click += new System.EventHandler(this.btnStudentStructForm_Click);
            // 
            // btnBarPos
            // 
            this.btnBarPos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBarPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarPos.Location = new System.Drawing.Point(0, 56);
            this.btnBarPos.Margin = new System.Windows.Forms.Padding(10);
            this.btnBarPos.Name = "btnBarPos";
            this.btnBarPos.Size = new System.Drawing.Size(234, 28);
            this.btnBarPos.TabIndex = 2;
            this.btnBarPos.Text = "BarPos";
            this.btnBarPos.UseVisualStyleBackColor = true;
            this.btnBarPos.Click += new System.EventHandler(this.btnBarPos_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.Location = new System.Drawing.Point(0, 28);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(234, 28);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHello.Location = new System.Drawing.Point(0, 0);
            this.btnHello.Margin = new System.Windows.Forms.Padding(10);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(234, 28);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlarm.Location = new System.Drawing.Point(0, 308);
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(10);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(234, 28);
            this.btnAlarm.TabIndex = 11;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Interface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnScreenSaver;
        private System.Windows.Forms.Button btnXOGame;
        private System.Windows.Forms.Button btnForDoWhile;
        private System.Windows.Forms.Button btnMyClac;
        private System.Windows.Forms.Button btnStudentGradeList;
        private System.Windows.Forms.Button btnStudentGrade;
        private System.Windows.Forms.Button btnStudentStructForm;
        private System.Windows.Forms.Button btnBarPos;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnAlarm;
    }
}

