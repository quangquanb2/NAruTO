using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NATO.DAO;
using NATO.DTO;
using NATO.BUS;

namespace NATO.GUI
{
    public partial class test : Form
    {

        public test()
        {
            InitializeComponent();

            /*List<DanhMuc_DTO> dms = DanhMuc_BUS.Instance.getAllDanhMuc();

            Dictionary<string, string> choices = new Dictionary<string, string>();

            foreach (DanhMuc_DTO dm in dms)
            {
                choices[dm.MaDM] = dm.TenDM;
            }

            comboBox1.DataSource = new BindingSource(choices, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";*/
            comboBox1.SelectedItem = "Les";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tr = comboBox1.SelectedValue.ToString();
            MessageBox.Show(tr);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
