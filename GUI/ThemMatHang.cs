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
    public partial class ThemMatHang : Form
    {

        public ThemMatHang()
        {
            InitializeComponent();
            GetDM();
        }

        public void GetDM()
        {
            List<DanhMuc_DTO> dms = DanhMuc_BUS.Instance.getAllDanhMuc();

            Dictionary<string, string> choices = new Dictionary<string, string>();

            foreach (DanhMuc_DTO dm in dms) {
                choices[dm.MaDM] =  dm.TenDM;
            }

            cbDM.DataSource = new BindingSource(choices, null);
            cbDM.DisplayMember = "Value";
            cbDM.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatHang_DTO mh = new MatHang_DTO();

            mh.MaHang = txtMahang.Text.ToString();
            mh.TenHang = txtTenhang.Text.ToString();
            mh.SoLuong = Convert.ToInt16(txtSL.Text.ToString());
            mh.HinhAnh = "";
            mh.Gia = float.Parse(txtGia.Text.ToString());
            mh.MoTa = txtMota.Text.ToString();
            mh.MaDM = cbDM.SelectedValue.ToString();

            bool kq = MatHang_BUS.Instance.themMatHang(mh);
            if (kq == true)
            {
                MessageBox.Show("THEM THANH CONG");
            } else
            {
                MessageBox.Show("THEM THAT BAI");
            }
        }

        private void ThemMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kLMQSDataSet.MATHANG' table. You can move, or remove it, as needed.
            this.mATHANGTableAdapter.Fill(this.kLMQSDataSet.MATHANG);

        }
    }
}
