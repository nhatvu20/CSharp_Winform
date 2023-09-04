using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uoc_so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  // Xóa danh sách ước số cũ

            if (comboBox1.SelectedIndex >= 0)  // Kiểm tra xem có phần tử được chọn không
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                int number = int.Parse(selectedItem);

                List<int> danhSachUocSo = layCacUocSo(number);

                foreach (int uocSo in danhSachUocSo)
                {
                    listBox1.Items.Add(uocSo);  // Thêm ước số vào ListBox
                }
            }
        }
        public int tongCacUocSo(int number)
        {
            int tong = 0;
            List<int> danhSachUocSo = layCacUocSo(number);
            foreach (int uocSo in danhSachUocSo)
            {
                tong = tong + uocSo;
            }
            return tong;

        }
        public static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private List<int> layCacUocSo(int number)
        {
            List<int> danhSachUocSo = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    danhSachUocSo.Add(i);
                }
            }

            return danhSachUocSo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int number = int.Parse(selectedItem);
            int a = tongCacUocSo(number);
            MessageBox.Show(a.ToString(), "Tổng các ước số");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Dữ liệu nhập vào không được để trống!");
            }
            else if (!isNumber(textBox1.Text)) {
                errorProvider1.SetError(textBox1, "Nhập sai định dạng!");
            }
            else
            {
                errorProvider1.Clear();
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }
        public int soLuongUocSoChan(int number)
        {
            int dem = 0;
            List<int> danhSachUocSo = layCacUocSo(number);
            foreach (int uocSo in danhSachUocSo)
            {
                if (uocSo % 2 == 0) dem++;
            }
            return dem;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int number = int.Parse(selectedItem);
            int a = soLuongUocSoChan(number);
            MessageBox.Show(a.ToString(), "Số lượng các ước số chẵn");
        }
        public static bool soNguyenTo(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                } 
            }
            return true;
        }
        public int soLuongUocSoNguyenTo(int number)
        {
            int dem = 0;
            List<int> danhSachUocSo = layCacUocSo(number);
            foreach (int uocSo in danhSachUocSo)
            {
                if (soNguyenTo(uocSo) == true) dem++;
            }
            return dem;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int number = int.Parse(selectedItem);
            int a = soLuongUocSoNguyenTo(number);
            MessageBox.Show(a.ToString(), "Số lượng các ước số nguyên tố");
        }
    }
}
