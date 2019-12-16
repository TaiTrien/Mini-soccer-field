using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO_MANAGER;
using System.Diagnostics;
using System.Configuration;
namespace DAL_MANAGER
{
    public class userDAL
    {
        static void Main(string[] args)
        {
        }
        private string connectionString;

        public userDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public string selectRoleAccount(userDTO user) // to select role of this account
        {
            string role = string.Empty;
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM tblTAIKHOAN ";
            query += "WHERE userName = @username AND passWord = @password";
            using (SqlConnection con = new SqlConnection(/*ConnectionString*/@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", user.TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@password", user.MatKhau);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                role = reader["role"].ToString();
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }

            }
            return role;
        }
    }
}


    