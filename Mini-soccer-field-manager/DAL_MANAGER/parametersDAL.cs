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
    }
}