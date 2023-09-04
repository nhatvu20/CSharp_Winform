using quoc_ki.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quoc_ki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radVietnam_CheckedChanged(object sender, EventArgs e)
        {
            if (radVietnam.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\hoc-tap\\lap-trinh\\img\\vietnam.png");
            }
        }
        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\hoc-tap\\lap-trinh\\img\\usa.png");
            }
        }

        private void radItalia_CheckedChanged(object sender, EventArgs e)
        {
            if (radItaly.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\hoc-tap\\lap-trinh\\img\\italy.png");
            }
        }

        private void radPhilippines_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhilippines.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\hoc-tap\\lap-trinh\\img\\philippines.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
