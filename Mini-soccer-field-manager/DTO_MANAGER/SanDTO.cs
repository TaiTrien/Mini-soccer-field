using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class SanDTO
    {
        private int maSan;
        private string tinhTrang;

        public int MaSan { get => maSan; set => maSan = value; }
        public string TinhTrang { get => tinhTrang ; set => tinhTrang = value; }
    }
}
