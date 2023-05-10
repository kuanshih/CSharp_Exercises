namespace HomeWork
{
    partial class Student_StructForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHightLow = new System.Windows.Forms.TextBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnHightLow = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblChinese = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BntSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHightLow);
            this.groupBox1.Controls.Add(this.txtList);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(331, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 199);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtHightLow
            // 
            this.txtHightLow.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHightLow.Location = new System.Drawing.Point(3, 144);
            this.txtHightLow.Multiline = true;
            this.txtHightLow.Name = "txtHightLow";
            this.txtHightLow.Size = new System.Drawing.Size(171, 49);
            this.txtHightLow.TabIndex = 10;
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.Location = new System.Drawing.Point(3, 28);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(171, 110);
            this.txtList.TabIndex = 9;
            // 
            // btnHightLow
            // 
            this.btnHightLow.Location = new System.Drawing.Point(334, 319);
            this.btnHightLow.Name = "btnHightLow";
            this.btnHightLow.Size = new System.Drawing.Size(120, 23);
            this.btnHightLow.TabIndex = 24;
            this.btnHightLow.Text = "最高分/最低分科目";
            this.btnHightLow.UseVisualStyleBackColor = true;
            this.btnHightLow.Click += new System.EventHandler(this.btnHightLow_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(210, 319);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(87, 23);
            this.btnDisplay.TabIndex = 23;
            this.btnDisplay.Text = "顯示儲存內容";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(170, 252);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 22);
            this.txtMath.TabIndex = 22;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(170, 205);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 22);
            this.txtEng.TabIndex = 21;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(170, 151);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 22);
            this.txtChinese.TabIndex = 20;
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(111, 256);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(32, 12);
            this.lblMath.TabIndex = 19;
            this.lblMath.Text = "數學:";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(111, 209);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(32, 12);
            this.lblEng.TabIndex = 18;
            this.lblEng.Text = "英文:";
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Location = new System.Drawing.Point(111, 155);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(32, 12);
            this.lblChinese.TabIndex = 17;
            this.lblChinese.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 16;
            // 
            // BntSave
            // 
            this.BntSave.Location = new System.Drawing.Point(113, 319);
            this.BntSave.Name = "BntSave";
            this.BntSave.Size = new System.Drawing.Size(75, 23);
            this.BntSave.TabIndex = 15;
            this.BntSave.Text = "儲存";
            this.BntSave.UseVisualStyleBackColor = true;
            this.BntSave.Click += new System.EventHandler(this.BntSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(111, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 12);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "姓名:";
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHightLow);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.lblChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BntSave);
            this.Controls.Add(this.lblName);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHightLow;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnHightLow;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BntSave;
        private System.Windows.Forms.Label lblName;
    }
}