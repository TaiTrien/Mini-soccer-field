using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Net; 

namespace DAL_MANAGER
{
    public class csvcDAL
    {
        public bool facilities_payment(csvcDTO PAY)
        {
           
            string queryHD = string.Empty;
            queryHD += " INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon]) ";
            queryHD += " VALUES (@maHoaDon,@maNhanVien,@maKH,@ngaytaohoadon)";
            string queryLHD = string.Empty;
            queryLHD += " SELECT *";
            queryLHD += " FROM [tblLOAIHOADON] where maLoaiHoaDon=2";
            string queryCTHD = string.Empty;
            queryCTHD += " INSERT INTO [tblCHITIETHOADON] ([maHoaDon],[maLoaiHoaDon],[trigiahoadon]) ";
            queryCTHD += " VALUES (@maHoaDon,@maLoaiHoaDon,@trigiahoadon)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryHD;
                    cmd.Parameters.AddWithValue("@maHoaDon", PAY.MaHoaDon);
                    cmd.Parameters.AddWithValue("@maNhanVien", PAY.MaNhanVien);
                    cmd.Parameters.AddWithValue("@maKH", PAY.MaKH);
                    cmd.Parameters.AddWithValue("@ngaytaohoadon", PAY.NgayTaoHoaDon);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                }
            }
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryLHD;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {

                            while (reader.Read())
                            {
                                PAY.MaLoaiHoaDon = reader["MaLoaiHoaDon"].ToString();
                                PAY.LoaiHoaDon = reader["LoaiHoaDon"].ToString();
                                
                            }
                        }

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
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryCTHD;
                    cmd.Parameters.AddWithValue("@maHoaDon", PAY.MaHoaDon);
                    cmd.Parameters.AddWithValue("@maLoaiHoaDon", PAY.MaLoaiHoaDon);
                    cmd.Parameters.AddWithValue("@trigiahoadon", PAY.TriGiaHoaDon);
                    
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
        public bool add(csvcDTO CSVC,string maold)
        {
        string queryadd = string.Empty;
        queryadd += " update [tblCSVC]";
        queryadd += " set maNhanVien=@maNhanVien,tencsvc=@tencsvc,csvctot=@csvctot,csvchong=@csvchong,dongianhap=@dongianhap where maCSVC=@maold";
        using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) 
        {
            
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = queryadd;
                cmd.Parameters.AddWithValue("@maNhanVien", CSVC.MaNhanVien);
                cmd.Parameters.AddWithValue("@tencsvc", CSVC.tenCSVC);
                cmd.Parameters.AddWithValue("@csvctot", CSVC.CSVCtot);
                cmd.Parameters.AddWithValue("@csvchong", CSVC.CSVChong);
                cmd.Parameters.AddWithValue("@dongianhap", CSVC.DonGiaNhap);
                cmd.Parameters.AddWithValue("@maold", maold);
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
    
        public int CSVCTOT(string sel_item)

        {
            string val = sel_item;
            int CSVCTOT=0;
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM tblCSVC Where tencsvc = '" + val + "'";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
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
                                csvcDTO CSVC = new csvcDTO();
                                CSVC.MaCSVC = reader["MaCSVC"].ToString();
                                CSVC.tenCSVC = reader["tenCSVC"].ToString();
                                CSVC.CSVChong =int.Parse( reader["CSVChong"].ToString());
                                CSVC.CSVCtot = int.Parse(reader["CSVCtot"].ToString());
                                CSVCTOT = CSVC.CSVCtot;
                                
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return CSVCTOT;
        }
        public int CSVCHONG(string sel_item)

        {
            string val = sel_item;
            int CSVCHONG = 0;
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM tblCSVC Where tencsvc = '" + val + "'";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
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
                                csvcDTO CSVC = new csvcDTO();
                                CSVC.MaCSVC = reader["MaCSVC"].ToString();
                                CSVC.tenCSVC = reader["tenCSVC"].ToString();
                                CSVC.CSVChong = int.Parse(reader["CSVChong"].ToString());
                                CSVC.CSVCtot = int.Parse(reader["CSVCtot"].ToString());
                                CSVCHONG = CSVC.CSVChong;

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return CSVCHONG;
        }
        public List<csvcDTO> selectedCSVC()

        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM tblCSVC";

            List<csvcDTO> lscsvc = new List<csvcDTO>();

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
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
                                csvcDTO CSVC = new csvcDTO();
                                CSVC.MaCSVC = reader["MaCSVC"].ToString();
                                CSVC.tenCSVC = reader["tenCSVC"].ToString();
                                CSVC.CSVChong = int.Parse(reader["CSVChong"].ToString());
                                CSVC.CSVCtot = int.Parse(reader["CSVCtot"].ToString());
                                lscsvc.Add(CSVC);
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
            return lscsvc;
        }
        public List<csvcDTO> selectedCSVCchance(string sel_item)

        {
            string query = string.Empty;
            string val = sel_item;
            query += "SELECT * ";
            query += "FROM tblCSVC Where tencsvc = '" + val + "'";

            List<csvcDTO> lscsvc = new List<csvcDTO>();

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
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
                                csvcDTO CSVC = new csvcDTO();
                                CSVC.MaCSVC = reader["MaCSVC"].ToString();
                                CSVC.tenCSVC = reader["tenCSVC"].ToString();
                                CSVC.CSVChong = int.Parse(reader["CSVChong"].ToString());
                                CSVC.CSVCtot = int.Parse(reader["CSVCtot"].ToString());
                                lscsvc.Add(CSVC);
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
            return lscsvc;
        }
        public int autogenerate_maHOADON()
        {
            int maHoaDon = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MAHOADON) AS MM from (SELECT CONVERT(float, tblHOADON.maHoaDon) AS MAHOADON FROM tblHOADON ) AS KQ";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))
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
                                maHoaDon = int.Parse(reader["MM"].ToString()) + 1;
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
            return maHoaDon;
        }
    }
}
