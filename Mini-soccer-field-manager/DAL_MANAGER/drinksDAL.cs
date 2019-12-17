using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Threading.Tasks;
using DTO_MANAGER;
using System.Diagnostics;

namespace DAL_MANAGER
{
    public class drinksDAL
    {
        static void main()
        {
        }
        private string connectionString;
        public drinksDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool addDrinksToBill(HoaDonDTO hoaDon, ChiTietHoaDonDTO chiTietHoaDon)
        {
            string queryHoaDon = string.Empty;
            queryHoaDon += "insert into tblHOADON (maHoaDon, maNhanvien, maKH, ngaytaohoadon) ";
            queryHoaDon += "values (@maHoaDon, @maNhanvien, @maKH, @ngaytaohoadon)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryHoaDon;
                    cmd.Parameters.AddWithValue("@maHoaDon", hoaDon.maHD);
                    cmd.Parameters.AddWithValue("@maNhanvien", hoaDon.maNhanVien);
                    cmd.Parameters.AddWithValue("@maKH",hoaDon.MaKH);
                    cmd.Parameters.AddWithValue("@ngaytaohoadon", hoaDon.NgayTaoHoaDon);
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
            string queryCTHD = string.Empty;
            queryCTHD += "insert into tblCHITIETHOADON (maLoaiHoaDon, maHoaDon, trigiahoadon) ";
            queryCTHD += "values (@maLoaiHoaDon, @maHoaDon, @trigiahoadon)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryCTHD;
                    cmd.Parameters.AddWithValue("@maLoaiHoaDon", chiTietHoaDon.MaLoaiHoaDon);
                    cmd.Parameters.AddWithValue("@maHoaDon", chiTietHoaDon.MaHD);
                    cmd.Parameters.AddWithValue("@trigiahoadon", chiTietHoaDon.TriGiaHoaDon);
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
        public bool update(drinksDTO drinks)
        {
            string query = string.Empty;
            query += "UPDATE tblDOUONG SET soluongconlai = @soluongconlai ";
            query += "WHERE maDoUong = @maDoUong";

            using (SqlConnection con = new SqlConnection(/*@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"*/)) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@maDoUong", drinks.MaDoUong);
                    cmd.Parameters.AddWithValue("@soluongconlai", drinks.DoUongConLai);
                    
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
        public drinksDTO selectPrice(int maNuoc)
        {
            string query = string.Empty;
            query += "SELECT dongiaban ";
            query += "FROM tblDOUONG WHERE maDoUong = @mdu";

           drinksDTO Drink = new drinksDTO();


            using (SqlConnection con = new SqlConnection(/*ConnectionString*/@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;"))

            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Parameters.AddWithValue("@mdu", maNuoc);
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
                                
                                //drinks.TenDoUong = reader["tendouong"].ToString();
                                 Drink.DonGiaBan = float.Parse(reader["dongiaban"].ToString());
                                //drinks.DonGiaMua = Convert.ToInt32(reader["dongianhap"]);
                                //drinks.DonGiaBan = Convert.ToInt32(reader["dongiaban"]);
                                //drinks.NgayHoaDon = reader.GetFieldValue<DateTime>(reader.GetOrdinal("ngaytaohoadon"));
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
            return Drink;
        }
        public List<drinksDTO> selectDrinks()
        {
            string query = string.Empty;
            query += "SELECT maDoUong, soluongconlai, dongianhap ";
            query += "FROM tblDOUONG ";

            List<drinksDTO> lsDrinks = new List<drinksDTO>();

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
                                drinksDTO drinks = new drinksDTO();
                                drinks.MaDoUong = reader["MaDoUong"].ToString();
                                //drinks.TenDoUong = reader["tendouong"].ToString();
                                drinks.DoUongConLai = Convert.ToInt32(reader["soluongconlai"]);
                                drinks.DonGiaMua = Convert.ToInt32(reader["dongianhap"]);
                                //drinks.DonGiaBan = Convert.ToInt32(reader["dongiaban"]);
                                //drinks.NgayHoaDon = reader.GetFieldValue<DateTime>(reader.GetOrdinal("ngaytaohoadon"));
                                lsDrinks.Add(drinks);
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
            return lsDrinks;
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
