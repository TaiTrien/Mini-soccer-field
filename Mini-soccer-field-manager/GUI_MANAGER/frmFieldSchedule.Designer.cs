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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFieldSchedule));
            this.DGVFieldSchedule = new System.Windows.Forms.DataGridView();
            this.btnReserveField = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbFieldName = new System.Windows.Forms.Label();
            this.lbReserveDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbReserveTime = new System.Windows.Forms.Label();
            this.cbFieldName = new System.Windows.Forms.ComboBox();
            this.dTPReservationDate = new System.Windows.Forms.DateTimePicker();
            this.dTPTime = new System.Windows.Forms.DateTimePicker();
            this.cbCusPhone = new System.Windows.Forms.ComboBox();
            this.gBInputInfo = new System.Windows.Forms.GroupBox();
            this.dTPlength = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripCancel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFieldSchedule)).BeginInit();
            this.gBInputInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFieldSchedule
            // 
            this.DGVFieldSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFieldSchedule.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVFieldSchedule.Location = new System.Drawing.Point(12, 12);
            this.DGVFieldSchedule.Name = "DGVFieldSchedule";
            this.DGVFieldSchedule.RowHeadersWidth = 51;
            this.DGVFieldSchedule.RowTemplate.Height = 24;
            this.DGVFieldSchedule.Size = new System.Drawing.Size(776, 302);
            this.DGVFieldSchedule.TabIndex = 0;
            // 
            // btnReserveField
            // 
            this.btnReserveField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveField.Location = new System.Drawing.Point(196, 549);
            this.btnReserveField.Name = "btnReserveField";
            this.btnReserveField.Size = new System.Drawing.Size(179, 52);
            this.btnReserveField.TabIndex = 2;
            this.btnReserveField.Text = "Lưu";
            this.btnReserveField.UseVisualStyleBackColor = true;
            this.btnReserveField.Click += new System.EventHandler(this.btnReserveField_Click);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(12, 584);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(60, 17);
            this.lbBack.TabIndex = 18;
            this.lbBack.Text = "Quay lại";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(15, 551);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(460, 551);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 52);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(18, 40);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(177, 24);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "Số Điện Thoại KH";
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
            this.lbReserveDate.Location = new System.Drawing.Point(427, 40);
            this.lbReserveDate.Name = "lbReserveDate";
            this.lbReserveDate.Size = new System.Drawing.Size(132, 24);
            this.lbReserveDate.TabIndex = 2;
            this.lbReserveDate.Text = "Ngày đặt sân";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(427, 87);
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
            this.dTPReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPReservationDate.Location = new System.Drawing.Point(565, 37);
            this.dTPReservationDate.Name = "dTPReservationDate";
            this.dTPReservationDate.Size = new System.Drawing.Size(181, 27);
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
            // cbCusPhone
            // 
            this.cbCusPhone.FormattingEnabled = true;
            this.cbCusPhone.Location = new System.Drawing.Point(202, 39);
            this.cbCusPhone.Name = "cbCusPhone";
            this.cbCusPhone.Size = new System.Drawing.Size(161, 28);
            this.cbCusPhone.TabIndex = 9;
            this.cbCusPhone.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gBInputInfo
            // 
            this.gBInputInfo.Controls.Add(this.dTPlength);
            this.gBInputInfo.Controls.Add(this.button1);
            this.gBInputInfo.Controls.Add(this.cbCusPhone);
            this.gBInputInfo.Controls.Add(this.dTPTime);
            this.gBInputInfo.Controls.Add(this.dTPReservationDate);
            this.gBInputInfo.Controls.Add(this.cbFieldName);
            this.gBInputInfo.Controls.Add(this.lbReserveTime);
            this.gBInputInfo.Controls.Add(this.lbTime);
            this.gBInputInfo.Controls.Add(this.lbReserveDate);
            this.gBInputInfo.Controls.Add(this.lbFieldName);
            this.gBInputInfo.Controls.Add(this.lbCustomer);
            this.gBInputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInputInfo.Location = new System.Drawing.Point(12, 332);
            this.gBInputInfo.Name = "gBInputInfo";
            this.gBInputInfo.Size = new System.Drawing.Size(776, 213);
            this.gBInputInfo.TabIndex = 1;
            this.gBInputInfo.TabStop = false;
            this.gBInputInfo.Text = "Thông tin khách đặt";
            // 
            // dTPlength
            // 
            this.dTPlength.CustomFormat = "HH:mm";
            this.dTPlength.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPlength.Location = new System.Drawing.Point(565, 84);
            this.dTPlength.Name = "dTPlength";
            this.dTPlength.Size = new System.Drawing.Size(142, 27);
            this.dTPlength.TabIndex = 11;
            this.dTPlength.Value = new System.DateTime(2019, 12, 4, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCancel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 28);
            // 
            // toolStripCancel
            // 
            this.toolStripCancel.Name = "toolStripCancel";
            this.toolStripCancel.Size = new System.Drawing.Size(132, 24);
            this.toolStripCancel.Text = "Hủy Sân";
            this.toolStripCancel.Click += new System.EventHandler(this.HuySanToolStripMenuItem_Click);
            // 
            // frmFieldSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnReserveField);
            this.Controls.Add(this.gBInputInfo);
            this.Controls.Add(this.DGVFieldSchedule);
            this.Name = "frmFieldSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sân";
            this.Load += new System.EventHandler(this.frmFieldSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFieldSchedule)).EndInit();
            this.gBInputInfo.ResumeLayout(false);
            this.gBInputInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFieldSchedule;
        private System.Windows.Forms.Button btnReserveField;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbFieldName;
        private System.Windows.Forms.Label lbReserveDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbReserveTime;
        private System.Windows.Forms.ComboBox cbFieldName;
        private System.Windows.Forms.DateTimePicker dTPReservationDate;
        private System.Windows.Forms.DateTimePicker dTPTime;
        private System.Windows.Forms.ComboBox cbCusPhone;
        private System.Windows.Forms.GroupBox gBInputInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCancel;
        private System.Windows.Forms.DateTimePicker dTPlength;
    }
}