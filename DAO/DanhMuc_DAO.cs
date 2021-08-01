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
    public class DanhMuc_DAO
    {
        public static DanhMuc_DAO instance;
        public static DanhMuc_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMuc_DAO();
                return instance;
            }
        }

        string cs = @"Data Source=TUAASNKHOOI\SQLEXPRESS03;Initial Catalog=test_QQ;Integrated Security=True";

        public List<DanhMuc_DTO> getAllDanhMuc()
        {
            List<DanhMuc_DTO> dms = new List<DanhMuc_DTO>();
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT * FROM DANHMUC ORDER BY MaDanhMuc";

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        DanhMuc_DTO dm = new DanhMuc_DTO();
                        dm.MaDM = rdr["MaDanhMuc"].ToString();
                        dm.TenDM = rdr["TenDanhMuc"].ToString();
                        dm.MoTa = rdr["MoTa"].ToString();

                        dms.Add(dm);
                    }
                    return dms;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connect failed");
                return null;
            }
        }

        public bool themDanhMuc(DanhMuc_DTO dm)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    string madm = dm.MaDM;
                    string tendm = dm.TenDM;
                    string mota = dm.MoTa;

                    cmd.CommandText = "INSERT INTO DANHMUC VALUES(@m,@t,@mt)";
                    cmd.Parameters.Add("@m", SqlDbType.NVarChar).Value = madm;
                    cmd.Parameters.Add("@t", SqlDbType.NVarChar).Value = tendm;
                    cmd.Parameters.Add("@mt", SqlDbType.NVarChar).Value = mota;

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

        public DanhMuc_DTO getDanhMucByMaDM(string maDM)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM DANHMUC WHERE MaDanhMuc = @mdm";
                    cmd.Parameters.Add("@mdm", SqlDbType.NVarChar).Value = maDM;
                    SqlDataReader drd = cmd.ExecuteReader();

                    while (drd.Read())
                    {
                        DanhMuc_DTO dm = new DanhMuc_DTO();
                        dm.MaDM = drd["MaDanhMuc"].ToString();
                        dm.TenDM = drd["TenDanhMuc"].ToString();
                        dm.MoTa = drd["MoTa"].ToString();

                        return dm;
                    }
                    return null;
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        
    }

    
}
