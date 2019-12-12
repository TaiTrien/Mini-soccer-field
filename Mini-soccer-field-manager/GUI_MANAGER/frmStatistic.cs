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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
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
    }
}
