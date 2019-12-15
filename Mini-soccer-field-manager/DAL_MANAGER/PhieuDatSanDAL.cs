using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class PhieuDatSanDAL
    {
        private string connectionString;

        public PhieuDatSanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool datsan(PhieuDatSanDTO pds)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH])";
            query += "VALUES (@maPhieuDatSan,@maNhanVien,@maKH)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhieuDatSan", pds.MaPhieuDatSan);
                    cmd.Parameters.AddWithValue("@maNhanVien", pds.MaNhanVien);
                    cmd.Parameters.AddWithValue("@maKH", pds.MaKH);


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
        public bool huysan(PhieuDatSanDTO pds)
        {
            string query = string.Empty;
            query += "delete from [tblPHIEUDATSAN]";
            query += "where maPhieuDatSan=@maPhieuDatSan";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhieuDatSan", pds.MaPhieuDatSan);
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
        public List<PhieuDatSanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maPhieuDatSan], [maNhanVien],[maKH]";
            query += "FROM [tblPHIEUDATSAN]";

            List<PhieuDatSanDTO> lsPhieuDatSan = new List<PhieuDatSanDTO>();

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
                                PhieuDatSanDTO pds = new PhieuDatSanDTO();
                                pds.MaPhieuDatSan = int.Parse(reader["maPhieuDatSan"].ToString());
                                pds.MaNhanVien = int.Parse(reader["maNhanVien"].ToString());
                                pds.MaKH= int.Parse(reader["maKH"].ToString());
                                lsPhieuDatSan.Add(pds);
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
            return lsPhieuDatSan;
        }
        public int autogenerate_maPDS()
        {
            int maPDS = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MAPDS) AS MM from (SELECT CONVERT(float, tblPHIEUDATSAN.maPhieuDATSAN) AS MAPDS FROM tblPHIEUDATSAN ) AS KQ";

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
                                maPDS = int.Parse(reader["MM"].ToString())+1;
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
            return maPDS;
        }
    }
    
}
