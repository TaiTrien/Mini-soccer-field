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
    public partial class frmStatistic : Form
    {
        private HoaDonBUS hdBus;
        private ChiTietHoaDonBUS cthdBus;
        private LoaiHoaDonBUS lhdBus;
        public frmStatistic()
        {
            InitializeComponent();
        }
        public void frmStatistic_Load(object sender, EventArgs e)
        {
            hdBus = new HoaDonBUS();
            cthdBus = new ChiTietHoaDonBUS();
            lhdBus = new LoaiHoaDonBUS();

        }
        private void load_dataGridView()
        {
            DateTime month = dtpMonth.Value;
            DateTime year = dtpYear.Value;
            var firstDayOfMonth = new DateTime(year.Year, month.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            List<HoaDonDTO> listhd = hdBus.selectByDate(firstDayOfMonth, lastDayOfMonth);
            List<ChiTietHoaDonDTO> listcthd = cthdBus.select();
            List<LoaiHoaDonDTO> listlhd = lhdBus.select();
            loadData_Vao_GridView(listhd, listcthd, listlhd);
        }
        private void loadData_Vao_GridView(List<HoaDonDTO> listHD, List<ChiTietHoaDonDTO> listctHD, List<LoaiHoaDonDTO> listloaiHD)
        {
            if (listHD == null || listctHD == null || listloaiHD == null)
            {
                MessageBox.Show("Đã xảy ra lỗi");
                return;
            }

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            DataTable table = new DataTable();
            table.Columns.Add("Mã Hóa Đơn", typeof(int));
            table.Columns.Add("Loại Hóa Đơn", typeof(string));
            table.Columns.Add("Ngày Tạo", typeof(DateTime));
            table.Columns.Add("Mã Khách Hàng", typeof(int));
            table.Columns.Add("Mã Nhân Viên", typeof(int));
            table.Columns.Add("Trị Giá", typeof(float));

            foreach (HoaDonDTO hd in listHD)
            {
                foreach (LoaiHoaDonDTO lhd in listloaiHD)
                {
                    foreach (ChiTietHoaDonDTO cthd in listctHD)
                    {
                        if (hd.MaHD == cthd.MaHD && lhd.MaLoaiHoaDon == cthd.MaLoaiHoaDon)
                        {

                            DataRow row = table.NewRow();
                            row["Mã Hóa Đơn"] = hd.MaHD;
                            row["Loại Hóa Đơn"] = lhd.TenLoaiHoaDon;
                            row["Ngày Tạo"] = hd.ngaytaohoadon;
                            row["Mã Khách Hàng"] = hd.MaKH;
                            row["Mã Nhân Viên"] = hd.MaNhanVien;
                            row["Trị Giá"] = cthd.TriGiaHoaDon;
                            table.Rows.Add(row);

                        }
                    }
                }
            }

            dataGridView1.DataSource = table.DefaultView;
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            load_dataGridView();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
