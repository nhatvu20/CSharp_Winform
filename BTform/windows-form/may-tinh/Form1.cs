using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace may_tinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool isNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void cong_CheckedChanged(object sender, EventArgs e)
        {           
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            textBox3.Text = (a + b).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isNumber(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Nhập sai định dạng!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!isNumber(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Nhập sai định dạng!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void tru_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void nhan_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }

        private void chia_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            textBox3.Text = (a / b).ToString();
        }
    }
}
