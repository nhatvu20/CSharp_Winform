using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Meny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
            }
        }

        private void backImgageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFDlg = new OpenFileDialog();
            if (openFDlg.ShowDialog() == DialogResult.OK)
            {
                // this.BackgroundImage = System.Drawing.Image.FromFile("yourfile.jpg");
                this.BackgroundImage = Image.FromFile(openFDlg.FileName);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fdlg = new FontDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.Font = fdlg.Font;
                menuStrip2.Font = fdlg.Font;
            }
        }
    }
}
