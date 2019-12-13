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
namespace GUI_MANAGER
{
    public partial class frmFacilitiesUpdate : Form
    {
        private csvcBUS csvcBUS;
        private csvcDTO csvcDTO;
        public string temp;
        public frmFacilitiesUpdate()
        {
            InitializeComponent();
            
        }
        private void frmFacilitiesUpdate_Load(object sender, EventArgs e)
        {
            csvcBUS = new csvcBUS();
            Loandatainto_comboBox1();
        }
        private void Loandatainto_comboBox1()
        {
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVC();
            comboBox1.DataSource = listCSVC;
            comboBox1.DisplayMember = "tenCSVC";
            comboBox1.ValueMember = "tenCSVC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ma1 =null;
            int gia = 0;
            switch (comboBox1.Text)
            {
                case "bong":
                    ma1 = 1.ToString();
                    gia = 50000;
                    break;
                case "luoi":
                    ma1 = 2.ToString();
                    gia = 100000;
                    break;
                case "san co":
                    ma1 = 3.ToString();
                    gia = 1000000;
                    break;
                case "den":
                    ma1 = 4.ToString();
                    gia = 10000;
                    break;



            }
            csvcDTO csvcDTO = new csvcDTO();
            temp = ma1;
            csvcDTO.MaHoaDon = csvcBUS.autogenerate_maHOADON().ToString();
            csvcDTO.MaKH = 1.ToString();
            csvcDTO.NgayTaoHoaDon = dateTimePicker1.Value;
            csvcDTO.TriGiaHoaDon = (Decimal.ToInt32(numericUpDown1.Value) * gia).ToString();
            csvcDTO.MaNhanVien = 2.ToString();
            csvcDTO.tenCSVC = comboBox1.Text;
            csvcDTO.tinhtrangCSVC = "tốt";
            csvcDTO.SoLuongNhap =Decimal.ToInt32(numericUpDown1.Value);
            csvcDTO.DonGiaNhap = gia;
            bool resultHD = csvcBUS.facilities_payment(csvcDTO);
            if (resultHD == true)
                MessageBox.Show("Thêm hoá đơn thành công");
            else
                MessageBox.Show("Thêm hoá đơn thất bại");
            bool result = csvcBUS.add(csvcDTO,temp);
            if (result == true)
                MessageBox.Show("Thêm CSVC thành công");
            else
                MessageBox.Show("Thêm CSVC thất bại");
            string val = comboBox1.SelectedValue.ToString();
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVCchance(val);
            if (listCSVC == null)
            {
                MessageBox.Show("Chưa có thông tin CSVC");
            }


            dgv1.Columns.Clear();
            dgv1.DataSource = null;
            dgv1.ReadOnly = true;
            dgv1.AutoGenerateColumns = false;
            dgv1.AllowUserToAddRows = false;
            dgv1.DataSource = listCSVC;

            DataGridViewTextBoxColumn clCSVCCode = new DataGridViewTextBoxColumn();
            clCSVCCode.Name = "maCSVC";
            clCSVCCode.HeaderText = "Mã CSVC";
            clCSVCCode.DataPropertyName = "MaCSVC";
            dgv1.Columns.Add(clCSVCCode);

            DataGridViewTextBoxColumn clTCVSCName = new DataGridViewTextBoxColumn();
            clTCVSCName.Name = "tencsvc";
            clTCVSCName.HeaderText = "Tên CSVC";
            clTCVSCName.DataPropertyName = "tenCSVC";
            dgv1.Columns.Add(clTCVSCName);

            DataGridViewTextBoxColumn clTCVSCStatus = new DataGridViewTextBoxColumn();
            clTCVSCStatus.Name = "tinhtrangcsvc";
            clTCVSCStatus.HeaderText = "Tình Trạng CSVC";
            clTCVSCStatus.DataPropertyName = "tinhtrangCSVC";
            dgv1.Columns.Add(clTCVSCStatus);

            DataGridViewTextBoxColumn clTCVSCval = new DataGridViewTextBoxColumn();
            clTCVSCval.Name = "soluongnhap";
            clTCVSCval.HeaderText = "Số Lượng";
            clTCVSCval.DataPropertyName = "SoLuongNhap";
            dgv1.Columns.Add(clTCVSCval);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma1 = null;
            int gia = 0;
            switch (comboBox1.Text)
            {
                case "bong":
                    ma1 = 1.ToString();
                    gia = 50000;
                    break;
                case "luoi":
                    ma1 = 2.ToString();
                    gia = 700000;
                    break;
                case "san co":
                    ma1 = 3.ToString();
                    gia = 1000000;
                    break;
                case "den":
                    ma1 = 4.ToString();
                    gia = 30000;
                    break;



            }
            csvcDTO csvcDTO = new csvcDTO();
            temp = ma1;

            csvcDTO.MaNhanVien = 2.ToString();
            csvcDTO.tenCSVC = comboBox1.Text;
            csvcDTO.tinhtrangCSVC = "hỏng";
            csvcDTO.SoLuongNhap = Decimal.ToInt32(numericUpDown1.Value);
            csvcDTO.DonGiaNhap = gia;
            bool result = csvcBUS.add(csvcDTO, temp);
            if (result == true)
                MessageBox.Show("Thêm CSVC thành công");
            else
                MessageBox.Show("Thêm CSVC thất bại");
            string val = comboBox1.SelectedValue.ToString();
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVCchance(val);
            if (listCSVC == null)
            {
                MessageBox.Show("Chưa có thông tin CSVC");
            }


            dgv1.Columns.Clear();
            dgv1.DataSource = null;
            dgv1.ReadOnly = true;
            dgv1.AutoGenerateColumns = false;
            dgv1.AllowUserToAddRows = false;
            dgv1.DataSource = listCSVC;

            DataGridViewTextBoxColumn clCSVCCode = new DataGridViewTextBoxColumn();
            clCSVCCode.Name = "maCSVC";
            clCSVCCode.HeaderText = "Mã CSVC";
            clCSVCCode.DataPropertyName = "MaCSVC";
            dgv1.Columns.Add(clCSVCCode);

            DataGridViewTextBoxColumn clTCVSCName = new DataGridViewTextBoxColumn();
            clTCVSCName.Name = "tencsvc";
            clTCVSCName.HeaderText = "Tên CSVC";
            clTCVSCName.DataPropertyName = "tenCSVC";
            dgv1.Columns.Add(clTCVSCName);

            DataGridViewTextBoxColumn clTCVSCStatus = new DataGridViewTextBoxColumn();
            clTCVSCStatus.Name = "tinhtrangcsvc";
            clTCVSCStatus.HeaderText = "Tình Trạng CSVC";
            clTCVSCStatus.DataPropertyName = "tinhtrangCSVC";
            dgv1.Columns.Add(clTCVSCStatus);

            DataGridViewTextBoxColumn clTCVSCval = new DataGridViewTextBoxColumn();
            clTCVSCval.Name = "soluongnhap";
            clTCVSCval.HeaderText = "Số Lượng";
            clTCVSCval.DataPropertyName = "SoLuongNhap";
            dgv1.Columns.Add(clTCVSCval);
        }
    }
}
