using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtA.Text.Length == 0 || txtB.Text.Length == 0)
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập trường này!");
                btnGiai.Enabled = false;
                errorProvider2.SetError(txtB, "Vui lòng nhập trường này!");
                btnXoa.Enabled = false;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;
            double num = 0;
            if (double.TryParse(a, out num)&&double.TryParse(b,out num))
            {
                btnGiai.Enabled = true;
                btnXoa.Enabled = true;
            }else
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số!");
                btnGiai.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {    
            DialogResult result = MessageBox.Show("Bạn có muốn thóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;
            double num = 0;
            if (double.TryParse(a, out num)&&double.TryParse(b,out num))
            {
                btnGiai.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                errorProvider2.SetError(txtB,"Vui lòng nhập số");
                btnXoa.Enabled = false;
                btnGiai.Enabled = false;
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (a == 0)
            {
                if (b != 0)
                {
                    txtN0.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    txtN0.Text = "Phương trình vô số nghiệm";
                }
            }else
            {
                txtN0.Text = (-b / a).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtN0.Text = "";
            txtA.Focus();
        }
    }
}
