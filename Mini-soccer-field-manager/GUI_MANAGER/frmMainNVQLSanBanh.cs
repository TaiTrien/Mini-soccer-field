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
    }
}
