using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinh_dang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
            txtNhapTen.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style | FontStyle.Bold);
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
            }
            else
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style &~ FontStyle.Bold);
                label3.Font = new Font(label3.Font, label3.Font.Style & ~ FontStyle.Bold);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style | FontStyle.Italic);
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
            }
            else
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style & ~FontStyle.Italic);
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Italic);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txtNhapTen.Text;
        }

        private void redGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                txtNhapTen.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
            }
        }

        private void redRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                txtNhapTen.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                txtNhapTen.ForeColor = Color.Blue;
                label3.ForeColor = Color.Blue;
            }
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlack.Checked)
            {
                txtNhapTen.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked)
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style | FontStyle.Underline);
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
            }
            else
            {
                txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style & ~FontStyle.Underline);
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Underline);
            }
        }
    }
}
