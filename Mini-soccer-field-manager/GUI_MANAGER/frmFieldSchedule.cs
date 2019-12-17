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
        public int ParaMaPDS = 0;//Save maPDS when adding chitietdatsan
        public frmFieldSchedule()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void frmFieldSchedule_Load(object sender, EventArgs e)
        {
            pdsBus = new PhieuDatSanBUS();
            ctBus = new ChiTietDatSanBUS();
            khBus = new KhachHangBUS();
            loadCusPhone_Combobox();
            getMaPDS();
            load_dataGridView();
            BtnConfirm.Visible = false;
            BtnCancel.Visible = false;
            btnAdd.Enabled = false;
        }
        private void getMaPDS()
        {
            PhieuDatSanDTO pds = new PhieuDatSanDTO();
            ParaMaPDS = pdsBus.autogenerate_maPDS();
        }
        public void loadCusPhone_Combobox()
        {
            KhachHangDTO KH = khBus.select(frmRingTheBell.SetValueForMaSan);

            if (KH == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu khách hàng");
                return;
            }
            cbCusPhone.DataSource = new BindingSource(KH, String.Empty);
            cbCusPhone.DisplayMember = "Số ĐT";
            cbCusPhone.ValueMember = "soDT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbCusPhone.DataSource];
            myCurrencyManager.Refresh();

            if (cbCusPhone.Items.Count > 0)
            {
                cbCusPhone.SelectedIndex = 0;
            }

        }

        private void load_dataGridView()
        {
            List<PhieuDatSanDTO> listpds = pdsBus.select();
            List<ChiTietDatSanDTO> listctds = ctBus.select();
            /*ist<KhachHangDTO> listkh = khBus.select();*/
            //loadData_Vao_GridView(listpds, listctds, listkh);
        }
        private void loadData_Vao_GridView(List<PhieuDatSanDTO> listPhieuDatSan, List<ChiTietDatSanDTO> listCTDatSan, List<KhachHangDTO> listKH)
        {
            if (listPhieuDatSan == null || listCTDatSan == null || listKH == null)
            {
                MessageBox.Show("Đã xảy ra lỗi");
                return;
            }

            DGVFieldSchedule.Columns.Clear();
            DGVFieldSchedule.DataSource = null;

            DataTable table = new DataTable();
            table.Columns.Add("Mã Phiếu Đặt Sân", typeof(int));
            table.Columns.Add("Sân", typeof(int));
            table.Columns.Add("Khách Hàng", typeof(string));
            table.Columns.Add("Ngày Đặt", typeof(DateTime));
            table.Columns.Add("Giờ Đặt", typeof(DateTime));
            table.Columns.Add("Thời Lượng", typeof(DateTime));


            foreach (PhieuDatSanDTO pds in listPhieuDatSan)
            {
                foreach (ChiTietDatSanDTO ctds in listCTDatSan)
                {
                    foreach (KhachHangDTO kh in listKH)
                    {
                        if (pds.MaPhieuDatSan == ctds.MaPhieuDatSan && pds.MaKH == kh.MaKH)
                        {

                            DataRow row = table.NewRow();
                            row["Mã Phiếu Đặt Sân"] = pds.MaPhieuDatSan;
                            row["Sân"] = ctds.MaSan;
                            row["Khách Hàng"] = kh.TenKH;
                            row["Ngày Đặt"] = ctds.NgayDat;
                            row["Giờ Đặt"] = ctds.GioDat;
                            row["Thời Lượng"] = ctds.ThoiLuong;
                            table.Rows.Add(row);

                        }
                    }
                }
            }

            DGVFieldSchedule.DataSource = table.DefaultView;
            this.DGVFieldSchedule.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.DGVFieldSchedule.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
            this.DGVFieldSchedule.Columns[5].DefaultCellStyle.Format = "HH:mm";
        }

        private void btnReserveField_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuDatSanDTO pds = new PhieuDatSanDTO();
            pds.MaPhieuDatSan = pdsBus.autogenerate_maPDS();
            pds.MaNhanVien = 1;
            //List<KhachHangDTO> listKH = khBus.select();

            //foreach (KhachHangDTO kh in listKH)
            //{
            //    if (cbCusPhone.Text == kh.SoDT)
            //    {
            //        pds.MaKH = kh.MaKH;
            //    }
            //}
            ChiTietDatSanDTO ct = new ChiTietDatSanDTO();
            ct.MaPhieuDatSan = pds.MaPhieuDatSan;
            ct.MaSan = int.Parse(cbFieldName.Text);
            ct.NgayDat = dTPReservationDate.Value;
            ct.ThoiLuong = dTPlength.Value;
            ct.GioDat = dTPTime.Value;
            //2. Insert into DB
            bool kq1 = pdsBus.datsan(pds);
            bool kq2 = ctBus.themchitietdatsan(ct);
            if (kq1 == false || kq2 == false)
                MessageBox.Show("Đặt sân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Đặt sân thành công");
            load_dataGridView();
            btnAdd.Enabled = true;
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
                ct.ThoiLuong = DateTime.Parse(selectedRow.Cells[5].Value.ToString());
                ct.NgayDat = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                ct.GioDat = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                bool kq1 = false, kq2 = false;
                if (ct != null)
                {
                    kq1 = ctBus.huychitietdatsan(ct);
                }
                if (pds != null)
                {
                    kq2 = pdsBus.huysan(pds);

                }
                if (kq1 == false && kq2 == false)
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
            cbCusPhone.Enabled = false;
            btnAdd.Visible = false;
            btnReserveField.Visible = false;
            BtnConfirm.Visible = true;
            BtnCancel.Visible = true;
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
            cus.btnSaveCus.Click += new System.EventHandler(button2_click);
        }
        public void button2_click(object sender, EventArgs e)
        {
            loadCusPhone_Combobox();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
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
            Ani();
        }

        private void Ani()
        {
            BtnConfirm.Visible = false;
            BtnCancel.Visible = false;
            btnAdd.Visible = true;
            btnReserveField.Visible = true;
            cbCusPhone.Enabled = true;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Ani();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}