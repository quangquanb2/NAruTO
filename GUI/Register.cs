using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NATO.BUS;
using NATO.DTO;

namespace NATO.GUI
{
    public partial class Register : Form
    {
        public List<string> QT = new List<string>() {
            "Việt Nam",
            "Hàn Quốc",
            "Mỹ",
            "Trung Quốc",
            "Nga",
            "Triều Tiên",
            "Đức",
            "Nhật"
        };

        public Register()
        {
            InitializeComponent();
            cbQT.DataSource = new BindingSource(QT, null);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string hoten = txtHoten.Text.ToString();
            string mk = txtPassword.Text.ToString();
            string email = txtEmail.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            string diachi = txtDC.Text.ToString();
            string quoctich = cbQT.SelectedItem.ToString();
            string gt = cbGT.SelectedItem.ToString();

            bool kq = Register_BUS.Instance.register(username, hoten, mk, email, sdt, gt, diachi, quoctich);
            string mss = kq == true ? "Đăng ký Thành Công" : "Đăng ký Fail";
            MessageBox.Show(mss);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
