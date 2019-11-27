namespace GUI_MANAGER
{
    partial class frmRingTheBell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRingTheBell));
            this.btnField1 = new System.Windows.Forms.Button();
            this.btnField2 = new System.Windows.Forms.Button();
            this.lbField1 = new System.Windows.Forms.Label();
            this.lbField2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTimerField1 = new System.Windows.Forms.TextBox();
            this.tbTimerField2 = new System.Windows.Forms.TextBox();
            this.lbFree = new System.Windows.Forms.Label();
            this.lbNotFree = new System.Windows.Forms.Label();
            this.lbFreeTxt = new System.Windows.Forms.Label();
            this.lbNotFreeTxt = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnField1
            // 
            this.btnField1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnField1.BackgroundImage")));
            this.btnField1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnField1.Location = new System.Drawing.Point(75, 131);
            this.btnField1.Name = "btnField1";
            this.btnField1.Size = new System.Drawing.Size(334, 415);
            this.btnField1.TabIndex = 0;
            this.btnField1.UseVisualStyleBackColor = true;
            // 
            // btnField2
            // 
            this.btnField2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnField2.BackgroundImage")));
            this.btnField2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnField2.Location = new System.Drawing.Point(497, 131);
            this.btnField2.Name = "btnField2";
            this.btnField2.Size = new System.Drawing.Size(334, 415);
            this.btnField2.TabIndex = 1;
            this.btnField2.UseVisualStyleBackColor = true;
            // 
            // lbField1
            // 
            this.lbField1.AutoSize = true;
            this.lbField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField1.Location = new System.Drawing.Point(190, 549);
            this.lbField1.Name = "lbField1";
            this.lbField1.Size = new System.Drawing.Size(74, 29);
            this.lbField1.TabIndex = 2;
            this.lbField1.Text = "Sân 1";
            // 
            // lbField2
            // 
            this.lbField2.AutoSize = true;
            this.lbField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField2.Location = new System.Drawing.Point(630, 549);
            this.lbField2.Name = "lbField2";
            this.lbField2.Size = new System.Drawing.Size(74, 29);
            this.lbField2.TabIndex = 3;
            this.lbField2.Text = "Sân 2";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(335, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(225, 38);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Tình trạng sân";
            // 
            // tbTimerField1
            // 
            this.tbTimerField1.BackColor = System.Drawing.SystemColors.Control;
            this.tbTimerField1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimerField1.Enabled = false;
            this.tbTimerField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimerField1.Location = new System.Drawing.Point(195, 98);
            this.tbTimerField1.Name = "tbTimerField1";
            this.tbTimerField1.ReadOnly = true;
            this.tbTimerField1.Size = new System.Drawing.Size(100, 27);
            this.tbTimerField1.TabIndex = 5;
            this.tbTimerField1.Text = "00:00:00";
            this.tbTimerField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimerField2
            // 
            this.tbTimerField2.BackColor = System.Drawing.SystemColors.Control;
            this.tbTimerField2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimerField2.Enabled = false;
            this.tbTimerField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimerField2.Location = new System.Drawing.Point(616, 98);
            this.tbTimerField2.Name = "tbTimerField2";
            this.tbTimerField2.ReadOnly = true;
            this.tbTimerField2.Size = new System.Drawing.Size(100, 27);
            this.tbTimerField2.TabIndex = 6;
            this.tbTimerField2.Text = "00:00:00";
            this.tbTimerField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFree
            // 
            this.lbFree.AutoSize = true;
            this.lbFree.BackColor = System.Drawing.Color.Red;
            this.lbFree.Location = new System.Drawing.Point(24, 40);
            this.lbFree.Name = "lbFree";
            this.lbFree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFree.Size = new System.Drawing.Size(12, 17);
            this.lbFree.TabIndex = 7;
            this.lbFree.Text = " ";
            // 
            // lbNotFree
            // 
            this.lbNotFree.AutoSize = true;
            this.lbNotFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbNotFree.Location = new System.Drawing.Point(117, 40);
            this.lbNotFree.Name = "lbNotFree";
            this.lbNotFree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNotFree.Size = new System.Drawing.Size(12, 17);
            this.lbNotFree.TabIndex = 8;
            this.lbNotFree.Text = " ";
            // 
            // lbFreeTxt
            // 
            this.lbFreeTxt.AutoSize = true;
            this.lbFreeTxt.Location = new System.Drawing.Point(135, 40);
            this.lbFreeTxt.Name = "lbFreeTxt";
            this.lbFreeTxt.Size = new System.Drawing.Size(46, 17);
            this.lbFreeTxt.TabIndex = 9;
            this.lbFreeTxt.Text = "Trống";
            // 
            // lbNotFreeTxt
            // 
            this.lbNotFreeTxt.AutoSize = true;
            this.lbNotFreeTxt.Location = new System.Drawing.Point(42, 40);
            this.lbNotFreeTxt.Name = "lbNotFreeTxt";
            this.lbNotFreeTxt.Size = new System.Drawing.Size(62, 17);
            this.lbNotFreeTxt.TabIndex = 10;
            this.lbNotFreeTxt.Text = "Đang đá";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(850, 53);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(60, 17);
            this.lbBack.TabIndex = 11;
            this.lbBack.Text = "Quay lại";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(859, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmRingTheBell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 586);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbNotFreeTxt);
            this.Controls.Add(this.lbFreeTxt);
            this.Controls.Add(this.lbNotFree);
            this.Controls.Add(this.lbFree);
            this.Controls.Add(this.tbTimerField2);
            this.Controls.Add(this.tbTimerField1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbField2);
            this.Controls.Add(this.lbField1);
            this.Controls.Add(this.btnField2);
            this.Controls.Add(this.btnField1);
            this.Name = "frmRingTheBell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rung chuông";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnField1;
        private System.Windows.Forms.Button btnField2;
        private System.Windows.Forms.Label lbField1;
        private System.Windows.Forms.Label lbField2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbTimerField1;
        private System.Windows.Forms.TextBox tbTimerField2;
        private System.Windows.Forms.Label lbFree;
        private System.Windows.Forms.Label lbNotFree;
        private System.Windows.Forms.Label lbFreeTxt;
        private System.Windows.Forms.Label lbNotFreeTxt;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Button btnBack;
    }
}