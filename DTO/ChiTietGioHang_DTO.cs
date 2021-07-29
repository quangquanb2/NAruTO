using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class ChiTietGioHang_DTO
    {
        private string username;
        private string mahang;
        private string tenhang;
        private string mota;
        private float gia;
        private int soluong;

        public ChiTietGioHang_DTO()
        {
            username = "";
            mahang = "";
            soluong = 0;
            tenhang = "";
            gia = 0;
            mota = "";
        }

        public ChiTietGioHang_DTO(string username, string mahang, int soluong, string mota, string tenhang, float gia)
        {
            this.Username = username;
            this.MaHang = mahang;
            this.SoLuong = soluong;
            this.TenHang = tenhang;
            this.MoTa = mota;
            this.Gia = gia;
        }

        public string Username { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public string TenHang { get; set; }
        public string MoTa { get; set; }
        public float Gia { get; set; }
    }
}
