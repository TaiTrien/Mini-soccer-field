﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAL cthdDAL;
        public ChiTietHoaDonBUS()
        {
            cthdDAL = new ChiTietHoaDonDAL();
        }
        public bool taoCTHD(ChiTietHoaDonDTO cthd)
        {
            bool re = cthdDAL.taoCTHD(cthd);
            return re;
        }
        public List<ChiTietHoaDonDTO> select()
        {
            return cthdDAL.select();
        }
    }
}
