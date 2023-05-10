namespace HomeWork
{
    partial class Barpos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barpos));
            this.lblDisc = new System.Windows.Forms.Label();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCraditCard = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnWisky = new System.Windows.Forms.Button();
            this.btnJuice = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDisc.Location = new System.Drawing.Point(418, 323);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(93, 19);
            this.lblDisc.TabIndex = 27;
            this.lblDisc.Text = "信用卡享9折";
            // 
            // txtOrderList
            // 
            this.txtOrderList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOrderList.Location = new System.Drawing.Point(541, 118);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ReadOnly = true;
            this.txtOrderList.Size = new System.Drawing.Size(225, 186);
            this.txtOrderList.TabIndex = 26;
            this.txtOrderList.Text = "尚未點餐";
            this.txtOrderList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(669, 310);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 49);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "清除清單";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnCraditCard
            // 
            this.btnCraditCard.Location = new System.Drawing.Point(414, 271);
            this.btnCraditCard.Name = "btnCraditCard";
            this.btnCraditCard.Size = new System.Drawing.Size(97, 49);
            this.btnCraditCard.TabIndex = 24;
            this.btnCraditCard.Text = "信用卡";
            this.btnCraditCard.UseVisualStyleBackColor = true;
            this.btnCraditCard.Click += new System.EventHandler(this.btnCraditCard_Click_1);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Black;
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.Location = new System.Drawing.Point(331, 138);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(160, 22);
            this.txtTotalPrice.TabIndex = 23;
            this.txtTotalPrice.Text = "NT$0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(311, 271);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(97, 49);
            this.btnCash.TabIndex = 22;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click_1);
            // 
            // lblList
            // 
            this.lblList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblList.Location = new System.Drawing.Point(528, 81);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(253, 289);
            this.lblList.TabIndex = 21;
            this.lblList.Text = "購物清單 List:";
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPayment.Location = new System.Drawing.Point(299, 222);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(223, 148);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "付款方式:";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(299, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(223, 118);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "總金額 Total Price:";
            // 
            // lblMenu
            // 
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMenu.Location = new System.Drawing.Point(20, 81);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(262, 289);
            this.lblMenu.TabIndex = 18;
            this.lblMenu.Text = "菜單 Menu:";
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(154, 250);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(97, 90);
            this.btnBeer.TabIndex = 31;
            this.btnBeer.Text = "啤酒 150NT";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click_1);
            // 
            // btnWisky
            // 
            this.btnWisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWisky.BackgroundImage")));
            this.btnWisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWisky.Location = new System.Drawing.Point(51, 250);
            this.btnWisky.Name = "btnWisky";
            this.btnWisky.Size = new System.Drawing.Size(97, 90);
            this.btnWisky.TabIndex = 30;
            this.btnWisky.Text = "威士忌 350NT";
            this.btnWisky.UseVisualStyleBackColor = true;
            this.btnWisky.Click += new System.EventHandler(this.btnWisky_Click_1);
            // 
            // btnJuice
            // 
            this.btnJuice.BackgroundImage = global::HomeWork.Properties.Resources._20221017002369;
            this.btnJuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJuice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJuice.Location = new System.Drawing.Point(154, 138);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(97, 90);
            this.btnJuice.TabIndex = 29;
            this.btnJuice.Text = "果汁 120NT";
            this.btnJuice.UseVisualStyleBackColor = true;
            this.btnJuice.Click += new System.EventHandler(this.btnJuice_Click_1);
            // 
            // btnCola
            // 
            this.btnCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCola.BackgroundImage")));
            this.btnCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCola.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCola.Location = new System.Drawing.Point(51, 138);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(97, 90);
            this.btnCola.TabIndex = 28;
            this.btnCola.Text = "可樂 100NT";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click_1);
            // 
            // Barpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.btnWisky);
            this.Controls.Add(this.btnJuice);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.txtOrderList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCraditCard);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMenu);
            this.Name = "Barpos";
            this.Text = "Barpos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnWisky;
        private System.Windows.Forms.Button btnJuice;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCraditCard;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMenu;
    }
}