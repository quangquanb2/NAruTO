using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NATO.DTO;
using NATO.BUS;
using NATO.DAO;

namespace NATO.GUI
{
    public partial class ThemMatHang : Form
    {

        public ThemMatHang()
        {
            InitializeComponent();
            GetDM();
            loadDataGridView();
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
                loadDataGridView();
            } else
            {
                MessageBox.Show("THEM THAT BAI");
            }
        }

        private void ThemMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kLMQSDataSet.MATHANG' table. You can move, or remove it, as needed.
            // this.mATHANGTableAdapter.Fill(this.kLMQSDataSet.MATHANG);     
            loadDataGridView();
        }

        public void loadDataGridView()
        {
            List<MatHang_DTO> ds = new List<MatHang_DTO>();
            ds = MatHang_BUS.Instance.getAllMatHang();
            dataGridView2.DataSource = ds;
        }
        
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int VT = dataGridView2.CurrentCell.RowIndex;
            if (VT != 0)
            {
                loadDataForUpdate(VT);
                btn_CapNhat.Enabled = true;
            }
        }

        private void loadDataForUpdate(int i)
        {
            string tenMH = dataGridView2.Rows[i].Cells[0].Value.ToString().Trim();
            MatHang_DTO mh = new MatHang_DTO();
            mh = MatHang_BUS.instance.getMHbyMaMH(tenMH);
            int indexOfDanhMuc = DanhMuc_BUS.instance.getIndexOfDanhMuc(mh.MaDM);

            txtGia.Text = mh.Gia.ToString();
            txtTenhang.Text = mh.TenHang;
            txtMota.Text = mh.MoTa;
            txtMahang.Text = mh.MaHang;
            txtSL.Text = mh.SoLuong.ToString();
            cbDM.SelectedIndex = indexOfDanhMuc;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            MatHang_DTO mh = new MatHang_DTO();

            mh.MaHang = txtMahang.Text.ToString();
            mh.TenHang = txtTenhang.Text.ToString();
            mh.SoLuong = Convert.ToInt16(txtSL.Text.ToString());
            mh.HinhAnh = "";
            mh.Gia = float.Parse(txtGia.Text.ToString());
            mh.MoTa = txtMota.Text.ToString();
            mh.MaDM = cbDM.SelectedValue.ToString();

            if (MatHang_BUS.Instance.capNhatMH(mh.MaHang, mh))
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
            loadDataGridView();
        }
    }
}
