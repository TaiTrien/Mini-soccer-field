﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class csvcDTO
    {
        private string maCSVC;
        private string maNhanVien;
        private string tencsvc;
        private int csvchong;
        private int csvctot;
        private int dongianhap;
        private string maHoaDon;
        private string maKH;
        private DateTime ngaytaohoadon;
        private string maLoaiHoaDon;
        private string loaihoadon;
        private string trigiahoadon;
        public string MaLoaiHoaDon { get => maLoaiHoaDon; set => maLoaiHoaDon = value; }
        public string TriGiaHoaDon { get => trigiahoadon; set => trigiahoadon = value; }
        
        public string LoaiHoaDon { get => loaihoadon; set => loaihoadon = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayTaoHoaDon { get => ngaytaohoadon; set => ngaytaohoadon = value; }
        public string MaCSVC { get => maCSVC; set => maCSVC = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string tenCSVC { get => tencsvc; set => tencsvc = value; }
        public int CSVChong { get => csvchong; set => csvchong = value; }
        public int CSVCtot { get => csvctot; set => csvctot = value; }
        public int DonGiaNhap { get => dongianhap; set => dongianhap = value; }
    }
}
