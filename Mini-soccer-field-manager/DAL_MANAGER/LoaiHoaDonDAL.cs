using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO_MANAGER;
using System.Configuration;
namespace DAL_MANAGER
{
    public class LoaiHoaDonDAL
    {
 
            private string connectionString;

            public LoaiHoaDonDAL()
            {
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            }
            public string ConnectionString { get => connectionString; set => connectionString = value; }
            
            
            public List<LoaiHoaDonDTO> select()
            {
                string query = string.Empty;
                query += " SELECT * ";
                query += " FROM [tblLOAIHOADON]";
             


                List<LoaiHoaDonDTO> lsloaiHD = new List<LoaiHoaDonDTO>();

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
                                    LoaiHoaDonDTO lhd = new LoaiHoaDonDTO();
                                    lhd.MaLoaiHoaDon = int.Parse(reader["maLoaiHoaDon"].ToString());
                                    lhd.TenLoaiHoaDon = reader["loaihoadon"].ToString();
                                    lsloaiHD.Add(lhd);

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
                return lsloaiHD;
            }
    }
}

