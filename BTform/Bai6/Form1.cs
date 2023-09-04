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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtChND_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCND_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;
            string chuoidai=b;
            string chuoingan=a;
            if (a.Length > b.Length)
            {
                chuoidai = a;
                chuoingan = b;
            }
            int startFind = 0;
            int count = -1;
            int index = -1;
            while (startFind != -1)
            {
                startFind = chuoidai.IndexOf(chuoingan, index + 1);
                count += 1;
                index = startFind;
            }
            txtSoLanXH.Text = string.Format("Số lần xuất hiện của chuỗi ngắn {0} trong chuỗi dài {1} là {2}",chuoingan,chuoidai, count.ToString());
            string chuoinghichdaodai = "";
            for(int i = chuoidai.Length-1; i >=0 ; i--)
            {
                chuoinghichdaodai += chuoidai[i];
            }
            txtCNDA.Text = chuoinghichdaodai;
            string chuoinghichdaongan = "";
            for (int i = chuoingan.Length - 1; i >= 0; i--)
            {
                chuoinghichdaongan += chuoingan[i];
            }
            txtCNDB.Text = chuoinghichdaongan;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void doiMauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
