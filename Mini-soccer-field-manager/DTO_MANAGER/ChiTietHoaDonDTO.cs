using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class ChiTietHoaDonDTO
    {
        public int maHD;
        public int maloaiHoaDon;
        public float trigiaHoaDon;

        public int MaLoaiHoaDon { get => maloaiHoaDon; set => maloaiHoaDon = value; }
        public int MaHD { get => maHD; set => maHD = value; }

        public float TriGiaHoaDon { get => trigiaHoaDon; set => trigiaHoaDon = value; }
    }
}
