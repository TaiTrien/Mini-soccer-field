using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class SanBUS
    {
        private SanDAL sDAL;
        public SanBUS()
        {
            sDAL = new SanDAL();
        }
        public bool san(SanDTO san)
        {
            bool re = sDAL.san(san);
            return re;
        }
    }
}
