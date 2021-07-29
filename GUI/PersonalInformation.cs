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
    public partial class PersonalInformation : Form
    {
        public static List<string> QT = new List<string>() {
            "Việt Nam",
            "Hàn Quốc",
            "Mỹ",
            "Trung Quốc",
            "Nga",
            "Triều Tiên",
            "Đức",
            "Nhật"
        };

        public PersonalInformation(string username)
        {
            InitializeComponent();
            TaiKhoan_DTO tk = TaiKhoan_BUS.Instance.getTaiKhoan(username);
            Load_Information(tk);
        }

        private void Load_Information(TaiKhoan_DTO tk)
        {
            lblUsername.Text = tk.Username;
            txtHoten.Text = tk.HoTen;
            txtEmail.Text = tk.Email;
            txtDiachi.Text = tk.DiaChi;
            txtSDT.Text = tk.SDT;
            cbGT.SelectedItem = tk.GT == false ? "Nam" : "Nữ";
            cbQT.DataSource = new BindingSource(QT, null);
            cbQT.SelectedItem = tk.QuocTich;
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Username = lblUsername.Text.ToString();
            tk.HoTen = txtHoten.Text.ToString();
            tk.Email = txtEmail.Text.ToString();
            tk.DiaChi = txtDiachi.Text.ToString();
            tk.SDT = txtSDT.Text.ToString();
            tk.GT = cbGT.SelectedItem.ToString() == "Nam" ? false : true;
            tk.QuocTich = cbQT.SelectedItem.ToString();

            bool kq = TaiKhoan_BUS.Instance.updateTaiKhoan(tk);
            if (kq == true)
            {
                MessageBox.Show("Update tài khoản thành công");
            } else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
