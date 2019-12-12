namespace GUI_MANAGER
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.gbDrinks = new System.Windows.Forms.GroupBox();
            this.nUDRevieDrink = new System.Windows.Forms.NumericUpDown();
            this.nUDWaterDrink = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRevieDrink = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbTotalTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.tbDiscountMoney = new System.Windows.Forms.TextBox();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRevieDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWaterDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(149, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(169, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Thanh toán";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(18, 91);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(113, 20);
            this.lbCustomer.TabIndex = 1;
            this.lbCustomer.Text = "Khách hàng:";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTime.Location = new System.Drawing.Point(18, 131);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(160, 20);
            this.lbTotalTime.TabIndex = 2;
            this.lbTotalTime.Text = "Tổng thời gian đá:";
            // 
            // gbDrinks
            // 
            this.gbDrinks.Controls.Add(this.nUDRevieDrink);
            this.gbDrinks.Controls.Add(this.nUDWaterDrink);
            this.gbDrinks.Controls.Add(this.label1);
            this.gbDrinks.Controls.Add(this.lbRevieDrink);
            this.gbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinks.Location = new System.Drawing.Point(12, 180);
            this.gbDrinks.Name = "gbDrinks";
            this.gbDrinks.Size = new System.Drawing.Size(428, 134);
            this.gbDrinks.TabIndex = 3;
            this.gbDrinks.TabStop = false;
            this.gbDrinks.Text = "Nước uống";
            // 
            // nUDRevieDrink
            // 
            this.nUDRevieDrink.Location = new System.Drawing.Point(211, 89);
            this.nUDRevieDrink.Name = "nUDRevieDrink";
            this.nUDRevieDrink.Size = new System.Drawing.Size(120, 27);
            this.nUDRevieDrink.TabIndex = 7;
            this.nUDRevieDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nUDWaterDrink
            // 
            this.nUDWaterDrink.Location = new System.Drawing.Point(211, 44);
            this.nUDWaterDrink.Name = "nUDWaterDrink";
            this.nUDWaterDrink.Size = new System.Drawing.Size(120, 27);
            this.nUDWaterDrink.TabIndex = 6;
            this.nUDWaterDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nước suối";
            // 
            // lbRevieDrink
            // 
            this.lbRevieDrink.AutoSize = true;
            this.lbRevieDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevieDrink.Location = new System.Drawing.Point(6, 95);
            this.lbRevieDrink.Name = "lbRevieDrink";
            this.lbRevieDrink.Size = new System.Drawing.Size(105, 20);
            this.lbRevieDrink.TabIndex = 5;
            this.lbRevieDrink.Text = "Nước Revie";
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(26, 495);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(414, 68);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(223, 91);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(217, 27);
            this.tbCustomer.TabIndex = 7;
            // 
            // tbTotalTime
            // 
            this.tbTotalTime.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTime.Location = new System.Drawing.Point(223, 131);
            this.tbTotalTime.Name = "tbTotalTime";
            this.tbTotalTime.Size = new System.Drawing.Size(217, 27);
            this.tbTotalTime.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 2);
            this.label2.TabIndex = 9;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(16, 429);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(200, 32);
            this.lbTotalMoney.TabIndex = 11;
            this.lbTotalMoney.Text = "Tổng số tiền: ";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(22, 336);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(174, 20);
            this.lbDiscount.TabIndex = 12;
            this.lbDiscount.Text = "Số tiền khuyến mãi:";
            // 
            // tbDiscountMoney
            // 
            this.tbDiscountMoney.BackColor = System.Drawing.SystemColors.Control;
            this.tbDiscountMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscountMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountMoney.Location = new System.Drawing.Point(223, 336);
            this.tbDiscountMoney.Name = "tbDiscountMoney";
            this.tbDiscountMoney.Size = new System.Drawing.Size(217, 27);
            this.tbDiscountMoney.TabIndex = 13;
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoney.Location = new System.Drawing.Point(219, 429);
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(221, 27);
            this.tbTotalMoney.TabIndex = 14;
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(8, 45);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(60, 17);
            this.lbBack.TabIndex = 15;
            this.lbBack.Text = "Quay lại";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 30);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 575);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.tbDiscountMoney);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotalTime);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbDrinks);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.gbDrinks.ResumeLayout(false);
            this.gbDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRevieDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWaterDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.GroupBox gbDrinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRevieDrink;
        private System.Windows.Forms.NumericUpDown nUDRevieDrink;
        private System.Windows.Forms.NumericUpDown nUDWaterDrink;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbTotalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox tbDiscountMoney;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Button btnBack;
    }
}