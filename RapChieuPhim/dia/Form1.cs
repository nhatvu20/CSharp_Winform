using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tong = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if(clickedBtn.BackColor != Color.Green)
            {
                clickedBtn.BackColor = Color.Green;
                if (clickedBtn.Text.Contains("A"))
                {
                    tong += 25000;
                }
                else if (clickedBtn.Text.Contains("B"))
                {
                    tong += 30000;
                }
                else if (clickedBtn.Text.Contains("C"))
                {
                    tong += 35000;
                }
                else if (clickedBtn.Text.Contains("D"))
                {
                    tong += 40000;
                }
                else if (clickedBtn.Text.Contains("E"))
                {
                    tong += 50000;
                }
                else if (clickedBtn.Text.Contains("F"))
                {
                    tong += 45000;
                }
            }
            else
            {
                if (clickedBtn.Text.Contains("A"))
                {
                    clickedBtn.BackColor = Color.LightCyan;
                    tong -= 25000;
                }
                else if(clickedBtn.Text.Contains("B"))
                {
                    clickedBtn.BackColor = Color.LightGreen;
                    tong -= 30000;
                }
                else if (clickedBtn.Text.Contains("C"))
                {
                    clickedBtn.BackColor = Color.LemonChiffon;
                    tong -= 35000;
                }
                else if (clickedBtn.Text.Contains("D"))
                {
                    clickedBtn.BackColor = Color.Violet;
                    tong -= 40000;
                }
                else if (clickedBtn.Text.Contains("E"))
                {
                    clickedBtn.BackColor = Color.Pink;
                    tong -= 50000;
                }
                else if (clickedBtn.Text.Contains("F"))
                {
                    clickedBtn.BackColor = Color.NavajoWhite;
                    tong -= 45000;
                }
            }
            total.Text = tong.ToString() + " đ";
        }
        Dictionary<string, List<Color>> colorBtn = new Dictionary<string, List<Color>>();
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có đồng ý mua những ghế đã chọn hay không?", "Thông báo mua vé",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string filmName = cb_film.SelectedItem.ToString();
                foreach(Control btn in tableLayoutPanel1.Controls)
                {
                    if(btn.BackColor == Color.Green)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                        slMua[filmName]++;
                    }
                }
                total.Text = "0 đ";
                foreach (Control btn in tableLayoutPanel1.Controls)
                {
                    colorBtn[filmName].Add(btn.BackColor);
                }
            }
        }

        private void cb_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_film.Text = "Mời bạn chọn ghế trong phòng chiếu phim: " + cb_film.SelectedItem.ToString();
            string filmName = cb_film.SelectedItem.ToString();
            status.Text = slMua[filmName] + " ghế đã bán, " + (36 - slMua[filmName]) + " ghế còn trống";
            int i = 0;
            foreach(Color color in colorBtn[filmName])
            {
                ButtonList[i].BackColor = color;
                i++;
            }
            foreach(Control btn in tableLayoutPanel1.Controls)
            {
                if(btn.BackColor!= Color.Red && btn.Enabled == false)
                {
                    btn.Enabled = true;
                }
                else if (btn.BackColor == Color.Red)
                {
                    btn.Enabled= false;
                }
            }
        }

        Dictionary<string, int> slMua = new Dictionary<string, int>();
        List<Button> ButtonList = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            int Count = cb_film.Items.Count;
            for(int i = 0; i < Count; i++)
            {
                string filmName = cb_film.Items[i].ToString();
                slMua[filmName] = 0;
                colorBtn[filmName] = new List<Color>();
                foreach (Control btn in tableLayoutPanel1.Controls)
                {
                    colorBtn[filmName].Add(btn.BackColor);
                    ButtonList.Add(btn as Button);
                }
                
            }
        }
    }
}
