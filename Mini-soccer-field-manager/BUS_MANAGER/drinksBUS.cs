﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_MANAGER;
using DTO_MANAGER;

namespace BUS_MANAGER
{
    public class drinksBUS
    {
        static void main()
        {
        }

        private drinksDAL drinksDAL;
        public drinksBUS()
        {
            drinksDAL = new drinksDAL();
        }
        public bool addDrinksToBill(HoaDonDTO hoaDonDTO, ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            bool re = drinksDAL.addDrinksToBill(hoaDonDTO, chiTietHoaDonDTO);
            return re;
        }
        public bool update(drinksDTO drinksDTO)
        {
            bool re = drinksDAL.update(drinksDTO);
            return re;
        }
        public List<drinksDTO> selectDrinks()
        {
            return drinksDAL.selectDrinks();
        }
        public int autogenerate_maHOADON()
        {
            return drinksDAL.autogenerate_maHOADON();
        }
        public drinksDTO selectPrice(int maDrinks) // to select drink based on its code
        {
            return drinksDAL.selectPrice(maDrinks);
        }
    }
}
