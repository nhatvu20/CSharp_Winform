using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txtNhapten.Text = "Thần công";
            //lbLapTrinh.Text = "Thần công";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged_1(object sender, EventArgs e)
        {
            lbLapTrinh.Text = txtNhapten.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radRed.ForeColor;
            lbLapTrinh.ForeColor = radRed.ForeColor;
        }

        private void radBlack_Click(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radBlack.ForeColor;
            lbLapTrinh.ForeColor = radBlack.ForeColor;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Bold);
            lbLapTrinh.Font = new Font(lbLapTrinh.Font, FontStyle.Bold);
            //chkItalic.Checked = false;
            //chkUnder.Checked = false;            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Underline);
            lbLapTrinh.Font = new Font(lbLapTrinh.Font, FontStyle.Underline);
            //chkBold.Checked = false;
            //chkItalic.Checked = false;
            if (chkBold.Checked == true && chkItalic.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            }
            else if (chkUnder.Checked == true && chkBold.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold))));

            }
            else if (chkUnder.Checked == true && chkItalic.Checked == true && chkBold.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
            }
        }

        private void chkItalic_Click(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Italic);
            lbLapTrinh.Font = new Font(lbLapTrinh.Font, FontStyle.Italic);
            if (chkBold.Checked == true&& chkItalic.Checked==true) {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            }else if(chkUnder.Checked == true && chkItalic.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic))));

            }else if(chkUnder.Checked == true && chkItalic.Checked == true&&chkBold.Checked==true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
            }
            //chkBold.Checked = false;
            //chkUnder.Checked = false;
        }

        private void chkUnder_Click(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Underline);
            lbLapTrinh.Font = new Font(lbLapTrinh.Font, FontStyle.Underline);
            //chkBold.Checked = false;
            //chkItalic.Checked = false;
            if (chkUnder.Checked == true && chkItalic.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic))));
            }
            else if (chkUnder.Checked == true && chkBold.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold))));

            }
            else if (chkUnder.Checked == true && chkItalic.Checked == true && chkBold.Checked == true)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
                lbLapTrinh.Font = new Font(lbLapTrinh.Font, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))));
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radGreen.ForeColor;
            lbLapTrinh.ForeColor = radGreen.ForeColor;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radBlue.ForeColor;
            lbLapTrinh.ForeColor = radBlue.ForeColor;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radBlack.ForeColor;
            lbLapTrinh.ForeColor = radBlack.ForeColor;
        }
    }
}
