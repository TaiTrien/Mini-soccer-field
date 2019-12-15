using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;
namespace BUS_MANAGER

{
    public class fieldBUS
    {
        private fieldDAL fieldDAL;
        public fieldBUS()
        {
            fieldDAL = new fieldDAL();
        }
        public List<fieldDTO> selectedFields()
        {
            return fieldDAL.selectedFields();
        }

    }
}
