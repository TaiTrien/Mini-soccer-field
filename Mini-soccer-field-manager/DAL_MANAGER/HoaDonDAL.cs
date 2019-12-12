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
