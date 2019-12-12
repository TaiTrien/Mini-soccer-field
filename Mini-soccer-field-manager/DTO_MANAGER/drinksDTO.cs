using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class drinksDTO
    {
        
        

        private String drinksID;
        private String drinksName;
        private int drinksLeft;
        private int drinksPurchasePrice;
        private int drinksSalePrice;
        private DateTime billDate;

        public String MaDoUong { get => drinksID; set => drinksID = value; }
        public String TenDoUong { get => drinksName; set => drinksName = value; }
        public int DoUongConLai { get => drinksLeft; set => drinksLeft = value; }
        public int DonGiaMua { get => drinksPurchasePrice; set => drinksPurchasePrice = value; }
        public int DonGiaBan { get => drinksSalePrice; set => drinksSalePrice = value; }
        public DateTime NgayHoaDon { get => billDate; set => billDate = value; }
    }
}
