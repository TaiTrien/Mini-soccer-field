using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class HoaDonDTO
    {
        public int maHD;
        public int maNhanVien;
        public int maKH;
        public DateTime ngaytaohoadon;

        public int MaKH { get => maKH; set => maKH = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayTaoHoaDon { get => ngaytaohoadon; set => ngaytaohoadon = value; }
    }
}
