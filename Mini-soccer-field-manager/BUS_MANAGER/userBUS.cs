using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using DAL_MANAGER;

namespace BUS_MANAGER
{
    public class userBUS
    {
        private userDAL userDAL;
        public userBUS()
        {
            userDAL = new userDAL();

        }

        static void Main(string[] args)
        {
        }
        public string selectRole(userDTO userDTO)
        {
            string roleOfAccount = string.Empty;
            roleOfAccount = userDAL.selectRoleAccount(userDTO); // to check what role of this account
            return roleOfAccount;
        }
    }
}

