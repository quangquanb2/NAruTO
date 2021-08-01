using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATO.DTO;

namespace NATO.DAO
{
    public class GioHang_DAO
    {
        string cs = @"Data Source=TUAASNKHOOI\SQLEXPRESS03;Initial Catalog=test_QQ;Integrated Security=True";

        public bool themGioHang(ChiTietGioHang_DTO ctgh)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    string username = ctgh.Username;
                    string masp = ctgh.MaHang;
                    int sl = ctgh.SoLuong;

                    cmd.CommandText = "INSERT INTO CHITIETGIOHANG VALUES(@u,@m,@s)";
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@m", SqlDbType.NVarChar).Value = masp;
                    cmd.Parameters.Add("@s", SqlDbType.Int).Value = sl;

                    int eff = cmd.ExecuteNonQuery();
                    if (eff == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connect failed");
                return false;
            }
        }

        public List<ChiTietGioHang_DTO> getChiTietGioHang(string username)
        {
            List<ChiTietGioHang_DTO> ctghs = new List<ChiTietGioHang_DTO>();
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT CHITIETGIOHANG.Username, MATHANG.MaHang, MATHANG.TenHang, MoTa, Gia, SUM(CHITIETGIOHANG.SoLuong) as SoLuong, Gia * SUM(CHITIETGIOHANG.SoLuong) as ThanhTien FROM CHITIETGIOHANG, MATHANG" +
                                        " WHERE CHITIETGIOHANG.MaHang = MATHANG.MaHang AND CHITIETGIOHANG.Username = @u" + 
                                        " GROUP BY CHITIETGIOHANG.Username, MATHANG.MaHang, MATHANG.TenHang, MoTa, Gia";
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ChiTietGioHang_DTO tmp = new ChiTietGioHang_DTO();
                        tmp.MaHang = dr["MaHang"].ToString();
                        tmp.TenHang = dr["TenHang"].ToString();
                        tmp.MoTa = dr["MoTa"].ToString();
                        tmp.Gia = float.Parse(dr["Gia"].ToString());
                        tmp.SoLuong = Int16.Parse(dr["SoLuong"].ToString());

                        ctghs.Add(tmp);
                    }
                    return ctghs;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connect failed");
                return ctghs;
            }
        }
    }
}
