using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danh_sach_sinh_vien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Không được để trống");
                return;
            }
            else errorProvider1.Clear();
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Không được để trống");
                return;
            }
            else errorProvider2.Clear();
            if (comboBoxQueQuan.Text == "")
            {
                errorProvider3.SetError(comboBoxQueQuan, "Không được để trống");
                return;
            }
            else errorProvider3.Clear();
            if (comboBoxQueQuan.Text == "")
            {
                errorProvider4.SetError(comboBoxLop, "Không được để trống");
                return;
            }
            else errorProvider4.Clear();
            if (comboBoxQueQuan.Text == "")
            {
                errorProvider5.SetError(comboBoxKhoa, "Không được để trống");
                return;
            }
            else errorProvider5.Clear();
            if (!radNam.Checked && !radNu.Checked)
            {
                errorProvider6.SetError(radNu, "Hãy chọn 1 trong 2 giới tính!");
                return;
            }
            else errorProvider6.Clear();
            string gioiTinh = "";
            if (radNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else gioiTinh = "Nữ";
            dataGridView1.Rows.Add(textBox2.Text, dateTimePicker1.Value.ToShortDateString(), gioiTinh, comboBoxQueQuan.Text, comboBoxLop.Text, comboBoxKhoa.Text);
            textBox1.Clear();
            textBox2.Clear();
            comboBoxQueQuan.Text = "";
            comboBoxLop.Text = "";
            comboBoxKhoa.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxQueQuan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxLop.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxKhoa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (radNam.Checked)
            {
                radNam.Checked = true;
            }
            else radNu.Checked = true;
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
