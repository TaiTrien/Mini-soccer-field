namespace GUI_MANAGER
{
    partial class frmStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMonth);
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.dtpMonth);
            this.panel1.Controls.Add(this.dtpYear);
            this.panel1.Location = new System.Drawing.Point(206, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 86);
            this.panel1.TabIndex = 0;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(12, 54);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(49, 17);
            this.lbMonth.TabIndex = 5;
            this.lbMonth.Text = "Tháng";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 15);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(37, 17);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Năm";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.Location = new System.Drawing.Point(248, 24);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(101, 47);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "Thống Kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // dtpMonth
            // 
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMonth.Location = new System.Drawing.Point(71, 49);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(139, 22);
            this.dtpMonth.TabIndex = 2;
            // 
            // dtpYear
            // 
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYear.Location = new System.Drawing.Point(71, 10);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(139, 22);
            this.dtpYear.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(707, 17);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(33, 39);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 351);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbSignOut
            // 
            this.lbSignOut.AutoSize = true;
            this.lbSignOut.Location = new System.Drawing.Point(685, 59);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(75, 17);
            this.lbSignOut.TabIndex = 7;
            this.lbSignOut.Text = "Đăng Xuất";
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSignOut);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên quản lí tài chính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbSignOut;
    }
}