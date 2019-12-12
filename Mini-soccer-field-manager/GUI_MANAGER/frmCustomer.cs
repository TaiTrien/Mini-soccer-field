using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_MANAGER;
using BUS_MANAGER;
using DAL_MANAGER;
namespace GUI_MANAGER
{
    public partial class frmCustomer : Form
    {
        private KhachHangBUS khBus;
        public bool click;
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void frmThemKH_Load(object sender, EventArgs e)
        {
            khBus = new KhachHangBUS();
            cbCusType.Items.Add("Vãng lai");
            click = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSaveCus_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = khBus.autogenerate_maKH();
            kh.TenKH = tbCusName.Text;
            kh.DiaChi = tbCusAddr.Text;
            kh.SoDT = tbCusPhone.Text;
            if (rbMale.Checked == true)
            {
                kh.GioiTinh = "Nam";
            }
            else
            {
                kh.GioiTinh = "Nữ";
            }
            
            kh.LoaiKH = cbCusType.Text;
            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = khBus.themKH(kh);
            if (kq == false)
                MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm khách hàng thành công");
            click = true;
        }
    }
}
