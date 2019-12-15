using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class LoaiHoaDonDTO
    {
        public int maloaiHoaDon;
        public string tenloaiHoaDon;

        public int MaLoaiHoaDon { get => maloaiHoaDon; set => maloaiHoaDon = value; }

        public string TenLoaiHoaDon { get => tenloaiHoaDon; set => tenloaiHoaDon = value; }
    }
}
