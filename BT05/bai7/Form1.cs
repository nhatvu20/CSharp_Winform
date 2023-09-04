using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //errorProvider1.SetError(textBox1,"Lỗi r bạn");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Nhập số vào đi bạn ơi!!!");
                comboBox1.Text = "";
                comboBox1.Focus();
            }
            else
            {
                comboBox1.Items.Add(textBox1.Text);
                comboBox1.Text = "";
                comboBox1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            int n = Convert.ToInt32(comboBox1.Text);
            listBox1.Items.Clear();
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnTongUS_Click(object sender, EventArgs e)
        {
            int tongUS = 0;
            foreach(int item in listBox1.Items)
            {
                tongUS += item;
            }
            MessageBox.Show("Tổng ước số là: "+tongUS);
        }

        private void btnCacUocSoChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int item in listBox1.Items)
            {
                if (item % 2 == 0)
                    dem += 1;
            }
            MessageBox.Show("Có số ước số chẵn là: " + dem);
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
            //if (n <= 1)
            //{
            //    return false;
            //}
            //else if (n == 2)
            //{
            //    return true;
            //}
            //else if (n > 2)
            //{
            //    for(int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return true;
        }
        private void btnCacUocSNT_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int item in listBox1.Items)
            {
                if(chksnt(item))
                    dem += 1;
            }
            MessageBox.Show("Có " + dem + " số là ước số nguyên tố là:");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Bảng thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
