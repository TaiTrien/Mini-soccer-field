using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class LoaiHoaDonBUS
    {
        private LoaiHoaDonDAL lhdDAL;
        public LoaiHoaDonBUS()
        {
            lhdDAL = new LoaiHoaDonDAL();
        }
        
        public List<LoaiHoaDonDTO> select()
        {
            return lhdDAL.select();
        }
    }
}
