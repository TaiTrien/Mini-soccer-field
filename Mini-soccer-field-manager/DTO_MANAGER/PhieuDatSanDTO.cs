using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class PhieuDatSanDTO
    {
        private int maPhieuDatSan;
        private int maNhanVien;
        private int maKH;

        public int MaPhieuDatSan { get => maPhieuDatSan; set => maPhieuDatSan = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaKH { get => maKH; set => maKH = value; }
    }
}
