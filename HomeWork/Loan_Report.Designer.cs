namespace HomeWork
{
    partial class Loan_Report
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
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMonthPMT = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMonthPMT = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.lblLoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(480, 341);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(91, 35);
            this.btnEmail.TabIndex = 21;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(334, 265);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 20;
            // 
            // txtMonthPMT
            // 
            this.txtMonthPMT.Location = new System.Drawing.Point(334, 220);
            this.txtMonthPMT.Name = "txtMonthPMT";
            this.txtMonthPMT.Size = new System.Drawing.Size(100, 22);
            this.txtMonthPMT.TabIndex = 19;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(334, 169);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(334, 124);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(229, 263);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 24);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "總付款:";
            // 
            // lblMonthPMT
            // 
            this.lblMonthPMT.AutoSize = true;
            this.lblMonthPMT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthPMT.Location = new System.Drawing.Point(229, 218);
            this.lblMonthPMT.Name = "lblMonthPMT";
            this.lblMonthPMT.Size = new System.Drawing.Size(72, 24);
            this.lblMonthPMT.TabIndex = 15;
            this.lblMonthPMT.Text = "月付款:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRate.Location = new System.Drawing.Point(229, 167);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(86, 24);
            this.lblRate.TabIndex = 14;
            this.lblRate.Text = "利率(年):";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(229, 122);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(86, 24);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "期限(年):";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(334, 77);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 22);
            this.txtLoan.TabIndex = 12;
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoan.Location = new System.Drawing.Point(229, 75);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(91, 24);
            this.lblLoan.TabIndex = 11;
            this.lblLoan.Text = "貸款金額:";
            // 
            // Loan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 453);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMonthPMT);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMonthPMT);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblLoan);
            this.Name = "Loan_Report";
            this.Text = "Loan_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtMonthPMT;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMonthPMT;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        internal System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label lblLoan;
    }
}