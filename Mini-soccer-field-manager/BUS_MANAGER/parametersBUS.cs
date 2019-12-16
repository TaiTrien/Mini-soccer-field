using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_MANAGER;
using DAL_MANAGER;

namespace BUS_MANAGER
{
    public class parametersBUS
    {
        private parametersDAL parametersDAL;
        public parametersBUS()
        {
            parametersDAL = new parametersDAL();
        }
        public parametersDTO Selected()
        {
          
            parametersDTO res = new parametersDTO();
            res = parametersDAL.selectedRegulations();
            return res;

        }
        public List<drinksDTO> selectedDrinks() // to select price of them
        { 
            return parametersDAL.selectDrinks();
        }
        public bool update(List <drinksDTO> drinksDTO , parametersDTO parametersDTO ) // to update drinks and facilities
        {
            bool re = parametersDAL.updateDrinks(drinksDTO) && parametersDAL.updatePrice(parametersDTO);
            return re;
        }
        //public bool edit(parametersDTO pr)
        //{
        //    parametersDAL parametersDAL = new parametersDAL();
        //    bool res = parametersDAL.CapNhat(pr);
        //    return res;

        //}
    }
}
