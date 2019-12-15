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
        private float waterPriceInput;
        private float waterPriceOutput;
        private float revivePriceInput;
        private float revivePriceOutput;

        public float LuongNhanVien { get => salary; set => salary = value; }
        public float GiaGiuXe { get => parkingPrice; set => parkingPrice = value; }
        public float GiaSanNgay { get => fieldPriceDay; set => fieldPriceDay = value; }
        public float GiaSanDem { get => fieldPriceNight; set => fieldPriceNight = value; }
        public float GiaCoc { get => deposit; set => deposit = value; }
        public float GiaNhapNuoc { get => waterPriceInput; set => waterPriceInput = value; }
        public float GiaBanNuoc { get => waterPriceOutput; set => waterPriceOutput = value; }
        public float GiaNhapRevive { get => revivePriceInput; set => revivePriceInput = value; }
        public float GiaBanRevive { get => revivePriceOutput; set => revivePriceOutput = value; }
    }
}
