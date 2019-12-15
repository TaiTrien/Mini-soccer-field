using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class KhachHangDAL
    {
        private string connectionString;

        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool themKH(KhachHangDTO kh)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[gioiTinh],[diaChi],[loaiKH],[soDT])";
            query += "VALUES (@maKH,@tenKH,@gioiTinh,@diaChi,@loaiKH,@soDT)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@tenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@gioiTinh", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@loaiKH", kh.LoaiKH);
                    cmd.Parameters.AddWithValue("@soDT", kh.SoDT);


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
        public List<KhachHangDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maKH], [tenKH],[gioiTinh],[diaChi],[loaiKH],[soDT]";
            query += "FROM [tblKHACHHANG]";

            List<KhachHangDTO> lsKhachHang = new List<KhachHangDTO>();

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
                                KhachHangDTO kh = new KhachHangDTO();
                                kh.MaKH = int.Parse(reader["maKH"].ToString());
                                kh.TenKH = reader["tenKH"].ToString();
                                kh.GioiTinh = reader["maKH"].ToString();
                                kh.DiaChi = reader["diaChi"].ToString();
                                kh.LoaiKH = reader["loaiKH"].ToString();
                                kh.SoDT = reader["soDT"].ToString();
                                lsKhachHang.Add(kh);
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
            return lsKhachHang; 
        }
        public int autogenerate_maKH()
        {
            int maKH = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MAKH) AS MM from (SELECT CONVERT(float, tblKHACHHANG.maKH) AS MAKH FROM tblKHACHHANG ) AS KQ";

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
                                maKH = int.Parse(reader["MM"].ToString())+1;
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();

                    }
                }
            }
            return maKH;
        }
    }
}
