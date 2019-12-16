using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO_MANAGER;

namespace DAL_MANAGER
{
    public class parametersDAL
    {
        private parametersDTO para;
        public parametersDTO selectedRegulations() // to select whole of regulations from THAMSO table
        {
            string query = string.Empty; // select from thamso
            query += "SELECT * ";
            query += "FROM tblTHAMSO";

            para = new parametersDTO();

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
                                para.LuongNhanVien = float.Parse(reader["luongnhanvien"].ToString());
                                para.GiaCoc = float.Parse(reader["sotiencoc"].ToString());
                                para.GiaSanNgay = float.Parse(reader["giasanngay"].ToString());
                                para.GiaSanDem = float.Parse(reader["giasandem"].ToString());
                                para.GiaGiuXe = float.Parse(reader["tiengiuxe"].ToString());
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
            return para;
        }
        public List<drinksDTO> selectDrinks()
        {
            string query = string.Empty;
            query += "SELECT maDoUong, dongianhap, dongiaban ";
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
                                drinks.DonGiaMua = Convert.ToInt32(reader["dongianhap"]);
                                drinks.DonGiaBan = Convert.ToInt32(reader["dongiaban"]);
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
        public bool updateDrinks(List<drinksDTO> drinks)
        {
            for (int i = 0; i < drinks.Count; i++)
            {
                string query = string.Empty;
                query += "UPDATE tblDOUONG SET dongianhap = @dgn, dongiaban = @dgb ";
                query += "WHERE maDoUong = @maDoUong";

                using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) //Init connection to host
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;

                        cmd.Parameters.AddWithValue("@maDoUong", drinks[i].MaDoUong);
                        cmd.Parameters.AddWithValue("@dgn", drinks[i].DonGiaMua);
                        cmd.Parameters.AddWithValue("@dgb", drinks[i].DonGiaBan);

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
            }
            return true;

        }
        public bool updatePrice(parametersDTO pr)
        {
          
                string query = string.Empty;
                query += "UPDATE tblTHAMSO ";
                query += "SET luongnhanvien = @lnv, tiengiuxe = @tgx, giasanngay = @gsn, ";
                query += "giasandem = @gsd, sotiencoc = @stc";

                using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) //Init connection to host
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@lnv", pr.LuongNhanVien);
                        cmd.Parameters.AddWithValue("@tgx", pr.GiaGiuXe);
                        cmd.Parameters.AddWithValue("@gsn", pr.GiaSanNgay);
                        cmd.Parameters.AddWithValue("@gsd", pr.GiaSanDem);
                        cmd.Parameters.AddWithValue("@stc", pr.GiaCoc);

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
    }
}