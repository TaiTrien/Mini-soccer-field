using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class ChiTietDatSanDTO
    {
        private int maPhieuDatSan;
        private int maSan;
        private DateTime ngayDat;
        private DateTime gioDat;
        private DateTime thoiLuong;

        public int MaPhieuDatSan { get => maPhieuDatSan; set => maPhieuDatSan = value; }
        public int MaSan { get => maSan; set => maSan = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public DateTime GioDat { get => gioDat; set => gioDat = value; }
        public DateTime ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
    }
}
