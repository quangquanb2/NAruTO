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
    public struct MyStruct{
        public MyStruct(string tensp, string chitiet, string tendm, float gia, string masp, string username)
        {
            this.Username = username;
            this.TenSP = tensp;
            this.MaSP = masp; 
            this.ChiTiet = chitiet;
            this.TenDM = tendm;
            this.Gia = gia.ToString();
        }

        public string TenSP { get; set; }
        public string ChiTiet { get; set; }
        public string TenDM { get; set; }
        public string Gia { get; set; }
        public string MaSP { get; set; }
        public string Username { get; set; }
    }

    public partial class HomePage : Form
    {
        public HomePage(string username)
        {
            InitializeComponent();
            lbUsername.Text = username;
            loadDanhMuc();
            popularItems("ALL");
            someSetUp(username);
        }

        public void someSetUp(string username)
        {
            bool isad = TaiKhoan_BUS.Instance.isAdmin(username);
            if (isad == false)
            {
                button2.Hide();
                button3.Hide();
                button7.Hide();
            }
        }

        private void loadDanhMuc()
        {
            List<DanhMuc_DTO> li = DanhMuc_BUS.Instance.getAllDanhMuc();
            Dictionary<string, string> dms = new Dictionary<string, string>();
            dms["ALL"] = "Tất cả";
            foreach (DanhMuc_DTO dm in li)
            {
                dms[dm.MaDM] = dm.TenDM;
            }

            cbDanhMuc.DataSource = new BindingSource(dms, null);
            cbDanhMuc.DisplayMember = "Value";
            cbDanhMuc.ValueMember = "Key";
        }

        private void HienThi(List<MatHang_DTO> li)
        {
            int count = li.Count;
            ListItem[] listItems = new ListItem[count];
            MyStruct[] myst = new MyStruct[count];

            int i = 0;
            foreach (MatHang_DTO mh in li)
            {
                myst[i] = new MyStruct();
                myst[i].TenSP = mh.TenHang;
                myst[i].ChiTiet = mh.MoTa;
                myst[i].TenDM = mh.MaDM;
                myst[i].Gia = mh.Gia.ToString();
                myst[i].MaSP = mh.MaHang;
                myst[i].Username = lbUsername.Text.ToString();
                i++;
            }

            for (int j = 0; j < count; j++)
            {
                listItems[j] = new ListItem();
                listItems[j].TenSP = myst[j].TenSP;
                listItems[j].TenDM = myst[j].TenDM;
                listItems[j].ChiTiet = myst[j].ChiTiet;
                listItems[j].Gia = myst[j].Gia;
                listItems[j].MaSP = myst[j].MaSP;
                listItems[j].Username = myst[j].Username;

                flowLayoutPanel1.Controls.Add(listItems[j]);
            }
        }

        private void popularItems(string mdm)
        {
            flowLayoutPanel1.Controls.Clear();
            List<MatHang_DTO> li = new List<MatHang_DTO>();
            if (mdm.Equals("ALL"))
            {
                li = MatHang_BUS.Instance.getAllMatHang();
            }
            else
            {
                li = MatHang_BUS.Instance.getMHbyDM(mdm);
            }
            HienThi(li);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalInformation pi = new PersonalInformation(lbUsername.Text.ToString());
            pi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDanhMuc tmd = new ThemDanhMuc();
            tmd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemMatHang tmh = new ThemMatHang();
            tmh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dm = cbDanhMuc.SelectedValue.ToString();
            popularItems(dm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát ứng dụng?", "THOÁT ỨNG DỤNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuanTriTaiKhoan qttk = new QuanTriTaiKhoan();
            qttk.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<MatHang_DTO> li = new List<MatHang_DTO>();
            li = MatHang_BUS.Instance.searchMatHang(txtSearch.Text.ToString());
            HienThi(li);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(lbUsername.Text.ToString());
            gh.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.ShowDialog();
        }
    }
}
