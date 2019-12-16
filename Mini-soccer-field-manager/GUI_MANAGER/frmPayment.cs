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
    public partial class frmPayment : Form
    {
        private HoaDonBUS hdBus;
        private ChiTietHoaDonBUS cthdBus;
        private LoaiHoaDonBUS lhdBus;
        private KhachHangBUS khBus;
        private parametersBUS parBus;
        private drinksBUS drkBus;
        private drinksDTO water;
        private drinksDTO revive;
        private float thunuoc;
        private float thusan;
        private float tong;
        private float giaRevive;
        private float giaNuoc;
        private KhachHangDTO KH;
        private float khuyenmai = 0;
        public frmPayment()
        {
            InitializeComponent();
        }
        public void frmPayment_Load(object sender, EventArgs e)
        {
            hdBus = new HoaDonBUS();
            cthdBus = new ChiTietHoaDonBUS();
            lhdBus = new LoaiHoaDonBUS();
            khBus = new KhachHangBUS();
            parBus = new parametersBUS();
            drkBus = new drinksBUS();
            KH = new KhachHangDTO();
            water = new drinksDTO();
            water = drkBus.selectPrice(1);
            revive = new drinksDTO();
            revive = drkBus.selectPrice(2);
            giaNuoc = water.DonGiaBan;
            giaRevive = revive.DonGiaBan;
            //List<drinksDTO> listdrk = drkBus.selectDrinks();
            //foreach (drinksDTO drk in listdrk)
            //{
            //    if (drk.MaDoUong == "1")
            //    {
            //        giaNuoc = drk.DonGiaBan;
            //    }
            //    else if (drk.MaDoUong == "2")
            //    {
            //        giaRevive = drk.DonGiaBan;
            //    }
            //}
            LoadInfo();
            loadCusPhone_Combobox();
            tbTotalMoney.Text = "0";

        }

        public void LoadInfo()
        {
            loadCusInfo();
            loadTimeTotal();
        }
        public void loadCusPhone_Combobox()
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
        public void loadCusInfo() // to load info customer
        {

            List<KhachHangDTO> listKH = khBus.select();

            if (listKH == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu khách hàng");
                return;
            }
            foreach (KhachHangDTO kh in listKH)
            {
                if (cbCusPhone.Text == kh.SoDT)
                {
                    tbCustomerName.Text = kh.TenKH;
                }
            }

        }
        public void loadTimeTotal() // to load total time they play
        {
            float temp = float.Parse(frmRingTheBell.SetValueForTongGioDa);

            float totalTime = (float)Math.Round((temp / 60), 1); // total in minutes
            tbTotalTime.Text = totalTime.ToString();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private float GiaSan()
        {
            parametersDTO par = parBus.Selected();
            if (int.Parse(DateTime.UtcNow.ToString("HH")) >= 19)
            {

                return par.GiaSanDem;
            }
            else return par.GiaSanNgay;
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            parametersDTO par = parBus.Selected();

            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = hdBus.autogenerate_maHD();
            hd.MaNhanVien = 1;
            List<KhachHangDTO> listKH = khBus.select();

            foreach (KhachHangDTO kh in listKH)
            {
                if (cbCusPhone.Text == kh.SoDT)
                {
                    hd.MaKH = kh.MaKH;
                }
            }
            hd.ngaytaohoadon = DateTime.UtcNow;
            ChiTietHoaDonDTO cthdsan = new ChiTietHoaDonDTO();
            ChiTietHoaDonDTO cthdnuoc = new ChiTietHoaDonDTO();
            cthdsan.MaHD = hd.MaHD;
            cthdsan.MaLoaiHoaDon = 1;
            cthdsan.trigiaHoaDon = float.Parse(tbTotalTime.Text) * GiaSan() + int.Parse(nUDParkingCars.Value.ToString()) * par.GiaGiuXe;
            if (int.Parse(nUDRevieDrink.Value.ToString()) != 0 || int.Parse(nUDWaterDrink.Value.ToString()) != 0)
            {
                cthdnuoc.MaHD = hd.MaHD;
                cthdnuoc.MaLoaiHoaDon = 3;
                cthdnuoc.trigiaHoaDon = int.Parse(nUDRevieDrink.Value.ToString()) * giaRevive + int.Parse(nUDWaterDrink.Value.ToString()) * giaNuoc;
            }

            //2. Insert into DB
            bool kq1 = hdBus.taoHD(hd);
            bool kq2 = cthdBus.taoCTHD(cthdsan) && cthdBus.taoCTHD(cthdnuoc);
            if (kq1 == false || kq2 == false)
                MessageBox.Show("Thanh toán thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thanh toán thành công");

        }
        private float tinhTong()
        {

            parametersDTO par = parBus.Selected();
            return float.Parse(tbTotalTime.Text) * GiaSan() + int.Parse(nUDWaterDrink.Value.ToString()) * giaNuoc + int.Parse(nUDRevieDrink.Value.ToString()) * giaRevive
            + int.Parse(nUDParkingCars.Value.ToString()) * par.GiaGiuXe/**par.GiaGiuXe*/ - float.Parse(tbDiscountMoney.Text);

        }
        private void tbTotalTime_TextChanged(object sender, EventArgs e)
        {

            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            tbTotalMoney.Text = tinhTong().ToString();
        }

        private void nUDWaterDrink_ValueChanged(object sender, EventArgs e)
        {
            tbTotalMoney.Text = tinhTong().ToString();
        }

        private void nUDRevieDrink_ValueChanged(object sender, EventArgs e)
        {
            tbTotalMoney.Text = tinhTong().ToString();
        }

        private void nUDParkingCars_ValueChanged(object sender, EventArgs e)
        {
            tbTotalMoney.Text = tinhTong().ToString();
        }

        private void tbDiscountMoney_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            tbTotalMoney.Text = tinhTong().ToString();
        }

        private void cbCusPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCusInfo();
        }
    }
}
