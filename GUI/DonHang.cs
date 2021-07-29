using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NATO.GUI
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kLMQSDataSet1.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.kLMQSDataSet1.TAIKHOAN);

        }
    }
}
