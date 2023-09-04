using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhap_so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n) || n <= 0 || n >= 1000)
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ (0 < n < 1000)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Tìm các số nguyên tố nhỏ hơn n
            var primes = Enumerable.Range(2, n - 2).Where(isPrime).ToList();
            string primeNumbers = string.Join(", ", primes);

            // Tìm các số chính phương nhỏ hơn n
            var perfectSquares = Enumerable.Range(1, (int)Math.Sqrt(n)).Select(x => x * x).Where(x => x < n).ToList();
            string squareNumbers = string.Join(", ", perfectSquares);

            // Tìm các số hoàn chỉnh nhỏ hơn n
            var perfectNumbers = Enumerable.Range(1, n - 1).Where(isPerfectNumber).ToList();
            string perfectNums = string.Join(", ", perfectNumbers);

            // Hiển thị kết quả lên các Label tương ứng
            label2.Text = "Các số nguyên tố nhỏ hơn n: " + primeNumbers;
            label4.Text = "Các số chính phương nhỏ hơn n: " + squareNumbers;
            label3.Text = "Các số hoàn chỉnh nhỏ hơn n: " + perfectNums;
        }
        private bool isPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isNumber(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Nhập sai định dạng!");
            }
            else errorProvider1.Clear();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!isNumber(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Nhập sai định dạng!");
            }
            else errorProvider1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
