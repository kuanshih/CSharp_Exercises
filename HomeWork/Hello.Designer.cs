namespace HomeWork
{
    partial class Hello
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
            this.txt_starSign = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_EngName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Hi = new System.Windows.Forms.Button();
            this.lbl_StarSign = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_EngName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_starSign
            // 
            this.txt_starSign.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_starSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_starSign.Location = new System.Drawing.Point(276, 222);
            this.txt_starSign.Name = "txt_starSign";
            this.txt_starSign.Size = new System.Drawing.Size(120, 22);
            this.txt_starSign.TabIndex = 19;
            this.txt_starSign.TextChanged += new System.EventHandler(this.txt_starSign_TextChanged);
            // 
            // txt_Sex
            // 
            this.txt_Sex.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Sex.Location = new System.Drawing.Point(277, 181);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(120, 22);
            this.txt_Sex.TabIndex = 18;
            this.txt_Sex.TextChanged += new System.EventHandler(this.txt_Sex_TextChanged);
            // 
            // txt_EngName
            // 
            this.txt_EngName.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_EngName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EngName.Location = new System.Drawing.Point(277, 140);
            this.txt_EngName.Name = "txt_EngName";
            this.txt_EngName.Size = new System.Drawing.Size(120, 22);
            this.txt_EngName.TabIndex = 17;
            this.txt_EngName.TextChanged += new System.EventHandler(this.txt_EngName_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Location = new System.Drawing.Point(277, 96);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(120, 22);
            this.txt_Name.TabIndex = 16;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // btn_Hi
            // 
            this.btn_Hi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Hi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hi.Location = new System.Drawing.Point(276, 314);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(126, 51);
            this.btn_Hi.TabIndex = 15;
            this.btn_Hi.Text = "Say Hi";
            this.btn_Hi.UseVisualStyleBackColor = true;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Hi_Click);
            // 
            // lbl_StarSign
            // 
            this.lbl_StarSign.AutoSize = true;
            this.lbl_StarSign.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StarSign.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_StarSign.ForeColor = System.Drawing.Color.Snow;
            this.lbl_StarSign.Location = new System.Drawing.Point(114, 222);
            this.lbl_StarSign.Name = "lbl_StarSign";
            this.lbl_StarSign.Size = new System.Drawing.Size(58, 24);
            this.lbl_StarSign.TabIndex = 14;
            this.lbl_StarSign.Text = "星座: ";
            this.lbl_StarSign.Click += new System.EventHandler(this.lbl_StarSign_Click);
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Sex.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Sex.Location = new System.Drawing.Point(114, 181);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(58, 24);
            this.lbl_Sex.TabIndex = 13;
            this.lbl_Sex.Text = "性別: ";
            this.lbl_Sex.Click += new System.EventHandler(this.lbl_Sex_Click);
            // 
            // lbl_EngName
            // 
            this.lbl_EngName.AutoSize = true;
            this.lbl_EngName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EngName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EngName.ForeColor = System.Drawing.Color.Snow;
            this.lbl_EngName.Location = new System.Drawing.Point(114, 140);
            this.lbl_EngName.Name = "lbl_EngName";
            this.lbl_EngName.Size = new System.Drawing.Size(147, 24);
            this.lbl_EngName.TabIndex = 12;
            this.lbl_EngName.Text = "English Name: ";
            this.lbl_EngName.Click += new System.EventHandler(this.lbl_EngName_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Name.Location = new System.Drawing.Point(114, 96);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(58, 24);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "姓名: ";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // btn_Hello
            // 
            this.btn_Hello.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Hello.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(113, 314);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(126, 51);
            this.btn_Hello.TabIndex = 10;
            this.btn_Hello.Text = "Say Hello";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeWork.Properties.Resources.iu_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 479);
            this.Controls.Add(this.txt_starSign);
            this.Controls.Add(this.txt_Sex);
            this.Controls.Add(this.txt_EngName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Hi);
            this.Controls.Add(this.lbl_StarSign);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.lbl_EngName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Hello);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_starSign;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_EngName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Hi;
        private System.Windows.Forms.Label lbl_StarSign;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_EngName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Hello;
    }
}