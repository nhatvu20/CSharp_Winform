using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_and_year_of_birth
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtYourName.Text == "" || !isNumber(txtYear.Text))
            {
                errorProvider1.SetError(txtYourName, "Please enter your name!");
                errorProvider2.SetError(txtYear, "Year must be a number!");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                MessageBox.Show("Your name: " + txtYourName.Text + "\nYour age: " + (2023 - Convert.ToInt32(txtYear.Text)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void txtYourName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
