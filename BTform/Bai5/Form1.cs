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

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            int num = 0;
            if(int.TryParse(txtbox.Text,out num) && txtbox.Text.Length != 0)
            {
                //MessageBox.Show("OK");
            }

            else if (txtbox.Text.Length == 0)   // Cách sửa lỗi xh lỗi 2 lần
            {
                
            }
            else
            {
                txtbox.Text = "";
                MessageBox.Show("Lỗi không được nhập chữ và kí tự");
            }
        }

        private void doiMauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            Control control = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;
            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                control.ForeColor = colordlg.Color;
                //foreach(Control item in this.Controls)
                //{
                //    if (item.ContextMenuStrip == contextMenuStrip1)
                //    {
                        //item.ForeColor = colordlg.Color;
                //    }
                //}
            }
        }

        private void doiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdlg = new FontDialog();
            if (fontdlg.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in this.Controls)
                {
                    if (item.ContextMenuStrip == contextMenuStrip1)
                    {
                        item.Font = fontdlg.Font;
                    }
                }
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            //string pt = txtPhuongTrinh.Text;
            double denta=b*b-(4*c)*a;       // 0 0 3
            //MessageBox.Show(denta.ToString());
            if (denta < 0)
            {
                txtkq.Text = "Phương trình vô nghiệm";
            } 
            else
            {
                if (denta == 0)
                {
                    if (a == 0 && b == 0 && c == 0)
                    {
                        txtkq.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        if (a > 0)
                        {
                            txtkq.Text = (-b / (2 * a)).ToString();
                        }
                        else
                        {
                            txtkq.Text = "Ghê đấy phát hiện ra trường hợp đặc biệt";
                        }
                    }
                }
                else
                {
                    double n1=(-b-Math.Sqrt(denta))/(2*a);
                    double n2 = (-b + Math.Sqrt(denta)) / (2 * a);
                    txtkq.Text = string.Format("Phương trình có 2 nghiệm phân biệt x1 = {0} và x2 = {1}",n1,n2);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
