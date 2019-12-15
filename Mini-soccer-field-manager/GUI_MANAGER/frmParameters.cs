using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_MANAGER;
using BUS_MANAGER;
namespace GUI_MANAGER
{
    public partial class frmParameters : Form
    {
        private parametersBUS paraBUS;
        parametersDTO para = new parametersDTO();
        public frmParameters()
        {
            InitializeComponent();
            paraBUS = new parametersBUS();
        }
        public void loadInfo()
        {
            para = paraBUS.Selected();
            tbFieldPriceDay.Text = para.GiaSanNgay.ToString();
            tbFieldPriceNight.Text = para.GiaSanDem.ToString();
            tbPriceParking.Text = para.GiaGiuXe.ToString();
            tbSalary.Text = para.LuongNhanVien.ToString();
            tbDeposit.Text = para.GiaCoc.ToString();
        }

        private void frmParameters_Load(object sender, EventArgs e)
        {
            loadInfo();
        }
    }
}
