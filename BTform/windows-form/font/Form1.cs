using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourierNew.Checked)
            {
                Font myFont = new Font("Courier New", 12.0f);
                textBox1.Font = myFont;
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma.Checked)
            {
                Font myFont = new Font("Tahoma", 12.0f);
                textBox1.Font = myFont;
            }
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked)
            {
                Font myFont = new Font("Arial", 12.0f);
                textBox1.Font = myFont;
            }
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimesNewRoman.Checked)
            {
                Font myFont = new Font("Times New Roman", 12.0f);
                textBox1.Font = myFont;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
