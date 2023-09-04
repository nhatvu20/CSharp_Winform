using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapN_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (!int.TryParse(txtNhapN.Text,out num))
            {
                //MessageBox.Show("Vui lòng nhập số!");
                txtNhapN.Text = "";   
            }
        }

        private void txtNhapN_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtNhapN.Text) < 0 || Convert.ToInt32(txtNhapN.Text) >= 1000)
            {
                MessageBox.Show("Vui lòng nhập số trong khoảng 0<n<1000");
                txtNhapN.Text = "";
            }
        }

        bool chksnt(int n)
        {
            if (n < 2)
            {
                return false;
            }
            
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }   
            return true;
        }
        bool chkscp(int n)
        {
            if (n > 0)
            {
                int sqr = (int)Math.Sqrt(n);
                if (sqr * sqr == n)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
        bool chkSHC(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }
        private void btHienThi_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNhapN.Text);
            for (int i = 0; i < n; i++)
            {
                if (chksnt(i))
                {
                    lbSNT.Text = lbSNT.Text + i + " ;";
                }
                if (chkscp(i))
                {
                    lbSCP.Text = lbSCP.Text + i + " ;";
                }
                if (chkSHC(i))
                {
                    lbSHC.Text = lbSHC.Text + i + " ;";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
