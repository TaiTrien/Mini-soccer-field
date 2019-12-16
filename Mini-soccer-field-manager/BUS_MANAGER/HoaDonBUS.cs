using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class HoaDonBUS
    {
        private HoaDonDAL hdDAL;
        public HoaDonBUS()
        {
            hdDAL = new HoaDonDAL();
        }
        public bool taoHD(HoaDonDTO hd)
        {
            bool re = hdDAL.taoHD(hd);
            return re;
        }
        public int autogenerate_maHD()
        {
            int re = hdDAL.autogenerate_maHD();
            return re;
        }
        public List<HoaDonDTO> selectByDate(DateTime date1, DateTime date2)
        {
            return hdDAL.selectByDate(date1, date2);
        }
    }
}
