using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Enter(object sender, EventArgs e)
        {
            int tuoi=0;
            if (int.TryParse(txtYear.Text,out tuoi))
            {
                tuoi = Convert.ToInt32(2023) - Convert.ToInt32(txtYear.Text);
                MessageBox.Show("Name: "+txtYourName.Text + "\n"+"Tuoi: " + tuoi);
            }
            else
            {
                MessageBox.Show("Vui long nhap so!!!","Cảnh báo");
            }
        }
        //tuoi = Convert.ToString(Convert.ToInt32(2023) - Convert.ToInt32(txtYear.Text));
        private void frmMain_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtYourName, "Phai nhap chu");
            errorProvider2.SetError(txtYear, "Phai nhap so");
        }

        private void exit(object sender, EventArgs e)
        {
            DialogResult box=MessageBox.Show("Bạn có muốn thoát không?", "Bảng thông báo", MessageBoxButtons.YesNo);
            if (box == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void txtYourNameLeave(object sender, EventArgs e)
        {

        }

        private void YearTextChange(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Text = "";
            txtYourName.Text = "";

        }
    }
}
