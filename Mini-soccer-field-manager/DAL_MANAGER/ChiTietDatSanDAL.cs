using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class ChiTietDatSanDAL
    {
        private string connectionString;

        public ChiTietDatSanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool themchitietdatsan(ChiTietDatSanDTO ct)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblCHITIETDATSAN] ([maPhieuDatSan], [maSan],[ngayDat],[gioDat],[thoiLuong])";
            query += "VALUES (@maPhieuDatSan,@maSan,@ngayDat,@gioDat,@thoiLuong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhieuDatSan", ct.MaPhieuDatSan);
                    cmd.Parameters.AddWithValue("@maSan", ct.MaSan);
                    cmd.Parameters.AddWithValue("@ngayDat", ct.NgayDat.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@gioDat", ct.GioDat.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@thoiLuong", ct.ThoiLuong.ToString("HH:mm"));


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

        public bool huychitietdatsan(ChiTietDatSanDTO ct)
        {
            string query = string.Empty;
            query += "delete from [tblCHITIETDATSAN]";
            query += "where maPhieuDatSan=@maPhieuDatSan and maSan=@maSan and ngayDat=@ngayDat and thoiLuong=@thoiLuong and gioDat=@gioDat";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhieuDatSan", ct.MaPhieuDatSan);
                    cmd.Parameters.AddWithValue("@maSan", ct.MaSan);
                    cmd.Parameters.AddWithValue("@ngayDat", ct.NgayDat.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@thoiLuong", ct.ThoiLuong.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@gioDat", ct.GioDat.ToString("HH:mm"));
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

                return true;
            }
        }
        public List<ChiTietDatSanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maPhieuDatSan], [maSan],[ngayDat],[gioDat],[thoiLuong]";
            query += "FROM [tblCHITIETDATSAN]";

            List<ChiTietDatSanDTO> lsCTDatSan = new List<ChiTietDatSanDTO>();

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
                                ChiTietDatSanDTO ct = new ChiTietDatSanDTO();
                                ct.MaPhieuDatSan = int.Parse(reader["maPhieuDatSan"].ToString());    
                                ct.MaSan = int.Parse(reader["maSan"].ToString());
                                ct.NgayDat = DateTime.Parse(reader["ngayDat"].ToString());
                                ct.GioDat = DateTime.Parse(reader["gioDat"].ToString());
                                ct.ThoiLuong = DateTime.Parse(reader["thoiLuong"].ToString());
                                lsCTDatSan.Add(ct);
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
            return lsCTDatSan;
        }
    }
}
