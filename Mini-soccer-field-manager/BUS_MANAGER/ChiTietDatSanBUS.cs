using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class ChiTietDatSanBUS
    {
        private ChiTietDatSanDAL ctDAL;
        public ChiTietDatSanBUS()
        {
            ctDAL = new ChiTietDatSanDAL();
        }
        public bool themchitietdatsan(ChiTietDatSanDTO ct)
        {
            bool re = ctDAL.themchitietdatsan(ct);
            return re;
        }
        public bool huychitietdatsan(ChiTietDatSanDTO ct)
        {
            bool re = ctDAL.huychitietdatsan(ct);
            return re;
        }
        public List<ChiTietDatSanDTO> select()
        {
            return ctDAL.select();
        }


    }
}
