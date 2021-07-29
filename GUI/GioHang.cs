using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NATO.DTO;
using NATO.BUS;

namespace NATO.GUI
{
    public partial class GioHang : Form
    {
        public struct MyGH
        {
            public MyGH(string username, string tensp, string masp, string chitiet, float gia, int soluong, float thanhtien)
            {
                this.Username = username;
                this.TenSP = tensp;
                this.MaSP = masp;
                this.ChiTiet = chitiet;
                this.Gia = gia;
                this.SoLuong = soluong;
                this.ThanhTien = thanhtien;
            }

            public string TenSP { get; set; }
            public string ChiTiet { get; set; }
            public float Gia { get; set; }
            public string MaSP { get; set; }
            public string Username { get; set; }
            public int SoLuong { get; set; }
            public float ThanhTien { get; set; }
        }

        public GioHang(string username)
        {
            InitializeComponent();
            loadGio(username);
        }

        public void loadGio(string username)
        {
            List<ChiTietGioHang_DTO> ctghs = GioHang_BUS.Instance.getChiTietGioHang(username);
            int count = ctghs.Count;
            MyGH[] mygh = new MyGH[count];

            int i = 0;
            foreach (ChiTietGioHang_DTO ct in ctghs)
            {
                mygh[i].Username = username;
                mygh[i].MaSP = ct.MaHang;
                mygh[i].TenSP = ct.TenHang;
                mygh[i].ChiTiet = ct.MoTa;
                mygh[i].Gia = ct.Gia;
                mygh[i].SoLuong = ct.SoLuong;
                mygh[i].ThanhTien = (ct.Gia * ct.SoLuong);
                i++;
            }

            
            ListItemGioHang[] listItems = new ListItemGioHang[count];
            for (int j=0; j<count; j++)
            {
                listItems[j] = new ListItemGioHang();
                listItems[j].Username = username;
                listItems[j].MaSP = mygh[j].MaSP;
                listItems[j].TenSP = mygh[j].TenSP;
                listItems[j].MoTa = mygh[j].ChiTiet;
                listItems[j].Gia = mygh[j].Gia;
                listItems[j].SoLuong = mygh[j].SoLuong;

                flowLayoutPanel1.Controls.Add(listItems[j]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
