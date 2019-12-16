using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class HoaDonDAL
    {
        private string connectionString;

        public HoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool taoHD(HoaDonDTO hd)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon])";
            query += "VALUES (@maHoaDon,@maNhanVien,@maKH,@ngaytaohoadon)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maHoaDon", hd.MaHD);
                    cmd.Parameters.AddWithValue("@maNhanVien", hd.MaNhanVien);
                    cmd.Parameters.AddWithValue("@maKH", hd.MaKH);
                    cmd.Parameters.AddWithValue("@ngaytaohoadon", hd.NgayTaoHoaDon);
                    


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
        public int autogenerate_maHD()
        {
            int maHD = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MAHD) AS MM from (SELECT CONVERT(float, tblHOADON.maHoaDon) AS MAHD FROM tblHOADON ) AS KQ";

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
                                maHD = int.Parse(reader["MM"].ToString()) + 1;
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
            return maHD;
        }
        public List<HoaDonDTO> selectByDate(DateTime date1, DateTime date2)
        {
            string query = string.Empty;
            query += " SELECT * ";
            query += " FROM [tblHOADON]";
            query += " WHERE ngaytaohoadon>=@date1 and ngaytaohoadon<=@date2 ";


            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@date1", date1.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@date2", date2.ToString("yyyy'-'MM'-'dd"));
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HoaDonDTO hd = new HoaDonDTO();
                                hd.MaHD = int.Parse(reader["maHoaDon"].ToString());
                                hd.MaKH = int.Parse(reader["maKH"].ToString());
                                hd.MaNhanVien = int.Parse(reader["maNhanVien"].ToString());
                                hd.NgayTaoHoaDon = DateTime.Parse(reader["ngaytaohoadon"].ToString());
                                lsHD.Add(hd);

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
            return lsHD;
        }
    }
}
