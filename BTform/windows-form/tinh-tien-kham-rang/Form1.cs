using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinh_tien_kham_rang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tong = 0;
            if (chkCaoVoi.Checked)
            {
                tong = tong + 100000;
            }
            if (chkTayTrang.Checked)
            {
                tong = tong + 1200000;
            }
            if (chkChupHinh.Checked)
            {
                tong = tong + 150000;
            }
            if (chkLayCao.Checked)
            {
                tong = tong + 100000;
            }
            tong = tong + Decimal.ToInt32(soLuongHanRang.Value) * 90000;
            textBoxTongTien.Text = tong.ToString();
        }
    }
}