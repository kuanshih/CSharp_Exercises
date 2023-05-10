namespace HomeWork
{
    partial class Frm_Loan
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
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Tottal = new System.Windows.Forms.Button();
            this.btn_Month = new System.Windows.Forms.Button();
            this.txt_DnPy = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.lbl_DnPy = new System.Windows.Forms.Label();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Report.Location = new System.Drawing.Point(373, 235);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(131, 41);
            this.btn_Report.TabIndex = 22;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click_1);
            // 
            // btn_Tottal
            // 
            this.btn_Tottal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Tottal.Location = new System.Drawing.Point(226, 235);
            this.btn_Tottal.Name = "btn_Tottal";
            this.btn_Tottal.Size = new System.Drawing.Size(131, 41);
            this.btn_Tottal.TabIndex = 21;
            this.btn_Tottal.Text = "總付款";
            this.btn_Tottal.UseVisualStyleBackColor = true;
            this.btn_Tottal.Click += new System.EventHandler(this.btn_Tottal_Click_1);
            // 
            // btn_Month
            // 
            this.btn_Month.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Month.Location = new System.Drawing.Point(80, 235);
            this.btn_Month.Name = "btn_Month";
            this.btn_Month.Size = new System.Drawing.Size(131, 41);
            this.btn_Month.TabIndex = 20;
            this.btn_Month.Text = "PMT(月付)";
            this.btn_Month.UseVisualStyleBackColor = true;
            this.btn_Month.Click += new System.EventHandler(this.btn_Month_Click);
            // 
            // txt_DnPy
            // 
            this.txt_DnPy.Location = new System.Drawing.Point(239, 188);
            this.txt_DnPy.Name = "txt_DnPy";
            this.txt_DnPy.Size = new System.Drawing.Size(231, 22);
            this.txt_DnPy.TabIndex = 19;
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(239, 153);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(231, 22);
            this.txt_Rate.TabIndex = 18;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(239, 116);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(231, 22);
            this.txt_Year.TabIndex = 17;
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(239, 83);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(231, 22);
            this.txt_Num.TabIndex = 16;
            // 
            // lbl_DnPy
            // 
            this.lbl_DnPy.AutoSize = true;
            this.lbl_DnPy.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_DnPy.Location = new System.Drawing.Point(103, 189);
            this.lbl_DnPy.Name = "lbl_DnPy";
            this.lbl_DnPy.Size = new System.Drawing.Size(72, 24);
            this.lbl_DnPy.TabIndex = 15;
            this.lbl_DnPy.Text = "頭期款:";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Rate.Location = new System.Drawing.Point(103, 155);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(103, 24);
            this.lbl_Rate.TabIndex = 14;
            this.lbl_Rate.Text = "年利率(%):";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Year.Location = new System.Drawing.Point(103, 119);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(86, 24);
            this.lbl_Year.TabIndex = 13;
            this.lbl_Year.Text = "期限(年):";
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Num.Location = new System.Drawing.Point(101, 83);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(91, 24);
            this.lbl_Num.TabIndex = 12;
            this.lbl_Num.Text = "貸款金額:";
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 356);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Tottal);
            this.Controls.Add(this.btn_Month);
            this.Controls.Add(this.txt_DnPy);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.lbl_DnPy);
            this.Controls.Add(this.lbl_Rate);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Num);
            this.Name = "Frm_Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Tottal;
        private System.Windows.Forms.Button btn_Month;
        private System.Windows.Forms.TextBox txt_DnPy;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Label lbl_DnPy;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Num;
    }
}