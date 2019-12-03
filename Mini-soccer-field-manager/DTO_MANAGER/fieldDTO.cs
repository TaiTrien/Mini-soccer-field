using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class fieldDTO
    {
        private string fieldCode;
        private int fieldStatus;
        private DateTime bookingDate;
        private DateTime startTime; // time to begin playing
        private float duration; // how long is the game
        private string customerName; 
        public string MaSanBanh { get => fieldCode; set => fieldCode = value; }
        public int TinhTrangSan { get => fieldStatus; set => fieldStatus = value; }
        public DateTime NgayDatSan { get => bookingDate; set => bookingDate = value; }
        public DateTime GioDatSan { get => startTime; set => startTime = value; }
        public float ThoiLuongDatSan { get => duration; set => duration = value; }
        public string tenKH { get => customerName; set => customerName = value; }


    }
}
