using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class PhieuDatSanBUS
    {
        private PhieuDatSanDAL pdsDAL;
        public PhieuDatSanBUS()
        {
            pdsDAL = new PhieuDatSanDAL();
        }
        public bool datsan(PhieuDatSanDTO pds)
        {
            bool re = pdsDAL.datsan(pds);
            return re;
        }
        public bool huysan(PhieuDatSanDTO pds)
        {
            bool re = pdsDAL.huysan(pds);
            return re;
        }
        public int autogenerate_maPDS()
        {
            int re = pdsDAL.autogenerate_maPDS();
            return re;
        }
        public List<PhieuDatSanDTO> select()
        {
            return pdsDAL.select();
        }
    }
}
