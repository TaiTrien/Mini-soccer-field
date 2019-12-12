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
    public partial class frmFacilitiesCheck : Form
    {
        private csvcBUS csvcBUS;
        private csvcDTO csvcDTO;
        public frmFacilitiesCheck()
        {
            InitializeComponent();
        }

        private void frmFacilitiesCheck_Load(object sender, EventArgs e)
        {
            csvcBUS = new csvcBUS();

            cbdselectedvalue(); 
            //LoadDataInto_DataGridViewOfCSVC();
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVC();
            cbFacilities.DataSource = listCSVC;
        }
        private void cbdselectedvalue()
        {
            cbFacilities.DisplayMember = "tenCSVC";
            cbFacilities.ValueMember = "tenCSVC";
        }
        
        /*private void LoadDataInto_DataGridViewOfCSVC()
        {
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVC();
            if (listCSVC == null)
            {
                MessageBox.Show("Chưa có thông tin CSVC");
            }
        
            
            dgvCSVC.Columns.Clear();
            dgvCSVC.DataSource = null;
            dgvCSVC.ReadOnly = true;
            dgvCSVC.AutoGenerateColumns = false;
            dgvCSVC.AllowUserToAddRows = false;
            dgvCSVC.DataSource = listCSVC;

            DataGridViewTextBoxColumn clCSVCCode = new DataGridViewTextBoxColumn();
            clCSVCCode.Name = "maCSVC";
            clCSVCCode.HeaderText = "Mã CSVC";
            clCSVCCode.DataPropertyName = "MaCSVC";
            dgvCSVC.Columns.Add(clCSVCCode);

            DataGridViewTextBoxColumn clTCVSCName = new DataGridViewTextBoxColumn();
            clTCVSCName.Name = "tencsvc";
            clTCVSCName.HeaderText = "Tên CSVC";
            clTCVSCName.DataPropertyName = "tenCSVC";
            dgvCSVC.Columns.Add(clTCVSCName);

            DataGridViewTextBoxColumn clTCVSCStatus = new DataGridViewTextBoxColumn();
            clTCVSCStatus.Name = "tinhtrangcsvc";
            clTCVSCStatus.HeaderText = "Tình Trạng CSVC";
            clTCVSCStatus.DataPropertyName = "tinhtrangCSVC";
            dgvCSVC.Columns.Add(clTCVSCStatus);
        }*/
        private void LbUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmFacilitiesUpdate frmFacilitiesUpdate = new frmFacilitiesUpdate();
            frmFacilitiesUpdate.Show();         
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string val = cbFacilities.SelectedValue.ToString();
            List<csvcDTO> listCSVC = csvcBUS.selectedCSVCchance(val);
            if (listCSVC == null)
            {
                MessageBox.Show("Chưa có thông tin CSVC");
            }


            dgvCSVC.Columns.Clear();
            dgvCSVC.DataSource = null;
            dgvCSVC.ReadOnly = true;
            dgvCSVC.AutoGenerateColumns = false;
            dgvCSVC.AllowUserToAddRows = false;
            dgvCSVC.DataSource = listCSVC;

            DataGridViewTextBoxColumn clCSVCCode = new DataGridViewTextBoxColumn();
            clCSVCCode.Name = "maCSVC";
            clCSVCCode.HeaderText = "Mã CSVC";
            clCSVCCode.DataPropertyName = "MaCSVC";
            dgvCSVC.Columns.Add(clCSVCCode);

            DataGridViewTextBoxColumn clTCVSCName = new DataGridViewTextBoxColumn();
            clTCVSCName.Name = "tencsvc";
            clTCVSCName.HeaderText = "Tên CSVC";
            clTCVSCName.DataPropertyName = "tenCSVC";
            dgvCSVC.Columns.Add(clTCVSCName);

            DataGridViewTextBoxColumn clTCVSCStatus = new DataGridViewTextBoxColumn();
            clTCVSCStatus.Name = "tinhtrangcsvc";
            clTCVSCStatus.HeaderText = "Tình Trạng CSVC";
            clTCVSCStatus.DataPropertyName = "tinhtrangCSVC";
            dgvCSVC.Columns.Add(clTCVSCStatus);

            DataGridViewTextBoxColumn clTCVSCval = new DataGridViewTextBoxColumn();
            clTCVSCval.Name = "soluongnhap";
            clTCVSCval.HeaderText = "Số Lượng";
            clTCVSCval.DataPropertyName = "SoLuongNhap";
            dgvCSVC.Columns.Add(clTCVSCval);
        }

        
    }
}
