namespace GUI_MANAGER
{
    partial class frmFacilitiesCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacilitiesCheck));
            this.lbFacilities = new System.Windows.Forms.Label();
            this.cbFacilities = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFacilities
            // 
            this.lbFacilities.AutoSize = true;
            this.lbFacilities.Location = new System.Drawing.Point(13, 32);
            this.lbFacilities.Name = "lbFacilities";
            this.lbFacilities.Size = new System.Drawing.Size(98, 17);
            this.lbFacilities.TabIndex = 0;
            this.lbFacilities.Text = "Cơ sở vật chất";
            // 
            // cbFacilities
            // 
            this.cbFacilities.FormattingEnabled = true;
            this.cbFacilities.Location = new System.Drawing.Point(117, 29);
            this.cbFacilities.Name = "cbFacilities";
            this.cbFacilities.Size = new System.Drawing.Size(175, 24);
            this.cbFacilities.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(328, 22);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 34);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFacilities);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.cbFacilities);
            this.panel1.Location = new System.Drawing.Point(50, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 77);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(4, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 351);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbUpdate);
            this.panel3.Controls.Add(this.lbSignOut);
            this.panel3.Controls.Add(this.btnSignOut);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(546, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 77);
            this.panel3.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(26, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 39);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lbSignOut
            // 
            this.lbSignOut.AutoSize = true;
            this.lbSignOut.Location = new System.Drawing.Point(122, 52);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(75, 17);
            this.lbSignOut.TabIndex = 9;
            this.lbSignOut.Text = "Đăng Xuất";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(145, 10);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(33, 39);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(13, 52);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(65, 17);
            this.lbUpdate.TabIndex = 10;
            this.lbUpdate.Text = "Cập nhật";
            this.lbUpdate.Click += new System.EventHandler(this.LbUpdate_Click);
            // 
            // frmFacilitiesCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFacilitiesCheck";
            this.Text = "Nhân viên quản lí cơ sở vật chất";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFacilities;
        private System.Windows.Forms.ComboBox cbFacilities;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbSignOut;
        private System.Windows.Forms.Button btnSignOut;
    }
}