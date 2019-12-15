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
        public drinksDAL()
        {
        }

        public bool update(drinksDTO drinks)
        {
            string query = string.Empty;
            query += "UPDATE tblDOUONG SET soluongconlai = @soluongconlai ";
            query += "WHERE maDoUong = @maDoUong";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=QLSB;")) //Init connection to host
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

        public List<drinksDTO> selectDrinks()
        {
            string query = string.Empty;
            query += "SELECT maDoUong, soluongconlai ";
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
                                //drinks.DonGiaMua = Convert.ToInt32(reader["dongianhap"]);
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
    }
}
