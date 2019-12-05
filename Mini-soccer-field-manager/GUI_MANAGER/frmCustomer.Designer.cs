namespace GUI_MANAGER
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.gBInputInfo = new System.Windows.Forms.GroupBox();
            this.tbCusPhone = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tbCusAddr = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.cbCusType = new System.Windows.Forms.ComboBox();
            this.lbCusAddr = new System.Windows.Forms.Label();
            this.lbCusPhone = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbCusType = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.btnSaveCus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Label();
            this.gBInputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBInputInfo
            // 
            this.gBInputInfo.Controls.Add(this.tbCusPhone);
            this.gBInputInfo.Controls.Add(this.rbMale);
            this.gBInputInfo.Controls.Add(this.rbFemale);
            this.gBInputInfo.Controls.Add(this.tbCusAddr);
            this.gBInputInfo.Controls.Add(this.tbCusName);
            this.gBInputInfo.Controls.Add(this.cbCusType);
            this.gBInputInfo.Controls.Add(this.lbCusAddr);
            this.gBInputInfo.Controls.Add(this.lbCusPhone);
            this.gBInputInfo.Controls.Add(this.lbSex);
            this.gBInputInfo.Controls.Add(this.lbCusType);
            this.gBInputInfo.Controls.Add(this.lbCustomerName);
            this.gBInputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInputInfo.Location = new System.Drawing.Point(12, 119);
            this.gBInputInfo.Name = "gBInputInfo";
            this.gBInputInfo.Size = new System.Drawing.Size(776, 213);
            this.gBInputInfo.TabIndex = 2;
            this.gBInputInfo.TabStop = false;
            this.gBInputInfo.Text = "Thông tin khách đặt";
            // 
            // tbCusPhone
            // 
            this.tbCusPhone.Location = new System.Drawing.Point(525, 87);
            this.tbCusPhone.Name = "tbCusPhone";
            this.tbCusPhone.Size = new System.Drawing.Size(170, 27);
            this.tbCusPhone.TabIndex = 15;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(565, 40);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(664, 40);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(53, 24);
            this.rbFemale.TabIndex = 13;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // tbCusAddr
            // 
            this.tbCusAddr.Location = new System.Drawing.Point(202, 137);
            this.tbCusAddr.Name = "tbCusAddr";
            this.tbCusAddr.Size = new System.Drawing.Size(323, 27);
            this.tbCusAddr.TabIndex = 12;
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(202, 37);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(170, 27);
            this.tbCusName.TabIndex = 11;
            // 
            // cbCusType
            // 
            this.cbCusType.FormattingEnabled = true;
            this.cbCusType.Location = new System.Drawing.Point(202, 87);
            this.cbCusType.Name = "cbCusType";
            this.cbCusType.Size = new System.Drawing.Size(142, 28);
            this.cbCusType.TabIndex = 3;
            // 
            // lbCusAddr
            // 
            this.lbCusAddr.AutoSize = true;
            this.lbCusAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusAddr.Location = new System.Drawing.Point(18, 138);
            this.lbCusAddr.Name = "lbCusAddr";
            this.lbCusAddr.Size = new System.Drawing.Size(74, 24);
            this.lbCusAddr.TabIndex = 4;
            this.lbCusAddr.Text = "Địa chỉ";
            // 
            // lbCusPhone
            // 
            this.lbCusPhone.AutoSize = true;
            this.lbCusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusPhone.Location = new System.Drawing.Point(427, 91);
            this.lbCusPhone.Name = "lbCusPhone";
            this.lbCusPhone.Size = new System.Drawing.Size(68, 24);
            this.lbCusPhone.TabIndex = 3;
            this.lbCusPhone.Text = "Số ĐT";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(427, 40);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(87, 24);
            this.lbSex.TabIndex = 2;
            this.lbSex.Text = "Giới tính";
            // 
            // lbCusType
            // 
            this.lbCusType.AutoSize = true;
            this.lbCusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusType.Location = new System.Drawing.Point(18, 91);
            this.lbCusType.Name = "lbCusType";
            this.lbCusType.Size = new System.Drawing.Size(83, 24);
            this.lbCusType.TabIndex = 1;
            this.lbCusType.Text = "Loại KH";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(18, 40);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(162, 24);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Tên khách hàng";
            // 
            // btnSaveCus
            // 
            this.btnSaveCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCus.Location = new System.Drawing.Point(310, 353);
            this.btnSaveCus.Name = "btnSaveCus";
            this.btnSaveCus.Size = new System.Drawing.Size(175, 45);
            this.btnSaveCus.TabIndex = 3;
            this.btnSaveCus.Text = "Thêm";
            this.btnSaveCus.UseVisualStyleBackColor = true;
            this.btnSaveCus.Click += new System.EventHandler(this.btnSaveCus_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(34, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 30);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(31, 386);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(60, 17);
            this.lbBack.TabIndex = 20;
            this.lbBack.Text = "Quay lại";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnSaveCus);
            this.Controls.Add(this.gBInputInfo);
            this.Name = "frmCustomer";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmThemKH_Load);
            this.gBInputInfo.ResumeLayout(false);
            this.gBInputInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInputInfo;
        private System.Windows.Forms.ComboBox cbCusType;
        private System.Windows.Forms.Label lbCusAddr;
        private System.Windows.Forms.Label lbCusPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbCusType;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusPhone;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox tbCusAddr;
        private System.Windows.Forms.Button btnSaveCus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbBack;
    }
}