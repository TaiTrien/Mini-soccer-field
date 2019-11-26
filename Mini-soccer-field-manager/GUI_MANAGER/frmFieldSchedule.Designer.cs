namespace GUI_MANAGER
{
    partial class frmFieldSchedule
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
            this.DGVFieldSchedule = new System.Windows.Forms.DataGridView();
            this.gBInputInfo = new System.Windows.Forms.GroupBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbFieldName = new System.Windows.Forms.Label();
            this.lbReserveDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbReserveTime = new System.Windows.Forms.Label();
            this.btnReserveField = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.nUDTime = new System.Windows.Forms.NumericUpDown();
            this.cbFieldName = new System.Windows.Forms.ComboBox();
            this.dTPReservationDate = new System.Windows.Forms.DateTimePicker();
            this.dTPTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFieldSchedule)).BeginInit();
            this.gBInputInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFieldSchedule
            // 
            this.DGVFieldSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFieldSchedule.Location = new System.Drawing.Point(12, 12);
            this.DGVFieldSchedule.Name = "DGVFieldSchedule";
            this.DGVFieldSchedule.RowTemplate.Height = 24;
            this.DGVFieldSchedule.Size = new System.Drawing.Size(776, 302);
            this.DGVFieldSchedule.TabIndex = 0;
            // 
            // gBInputInfo
            // 
            this.gBInputInfo.Controls.Add(this.dTPTime);
            this.gBInputInfo.Controls.Add(this.dTPReservationDate);
            this.gBInputInfo.Controls.Add(this.cbFieldName);
            this.gBInputInfo.Controls.Add(this.nUDTime);
            this.gBInputInfo.Controls.Add(this.tbCustomerName);
            this.gBInputInfo.Controls.Add(this.lbReserveTime);
            this.gBInputInfo.Controls.Add(this.lbTime);
            this.gBInputInfo.Controls.Add(this.lbReserveDate);
            this.gBInputInfo.Controls.Add(this.lbFieldName);
            this.gBInputInfo.Controls.Add(this.lbCustomerName);
            this.gBInputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInputInfo.Location = new System.Drawing.Point(12, 332);
            this.gBInputInfo.Name = "gBInputInfo";
            this.gBInputInfo.Size = new System.Drawing.Size(776, 213);
            this.gBInputInfo.TabIndex = 1;
            this.gBInputInfo.TabStop = false;
            this.gBInputInfo.Text = "Thông tin khách đặt";
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
            // lbFieldName
            // 
            this.lbFieldName.AutoSize = true;
            this.lbFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFieldName.Location = new System.Drawing.Point(18, 91);
            this.lbFieldName.Name = "lbFieldName";
            this.lbFieldName.Size = new System.Drawing.Size(46, 24);
            this.lbFieldName.TabIndex = 1;
            this.lbFieldName.Text = "Sân";
            // 
            // lbReserveDate
            // 
            this.lbReserveDate.AutoSize = true;
            this.lbReserveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReserveDate.Location = new System.Drawing.Point(380, 40);
            this.lbReserveDate.Name = "lbReserveDate";
            this.lbReserveDate.Size = new System.Drawing.Size(132, 24);
            this.lbReserveDate.TabIndex = 2;
            this.lbReserveDate.Text = "Ngày đặt sân";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(380, 81);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(128, 24);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Thời gian đá";
            // 
            // lbReserveTime
            // 
            this.lbReserveTime.AutoSize = true;
            this.lbReserveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReserveTime.Location = new System.Drawing.Point(18, 138);
            this.lbReserveTime.Name = "lbReserveTime";
            this.lbReserveTime.Size = new System.Drawing.Size(116, 24);
            this.lbReserveTime.TabIndex = 4;
            this.lbReserveTime.Text = "Giờ đặt sân";
            // 
            // btnReserveField
            // 
            this.btnReserveField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveField.Location = new System.Drawing.Point(312, 551);
            this.btnReserveField.Name = "btnReserveField";
            this.btnReserveField.Size = new System.Drawing.Size(179, 52);
            this.btnReserveField.TabIndex = 2;
            this.btnReserveField.Text = "Lưu";
            this.btnReserveField.UseVisualStyleBackColor = true;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.tbCustomerName.Location = new System.Drawing.Point(202, 41);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(142, 27);
            this.tbCustomerName.TabIndex = 5;
            // 
            // nUDTime
            // 
            this.nUDTime.Location = new System.Drawing.Point(565, 78);
            this.nUDTime.Name = "nUDTime";
            this.nUDTime.Size = new System.Drawing.Size(142, 27);
            this.nUDTime.TabIndex = 6;
            this.nUDTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbFieldName
            // 
            this.cbFieldName.FormattingEnabled = true;
            this.cbFieldName.Location = new System.Drawing.Point(202, 87);
            this.cbFieldName.Name = "cbFieldName";
            this.cbFieldName.Size = new System.Drawing.Size(142, 28);
            this.cbFieldName.TabIndex = 3;
            // 
            // dTPReservationDate
            // 
            this.dTPReservationDate.Location = new System.Drawing.Point(565, 37);
            this.dTPReservationDate.Name = "dTPReservationDate";
            this.dTPReservationDate.Size = new System.Drawing.Size(142, 27);
            this.dTPReservationDate.TabIndex = 7;
            // 
            // dTPTime
            // 
            this.dTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPTime.Location = new System.Drawing.Point(202, 139);
            this.dTPTime.Name = "dTPTime";
            this.dTPTime.Size = new System.Drawing.Size(142, 27);
            this.dTPTime.TabIndex = 8;
            // 
            // frmFieldSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.btnReserveField);
            this.Controls.Add(this.gBInputInfo);
            this.Controls.Add(this.DGVFieldSchedule);
            this.Name = "frmFieldSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sân";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFieldSchedule)).EndInit();
            this.gBInputInfo.ResumeLayout(false);
            this.gBInputInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFieldSchedule;
        private System.Windows.Forms.GroupBox gBInputInfo;
        private System.Windows.Forms.DateTimePicker dTPTime;
        private System.Windows.Forms.DateTimePicker dTPReservationDate;
        private System.Windows.Forms.ComboBox cbFieldName;
        private System.Windows.Forms.NumericUpDown nUDTime;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbReserveTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbReserveDate;
        private System.Windows.Forms.Label lbFieldName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Button btnReserveField;
    }
}