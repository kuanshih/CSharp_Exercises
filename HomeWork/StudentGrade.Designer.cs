namespace HomeWork
{
    partial class StudentGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labResult = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnRamdomAdd20 = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnRamdomSaveData = new System.Windows.Forms.Button();
            this.btnAddStudnetData = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labResult
            // 
            this.labResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labResult.Location = new System.Drawing.Point(298, 342);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(401, 131);
            this.labResult.TabIndex = 30;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(3, 28);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(2, 14);
            this.labShow.TabIndex = 29;
            // 
            // btnRamdomAdd20
            // 
            this.btnRamdomAdd20.Location = new System.Drawing.Point(95, 450);
            this.btnRamdomAdd20.Name = "btnRamdomAdd20";
            this.btnRamdomAdd20.Size = new System.Drawing.Size(169, 23);
            this.btnRamdomAdd20.TabIndex = 28;
            this.btnRamdomAdd20.Text = "隨機加入20筆";
            this.btnRamdomAdd20.UseVisualStyleBackColor = true;
            this.btnRamdomAdd20.Click += new System.EventHandler(this.btnRamdomAdd20_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(95, 421);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(169, 23);
            this.bReset.TabIndex = 27;
            this.bReset.Text = "重設所有資料";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(95, 371);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(169, 23);
            this.btnSubjects.TabIndex = 26;
            this.btnSubjects.Text = "各科統計";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnRamdomSaveData
            // 
            this.btnRamdomSaveData.Location = new System.Drawing.Point(95, 342);
            this.btnRamdomSaveData.Name = "btnRamdomSaveData";
            this.btnRamdomSaveData.Size = new System.Drawing.Size(169, 23);
            this.btnRamdomSaveData.TabIndex = 25;
            this.btnRamdomSaveData.Text = "隨機儲存資料";
            this.btnRamdomSaveData.UseVisualStyleBackColor = true;
            this.btnRamdomSaveData.Click += new System.EventHandler(this.btnRamdomSaveData_Click);
            // 
            // btnAddStudnetData
            // 
            this.btnAddStudnetData.Location = new System.Drawing.Point(95, 313);
            this.btnAddStudnetData.Name = "btnAddStudnetData";
            this.btnAddStudnetData.Size = new System.Drawing.Size(169, 23);
            this.btnAddStudnetData.TabIndex = 24;
            this.btnAddStudnetData.Text = "加入學生資料";
            this.btnAddStudnetData.UseVisualStyleBackColor = true;
            this.btnAddStudnetData.Click += new System.EventHandler(this.btnAddStudnetData_Click);
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(164, 248);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 22);
            this.txtMath.TabIndex = 23;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Location = new System.Drawing.Point(93, 258);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(32, 12);
            this.labMath.TabIndex = 22;
            this.labMath.Text = "數學:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(164, 193);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 22);
            this.txtEnglish.TabIndex = 21;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(93, 203);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(32, 12);
            this.labEnglish.TabIndex = 20;
            this.labEnglish.Text = "英文:";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(164, 127);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 22);
            this.txtChinese.TabIndex = 19;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(93, 137);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(32, 12);
            this.labChinese.TabIndex = 18;
            this.labChinese.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 17;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(93, 78);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(32, 12);
            this.labName.TabIndex = 16;
            this.labName.Text = "姓名:";
            // 
            // labTitle
            // 
            this.labTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTitle.Location = new System.Drawing.Point(3, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(395, 277);
            this.labTitle.TabIndex = 31;
            this.labTitle.Text = "姓名           國文    英文    數學    總分    平均    最低科目    最高課目";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labShow);
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Location = new System.Drawing.Point(298, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 280);
            this.panel1.TabIndex = 32;
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnRamdomAdd20);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnRamdomSaveData);
            this.Controls.Add(this.btnAddStudnetData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.panel1);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnRamdomAdd20;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnRamdomSaveData;
        private System.Windows.Forms.Button btnAddStudnetData;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
    }
}