using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_RapChieuPhim_DeThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenPhim.Text = comboBox1.Text;
        }
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.FromArgb(0, 192, 0))
            {
                if (btn.Text.Contains("A"))
                {
                    sum += 25000;
                }
                else if (btn.Text.Contains("B"))
                {
                    sum += 30000;
                }
                else if (btn.Text.Contains("C"))
                {
                    sum += 35000;
                }
                else if (btn.Text.Contains("D"))
                {
                    sum += 40000;
                }else if(btn.Text.Contains("E")){
                    sum+=50000;
                }
                else if (btn.Text.Contains("F"))
                {
                    sum+=45000;
                }
                btn.BackColor = Color.FromArgb(0, 192, 0);
                //btn.Enabled = false;
            }
            else
            {
                if (btn.Text.Contains("A"))
                {
                    sum -= 25000;
                    btn.BackColor = Color.FromArgb(192, 255, 255);
                }
                else if (btn.Text.Contains("B"))
                {
                    sum -= 30000;
                    btn.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (btn.Text.Contains("C"))
                {
                    sum -= 35000;
                    btn.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (btn.Text.Contains("D"))
                {
                    sum -= 40000;
                    btn.BackColor = Color.FromArgb(255, 255, 192);
                }
                else if (btn.Text.Contains("E"))
                {
                    sum -= 50000;
                    btn.BackColor = Color.FromArgb(255, 192, 192);
                }
                else if (btn.Text.Contains("F"))
                {
                    sum -= 45000;
                    btn.BackColor = Color.FromArgb(255, 224, 192);
                }
                //btn.Enabled = true;
            }
            lbThanhTien.Text = sum.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có muốn thanh toán không","Thông báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (Button item in tableLayoutPanel1.Controls)
                {
                    if (item.BackColor == Color.FromArgb(0, 192, 0))
                    {
                        item.BackColor = Color.Red;
                        item.Enabled = false;
                    }
                }
                lbThanhTien.Text = "0";
            }
        }
    }
}
