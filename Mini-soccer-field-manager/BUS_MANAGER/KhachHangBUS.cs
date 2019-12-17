using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL;
        public KhachHangBUS()
        {
            khDAL = new KhachHangDAL();
        }
        public bool themKH(KhachHangDTO kh)
        {
            bool re = khDAL.themKH(kh);
            return re;
        }
        public int autogenerate_maKH()
        {
            int re = khDAL.autogenerate_maKH();
            return re;
        }
        public List<KhachHangDTO> select()
        {
            return khDAL.select();
        }
    }
}