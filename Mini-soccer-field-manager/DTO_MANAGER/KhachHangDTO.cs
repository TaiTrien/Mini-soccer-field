using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class KhachHangDTO
    {
        private int maKH;
        private string tenKH;
        private string gioiTinh;
        private string diaChi;
        private string loaiKH;
        private string soDT;

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
