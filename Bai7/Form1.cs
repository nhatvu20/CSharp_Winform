using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetqua.Clear();
            label2.Text = "";
            txtBieuthuc.Clear();
            txtBieuthuc.Focus();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            /*string bieuthuc = label2.Text;
            //MessageBox.Show(bieuthuc);
            DataTable table = new DataTable();
            int result = (int)table.Compute(bieuthuc, "");
            txtKetqua.Text = result.ToString();*/
            label2.Text = "";
            if(txtKetqua.Text == "")
            {
                switch (operation)
                {
                    case "+":
                        txtKetqua.Text = (results + Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "-":
                        txtKetqua.Text = (results - Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "*":
                        txtKetqua.Text = (results * Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "/":
                        txtKetqua.Text = (results / Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                }
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        txtKetqua.Text = (Double.Parse(txtKetqua.Text) + Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "-":
                        txtKetqua.Text = (Double.Parse(txtKetqua.Text) - Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "*":
                        txtKetqua.Text = (Double.Parse(txtKetqua.Text) * Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                    case "/":
                        txtKetqua.Text = (Double.Parse(txtKetqua.Text) / Double.Parse(txtBieuthuc.Text)).ToString();
                        break;
                }
            }
            
        }

        private void nhapso(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            txtBieuthuc.Text += num.Text;
        }
        Double results = 0;
        String operation = "";
        private void bthCong_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtBieuthuc.Text);
            txtBieuthuc.Text = "";
            if(txtKetqua.Text == "")
            {
                label2.Text = System.Convert.ToString(results) + " " + operation;
            }
            else
            {
                label2.Text = System.Convert.ToString(txtKetqua.Text) + " " + operation;

            }

        }

        private void txtBieuthuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
