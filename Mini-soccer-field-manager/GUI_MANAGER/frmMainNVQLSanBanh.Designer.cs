namespace GUI_MANAGER
{
    partial class frmMainNVQLSanBanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainNVQLSanBanh));
            this.btnFieldSchedule = new System.Windows.Forms.Button();
            this.btnRingTheBell = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.Label();
            this.lbFieldSchedule = new System.Windows.Forms.Label();
            this.lbRingTheBell = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.lbImportDrinks = new System.Windows.Forms.Label();
            this.btnImportDrinks = new System.Windows.Forms.Button();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFieldSchedule
            // 
            this.btnFieldSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.btnFieldSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFieldSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnFieldSchedule.Image")));
            this.btnFieldSchedule.Location = new System.Drawing.Point(40, 94);
            this.btnFieldSchedule.Name = "btnFieldSchedule";
            this.btnFieldSchedule.Size = new System.Drawing.Size(203, 171);
            this.btnFieldSchedule.TabIndex = 0;
            this.btnFieldSchedule.UseVisualStyleBackColor = false;
            this.btnFieldSchedule.Click += new System.EventHandler(this.btnFieldSchedule_Click);
            // 
            // btnRingTheBell
            // 
            this.btnRingTheBell.Image = ((System.Drawing.Image)(resources.GetObject("btnRingTheBell.Image")));
            this.btnRingTheBell.Location = new System.Drawing.Point(365, 94);
            this.btnRingTheBell.Name = "btnRingTheBell";
            this.btnRingTheBell.Size = new System.Drawing.Size(203, 171);
            this.btnRingTheBell.TabIndex = 1;
            this.btnRingTheBell.UseVisualStyleBackColor = true;
            this.btnRingTheBell.Click += new System.EventHandler(this.btnRingTheBell_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Image = ((System.Drawing.Image)(resources.GetObject("btnPrice.Image")));
            this.btnPrice.Location = new System.Drawing.Point(365, 328);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(203, 171);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(185, 30);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(246, 32);
            this.lbMain.TabIndex = 3;
            this.lbMain.Text = "Quản lí sân banh";
            // 
            // lbFieldSchedule
            // 
            this.lbFieldSchedule.AutoSize = true;
            this.lbFieldSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFieldSchedule.Location = new System.Drawing.Point(74, 278);
            this.lbFieldSchedule.Name = "lbFieldSchedule";
            this.lbFieldSchedule.Size = new System.Drawing.Size(121, 32);
            this.lbFieldSchedule.TabIndex = 4;
            this.lbFieldSchedule.Text = "Lịch sân";
            // 
            // lbRingTheBell
            // 
            this.lbRingTheBell.AutoSize = true;
            this.lbRingTheBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRingTheBell.Location = new System.Drawing.Point(379, 278);
            this.lbRingTheBell.Name = "lbRingTheBell";
            this.lbRingTheBell.Size = new System.Drawing.Size(174, 32);
            this.lbRingTheBell.TabIndex = 5;
            this.lbRingTheBell.Text = "Bấm chuông";
            // 
            // lbPay
            // 
            this.lbPay.AutoSize = true;
            this.lbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.Location = new System.Drawing.Point(397, 512);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(128, 32);
            this.lbPay.TabIndex = 6;
            this.lbPay.Text = "Bảng giá";
            // 
            // lbImportDrinks
            // 
            this.lbImportDrinks.AutoSize = true;
            this.lbImportDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportDrinks.Location = new System.Drawing.Point(63, 512);
            this.lbImportDrinks.Name = "lbImportDrinks";
            this.lbImportDrinks.Size = new System.Drawing.Size(152, 32);
            this.lbImportDrinks.TabIndex = 8;
            this.lbImportDrinks.Text = "Nhập nước";
            // 
            // btnImportDrinks
            // 
            this.btnImportDrinks.Image = ((System.Drawing.Image)(resources.GetObject("btnImportDrinks.Image")));
            this.btnImportDrinks.Location = new System.Drawing.Point(40, 328);
            this.btnImportDrinks.Name = "btnImportDrinks";
            this.btnImportDrinks.Size = new System.Drawing.Size(203, 171);
            this.btnImportDrinks.TabIndex = 7;
            this.btnImportDrinks.UseVisualStyleBackColor = true;
            this.btnImportDrinks.Click += new System.EventHandler(this.btnImportDrinks_Click);
            // 
            // lbSignOut
            // 
            this.lbSignOut.AutoSize = true;
            this.lbSignOut.Location = new System.Drawing.Point(529, 54);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(75, 17);
            this.lbSignOut.TabIndex = 11;
            this.lbSignOut.Text = "Đăng Xuất";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(552, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(33, 39);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // frmMainNVQLSanBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 562);
            this.Controls.Add(this.lbSignOut);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lbImportDrinks);
            this.Controls.Add(this.btnImportDrinks);
            this.Controls.Add(this.lbPay);
            this.Controls.Add(this.lbRingTheBell);
            this.Controls.Add(this.lbFieldSchedule);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnRingTheBell);
            this.Controls.Add(this.btnFieldSchedule);
            this.Name = "frmMainNVQLSanBanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính ";
            this.Load += new System.EventHandler(this.FrmMainNVQLSanBanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFieldSchedule;
        private System.Windows.Forms.Button btnRingTheBell;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label lbFieldSchedule;
        private System.Windows.Forms.Label lbRingTheBell;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label lbImportDrinks;
        private System.Windows.Forms.Button btnImportDrinks;
        private System.Windows.Forms.Label lbSignOut;
        private System.Windows.Forms.Button btnSignOut;
    }
}