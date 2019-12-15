using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER
{
    public class csvcBUS
    {
        private csvcDAL csvcDAL;
        public csvcBUS()
        {
            csvcDAL = new csvcDAL();
        }
        public bool facilities_payment(csvcDTO csvc)
        {
            bool ispayment = csvcDAL.facilities_payment(csvc);
            return ispayment;
        }
        public bool add(csvcDTO CSVC,string maold)
        {
            bool isAdd = csvcDAL.add(CSVC,maold);
            return isAdd;
        }
        public List<csvcDTO> selectedCSVC()
        {
            return csvcDAL.selectedCSVC();
        }
        public List<csvcDTO> selectedCSVCchance(string sel_item)
        { 
            return csvcDAL.selectedCSVCchance(sel_item);
        }
        public int autogenerate_maHOADON()
        {
            return csvcDAL.autogenerate_maHOADON();
        }
    }
}
