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
        public List<HoaDonDTO> selectByDate(DateTime date1, DateTime date2)
        {
            return hdDAL.selectByDate(date1, date2);
        }
    }
}
