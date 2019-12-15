using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_MANAGER
{
    public class userDTO
    {
        static void Main(string[] args)
        {
        }
        private string userName;
        private string passWord;
        public string TenTaiKhoan { get => userName; set => userName = value; }
        public string MatKhau { get => passWord; set => passWord = value; }
    }
}
