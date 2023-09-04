using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cong_CheckedChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) + Convert.ToDouble(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void tru_CheckedChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) - Convert.ToDouble(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void nhan_CheckedChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) * Convert.ToDouble(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void chia_CheckedChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) / Convert.ToDouble(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            string a = txtSo1.Text;
            string b = txtSo2.Text;
            double num = 0;
            if (!double.TryParse(a, out num))
            {
                errorProvider1.SetError(txtSo1, "Vui lòng nhập số!!!");
                //MessageBox.Show("Vui lòng nhập số!!!");
                txtSo1.Text = "";
            }
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            string a = txtSo1.Text;
            string b = txtSo2.Text;
            double num = 0;
            if (!double.TryParse(b, out num))
            {
                errorProvider2.SetError(txtSo2, "Vui lòng nhập số!!!");
                //MessageBox.Show("Vui lòng nhập số!!!");
                txtSo2.Text = "";
            }
        }
    }
}
