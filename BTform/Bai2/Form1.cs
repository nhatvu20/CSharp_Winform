using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Bảng thông báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            int tong = 0;
            if (chkcaovoi.Checked == true)
            {
                tong += 100000;
            }
            if (chkTaytrang.Checked == true)
            {
                tong += 1200000;
            }
            if (chkChupHinh.Checked == true)
            {
                tong += 150000;
            }
            if (chkLayCao.Checked == true)
            {
                tong += 100000;
            }
            tong += ((int)numericUpDown1.Value * 90000);
            txtTongTien.Text = tong.ToString();
        }
    }
}
