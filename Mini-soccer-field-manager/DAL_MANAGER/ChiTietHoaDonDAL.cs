using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class ChiTietHoaDonDAL
    {
        private string connectionString;

        public ChiTietHoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool taoCTHD(ChiTietHoaDonDTO cthd)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon])";
            query += "VALUES (@maLoaiHoaDon,@maHoaDon,@trigiahoadon)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maLoaiHoaDon", cthd.MaLoaiHoaDon);
                    cmd.Parameters.AddWithValue("@maHoaDon", cthd.MaHD);
                    cmd.Parameters.AddWithValue("@trigiahoadon", cthd.TriGiaHoaDon);
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
        public List<ChiTietHoaDonDTO> select()
        {
            string query = string.Empty;
            query += " SELECT * ";
            query += " FROM [tblCHITIETHOADON]";



            List<ChiTietHoaDonDTO> lsctHD = new List<ChiTietHoaDonDTO>();

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
                                ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
                                cthd.MaLoaiHoaDon = int.Parse(reader["maLoaiHoaDon"].ToString());
                                cthd.MaHD = int.Parse(reader["maHoaDon"].ToString());
                                cthd.TriGiaHoaDon = float.Parse(reader["trigiahoadon"].ToString());
                                lsctHD.Add(cthd);

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
            return lsctHD;
        }
    }
}

