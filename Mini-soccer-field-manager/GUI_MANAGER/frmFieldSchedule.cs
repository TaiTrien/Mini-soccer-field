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
    public partial class frmFieldSchedule : Form
    {
        private PhieuDatSanBUS pdsBus;
        private ChiTietDatSanBUS ctBus;
        private KhachHangBUS khBus;
        public int ParaMaPDS;//Save maPDS when adding chitietdatsan
        public frmFieldSchedule()
        {
            InitializeComponent();
        }
        public void frmFieldSchedule_Load(object sender, EventArgs e)
        {
            pdsBus= new PhieuDatSanBUS();
            ctBus= new ChiTietDatSanBUS();
            khBus = new KhachHangBUS();
            loadCusPhone_Combobox();
            getMaPDS();
            load_dataGridView();
        }
        private void getMaPDS()
        {
            PhieuDatSanDTO pds = new PhieuDatSanDTO();
            ParaMaPDS = pdsBus.autogenerate_maPDS();
        }
        private void loadCusPhone_Combobox()
        {
            List<KhachHangDTO> listKH = khBus.select();

            if (listKH == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu khách hàng");
                return;
            }
            cbCusPhone.DataSource = new BindingSource(listKH, String.Empty);
            cbCusPhone.DisplayMember = "Số ĐT";
            cbCusPhone.ValueMember = "soDT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbCusPhone.DataSource];
            myCurrencyManager.Refresh();

            if (cbCusPhone.Items.Count > 0)
            {
                cbCusPhone.SelectedIndex = 0;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void load_dataGridView()
        {
            List<PhieuDatSanDTO> listpds = pdsBus.select();
            List<ChiTietDatSanDTO> listctds = ctBus.select();
            loadData_Vao_GridView(listpds, listctds);
        }
        private void loadData_Vao_GridView(List<PhieuDatSanDTO> listPhieuDatSan,List<ChiTietDatSanDTO> listCTDatSan)
        {
            if (listPhieuDatSan == null || listCTDatSan==null)
            {
                MessageBox.Show("Đã xảy ra lỗi");
                return;
            }

            DGVFieldSchedule.Columns.Clear();
            DGVFieldSchedule.DataSource = null;

            DGVFieldSchedule.AutoGenerateColumns = false;
            DGVFieldSchedule.AllowUserToAddRows = false;
            DGVFieldSchedule.DataSource = listPhieuDatSan;
            DGVFieldSchedule.DataSource = listCTDatSan;

            DataGridViewTextBoxColumn clMaPDS = new DataGridViewTextBoxColumn();
            clMaPDS.Name = "MaPDS";
            clMaPDS.HeaderText = "Mã Phiếu";
            clMaPDS.DataPropertyName = "maPhieuDatSan";
            DGVFieldSchedule.Columns.Add(clMaPDS);

            DataGridViewTextBoxColumn clMaSan = new DataGridViewTextBoxColumn();
            clMaSan.Name = "MaSan";
            clMaSan.HeaderText = "Sân";
            clMaSan.DataPropertyName = "maSan";
            DGVFieldSchedule.Columns.Add(clMaSan);

            DataGridViewTextBoxColumn clNgDat = new DataGridViewTextBoxColumn();
            clNgDat.Name = "NgayDat";
            clNgDat.HeaderText = "Ngày Đặt";
            clNgDat.DataPropertyName = "ngayDat";
            DGVFieldSchedule.Columns.Add(clNgDat);
            this.DGVFieldSchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridViewTextBoxColumn clGiDat = new DataGridViewTextBoxColumn();
            clGiDat.Name = "GioDat";
            clGiDat.HeaderText = "Giờ Đặt";
            clGiDat.DataPropertyName = "gioDat";         
            DGVFieldSchedule.Columns.Add(clGiDat);
            this.DGVFieldSchedule.Columns[3].DefaultCellStyle.Format = "hh:mm tt";
            DataGridViewTextBoxColumn clThLuong = new DataGridViewTextBoxColumn();
            clThLuong.Name = "ThoiLuong";
            clThLuong.HeaderText = "Thời Lượng";
            clThLuong.DataPropertyName = "thoiLuong";
            DGVFieldSchedule.Columns.Add(clThLuong);
            this.DGVFieldSchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[DGVFieldSchedule.DataSource];
            myCurrencyManager.Refresh();          
        }

        private void btnReserveField_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuDatSanDTO pds = new PhieuDatSanDTO();
            pds.MaPhieuDatSan = pdsBus.autogenerate_maPDS();
            pds.MaNhanVien = 1;
            List<KhachHangDTO> listKH = khBus.select();

            foreach (KhachHangDTO kh in listKH)
            {
                if (cbCusPhone.Text == kh.SoDT)
                {
                    pds.MaKH = kh.MaKH;
                }
            }
            ChiTietDatSanDTO ct = new ChiTietDatSanDTO();
            ct.MaPhieuDatSan = pds.MaPhieuDatSan;
            ct.MaSan = int.Parse(cbFieldName.Text);
            ct.NgayDat = dTPReservationDate.Value;
            ct.ThoiLuong = dTPlength.Value;
            ct.GioDat =dTPTime.Value;
            //2. Insert into DB
            bool kq1 = pdsBus.datsan(pds);
            bool kq2 = ctBus.themchitietdatsan(ct);
            if (kq1 == false || kq2 == false)
                MessageBox.Show("Đặt sân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Đặt sân thành công");
            load_dataGridView();
        }
        private void HuySanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ' Get the current cell location.
            int currentRowIndex = DGVFieldSchedule.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < DGVFieldSchedule.RowCount)
            {
                PhieuDatSanDTO pds = new PhieuDatSanDTO();
                ChiTietDatSanDTO ct = new ChiTietDatSanDTO();
                DataGridViewRow selectedRow = DGVFieldSchedule.Rows[currentRowIndex];
                pds.MaPhieuDatSan = int.Parse(selectedRow.Cells[0].Value.ToString());
                ct.MaPhieuDatSan = int.Parse(selectedRow.Cells[0].Value.ToString());
                ct.MaSan = int.Parse(selectedRow.Cells[1].Value.ToString());
                ct.ThoiLuong = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                ct.NgayDat = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                ct.GioDat = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                bool kq1=false, kq2=false;
                if (ct != null)
                {
                    kq1 = ctBus.huychitietdatsan(ct);
                }
                if (pds != null)
                {
                    kq2 = pdsBus.huysan(pds);
                  
                }
                if (kq1 == false && kq2==false)
                    MessageBox.Show("Hủy sân thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Hủy sân thành công");
                    this.load_dataGridView();
                }
            }

        }
        private void btnADD_Click(object sender, EventArgs e)
        {     
            ChiTietDatSanDTO ct = new ChiTietDatSanDTO();
            ct.MaPhieuDatSan = ParaMaPDS;
            ct.MaSan = int.Parse(cbFieldName.Text);
            ct.NgayDat = dTPReservationDate.Value;
            ct.ThoiLuong = dTPlength.Value;
            ct.GioDat = dTPTime.Value;
            bool kq = ctBus.themchitietdatsan(ct);
            if (kq == false)
                MessageBox.Show("Đặt sân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Đặt sân thành công");
            load_dataGridView();
        }
        
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
            
        }
    }
}
