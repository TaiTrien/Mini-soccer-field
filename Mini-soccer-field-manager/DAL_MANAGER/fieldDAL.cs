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
    public class fieldDAL
    {
        public List<fieldDTO> selectedFields()
        {
            string query = string.Empty;
            query += "SELECT tblCHITIETDATSAN.maPhieuDatSan, maSan, ngayDat, gioDat, thoiLuong, tblKHACHHANG.tenKH ";
            query += "FROM tblCHITIETDATSAN, tblPHIEUDATSAN, tblKHACHHANG ";
            query += "WHERE tblCHITIETDATSAN.maPhieuDatSan = tblPHIEUDATSAN.maPhieuDatSan " +
                "and tblKHACHHANG.maKH = tblPHIEUDATSAN.maKH";

            List<fieldDTO> lstFields = new List<fieldDTO>();

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
                                fieldDTO field = new fieldDTO();
                                field.MaSanBanh = reader["maSan"].ToString();
                                field.ThoiLuongDatSan = float.Parse(reader["thoiLuong"].ToString());
                                field.tenKH = reader["tenKH"].ToString();
                                lstFields.Add(field);
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
            return lstFields;
        }
    }
}
