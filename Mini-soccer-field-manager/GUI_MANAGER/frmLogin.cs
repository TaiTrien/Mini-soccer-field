using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using BUS_MANAGER;
using System.Windows.Forms;

namespace GUI_MANAGER
{
    public partial class frmLogin : Form
    {
        private userBUS userBUS;
        private userDTO userDTO;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role;
            userDTO.TenTaiKhoan = tbUserName.Text;
            userDTO.MatKhau = tbPassword.Text;
            role = userBUS.selectRole(userDTO);

            if (role == "NhanVienQLSB")
            {
                this.Hide();
                frmMainNVQLSanBanh frmMainNVQLSanBanh = new frmMainNVQLSanBanh();
                frmMainNVQLSanBanh.Show();
            }
            else if (role == "NhanVienQLCSVC")
            {
                frmFacilitiesCheck frmFacilitiesCheck = new frmFacilitiesCheck();
                frmFacilitiesCheck.Show();
            }
            else if (role == "NhanVienQLTC")
            {
                frmStatistic frmStatistic = new frmStatistic();
                frmStatistic.Show();
            }
            else MessageBox.Show("Đăng nhập thất bại");

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            userBUS = new userBUS();
            userDTO = new userDTO();
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Username")
            {
                tbUserName.Text = string.Empty;
                tbUserName.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = string.Empty;
                tbPassword.ForeColor = Color.Black;
                tbPassword.PasswordChar = '*';
            }
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == string.Empty)
            {
                tbUserName.Text = "Username";
                tbUserName.ForeColor = Color.Gray;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty)
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Gray;
            }
        }
    }
}

