using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
        }

        private void rdArial_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void rdCounrierNew_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Courier New", 20F);
        }
    }
}
