﻿namespace GUI_MANAGER
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
            this.tbTotalTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.tbDiscountMoney = new System.Windows.Forms.TextBox();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbParkingPrice = new System.Windows.Forms.TextBox();
            this.lbParkingPrice = new System.Windows.Forms.Label();
            this.nUDParkingCars = new System.Windows.Forms.NumericUpDown();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.cbCusPhone = new System.Windows.Forms.ComboBox();
            this.gbDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRevieDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWaterDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingCars)).BeginInit();
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
            this.lbCustomer.Location = new System.Drawing.Point(18, 121);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(155, 20);
            this.lbCustomer.TabIndex = 1;
            this.lbCustomer.Text = "SĐT Khách hàng:";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTime.Location = new System.Drawing.Point(18, 168);
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
            this.gbDrinks.Location = new System.Drawing.Point(12, 201);
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
            this.nUDRevieDrink.ValueChanged += new System.EventHandler(this.nUDRevieDrink_ValueChanged);
            // 
            // nUDWaterDrink
            // 
            this.nUDWaterDrink.Location = new System.Drawing.Point(211, 44);
            this.nUDWaterDrink.Name = "nUDWaterDrink";
            this.nUDWaterDrink.Size = new System.Drawing.Size(120, 27);
            this.nUDWaterDrink.TabIndex = 6;
            this.nUDWaterDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDWaterDrink.ValueChanged += new System.EventHandler(this.nUDWaterDrink_ValueChanged);
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
            this.lbRevieDrink.Size = new System.Drawing.Size(114, 20);
            this.lbRevieDrink.TabIndex = 5;
            this.lbRevieDrink.Text = "Nước Revive";
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(26, 516);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(414, 68);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tbTotalTime
            // 
            this.tbTotalTime.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTime.Location = new System.Drawing.Point(223, 168);
            this.tbTotalTime.Name = "tbTotalTime";
            this.tbTotalTime.Size = new System.Drawing.Size(217, 27);
            this.tbTotalTime.TabIndex = 8;
            this.tbTotalTime.Text = "0";
            this.tbTotalTime.TextChanged += new System.EventHandler(this.tbTotalTime_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 2);
            this.label2.TabIndex = 9;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(16, 450);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(200, 32);
            this.lbTotalMoney.TabIndex = 11;
            this.lbTotalMoney.Text = "Tổng số tiền: ";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(22, 386);
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
            this.tbDiscountMoney.Location = new System.Drawing.Point(223, 386);
            this.tbDiscountMoney.Name = "tbDiscountMoney";
            this.tbDiscountMoney.Size = new System.Drawing.Size(217, 27);
            this.tbDiscountMoney.TabIndex = 13;
            this.tbDiscountMoney.Text = "0";
            this.tbDiscountMoney.TextChanged += new System.EventHandler(this.tbDiscountMoney_TextChanged);
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoney.Location = new System.Drawing.Point(219, 450);
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
            // tbParkingPrice
            // 
            this.tbParkingPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tbParkingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParkingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParkingPrice.Location = new System.Drawing.Point(223, 341);
            this.tbParkingPrice.Name = "tbParkingPrice";
            this.tbParkingPrice.Size = new System.Drawing.Size(137, 27);
            this.tbParkingPrice.TabIndex = 18;
            // 
            // lbParkingPrice
            // 
            this.lbParkingPrice.AutoSize = true;
            this.lbParkingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParkingPrice.Location = new System.Drawing.Point(22, 341);
            this.lbParkingPrice.Name = "lbParkingPrice";
            this.lbParkingPrice.Size = new System.Drawing.Size(70, 20);
            this.lbParkingPrice.TabIndex = 17;
            this.lbParkingPrice.Text = "Tiền xe";
            // 
            // nUDParkingCars
            // 
            this.nUDParkingCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDParkingCars.Location = new System.Drawing.Point(367, 341);
            this.nUDParkingCars.Name = "nUDParkingCars";
            this.nUDParkingCars.Size = new System.Drawing.Size(73, 28);
            this.nUDParkingCars.TabIndex = 19;
            this.nUDParkingCars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDParkingCars.ValueChanged += new System.EventHandler(this.nUDParkingCars_ValueChanged);
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(18, 84);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(141, 20);
            this.lbCustomerName.TabIndex = 21;
            this.lbCustomerName.Text = "Tên khách hàng";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(223, 81);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(217, 22);
            this.tbCustomerName.TabIndex = 22;
            // 
            // cbCusPhone
            // 
            this.cbCusPhone.FormattingEnabled = true;
            this.cbCusPhone.Location = new System.Drawing.Point(223, 121);
            this.cbCusPhone.Name = "cbCusPhone";
            this.cbCusPhone.Size = new System.Drawing.Size(217, 24);
            this.cbCusPhone.TabIndex = 24;
            this.cbCusPhone.SelectedIndexChanged += new System.EventHandler(this.cbCusPhone_SelectedIndexChanged);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 596);
            this.Controls.Add(this.cbCusPhone);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.nUDParkingCars);
            this.Controls.Add(this.tbParkingPrice);
            this.Controls.Add(this.lbParkingPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.tbDiscountMoney);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotalTime);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbDrinks);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.gbDrinks.ResumeLayout(false);
            this.gbDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRevieDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWaterDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingCars)).EndInit();
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
        private System.Windows.Forms.TextBox tbTotalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox tbDiscountMoney;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbParkingPrice;
        private System.Windows.Forms.Label lbParkingPrice;
        private System.Windows.Forms.NumericUpDown nUDParkingCars;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.ComboBox cbCusPhone;
    }
}