using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class SanDAL
    {
        private string connectionString;

        public SanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool san(SanDTO san)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblSAN] ([maSan], [tinhTrang])";
            query += "VALUES (@maSan,@tinhTrang)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSan", san.MaSan);
                    cmd.Parameters.AddWithValue("@tinhTrang", san.TinhTrang);
                 

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public List<SanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maSan], [tinhTrang]";
            query += "FROM [tblSAN]";

            List<SanDTO> lsSan = new List<SanDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                SanDTO san = new SanDTO();
                                san.MaSan = int.Parse(reader["maSan"].ToString());
                                san.TinhTrang = reader["tinhTrang"].ToString();
                                lsSan.Add(san);
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
            return lsSan;
        }
    }
}
