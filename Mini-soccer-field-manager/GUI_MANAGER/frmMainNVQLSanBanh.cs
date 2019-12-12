using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_MANAGER
{
    public partial class frmMainNVQLSanBanh : Form
    {
        public frmMainNVQLSanBanh()
        {
            InitializeComponent();
        }

        private void btnFieldSchedule_Click(object sender, EventArgs e)
        {
            frmFieldSchedule frmFieldSchedule = new frmFieldSchedule();
            frmFieldSchedule.Show();
        }

        private void btnRingTheBell_Click(object sender, EventArgs e)
        {
            frmRingTheBell frmRing = new frmRingTheBell();
            frmRing.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.Show();
        }

        private void btnImportDrinks_Click(object sender, EventArgs e)
        {
            frmImportDrinks frmImportDrinks = new frmImportDrinks();
            frmImportDrinks.Show();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            String message = "Bạn có chắc chắn muốn đăng xuất?";
            String caption = "Đăng xuất";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
           

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void FrmMainNVQLSanBanh_Load(object sender, EventArgs e)
        {

        }
    }
}
