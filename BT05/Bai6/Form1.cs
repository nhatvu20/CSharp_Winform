using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmQuocGia : Form
    {
        public frmQuocGia()
        {
            InitializeComponent();
        }

        private void rdVietNam_CheckedChanged(object sender, EventArgs e)
        {
            pnlVN.Visible = true;
            pnlUSA.Visible = false;
            pnlPhilip.Visible = false;
            pnlItalic.Visible = false;
        }

        private void rdUSA_CheckedChanged(object sender, EventArgs e)
        {
            pnlVN.Visible = false;
            pnlUSA.Visible = true;
            pnlPhilip.Visible = false;
            pnlItalic.Visible = false;
        }

        private void rdItalian_CheckedChanged(object sender, EventArgs e)
        {
            pnlVN.Visible = false;
            pnlUSA.Visible = false;
            pnlPhilip.Visible = false;
            pnlItalic.Visible = true;
        }

        private void rdPhilipinene_CheckedChanged(object sender, EventArgs e)
        {
            pnlVN.Visible = false;
            pnlUSA.Visible = false;
            pnlPhilip.Visible = true;
            pnlItalic.Visible = false;
        }
    }
}
