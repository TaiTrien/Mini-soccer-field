using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class parametersDTO
    {
        private float salary;
        private float parkingPrice;
        private float fieldPriceDay;
        private float fieldPriceNight;
        private float deposit; 
       

        public float LuongNhanVien { get => salary; set => salary = value; }
        public float GiaGiuXe { get => parkingPrice; set => parkingPrice = value; }
        public float GiaSanNgay { get => fieldPriceDay; set => fieldPriceDay = value; }
        public float GiaSanDem { get => fieldPriceNight; set => fieldPriceNight = value; }
        public float GiaCoc { get => deposit; set => deposit = value; }

    }
}
