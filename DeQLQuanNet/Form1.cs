using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeQLQuanNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\nguye\OneDrive\Documents\quanlyquannet2023.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Máy đang được chọn");
            }
            btn.BackColor=Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[Table]";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            BindingSource bind = new BindingSource();
            bind.DataSource = dtable;
            bindingNavigator1.BindingSource = bind;
            dataGridView1.DataSource = bind;
            
        }

        void hienthi()
        {
            string query = "select * from [dbo].[Table]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into [dbo].[Table] values (N'"+button1.Text+"',"+textBox1.Text+","+textBox2.Text+","+(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text))+",5000,"+((Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text)) * 5000)+");";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            hienthi();
            button1.BackColor = Color.Transparent;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox3.Text = ((Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text)) * 5000).ToString();
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox6.Text = ((Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text)) * 5000).ToString();
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox9.Text = ((Convert.ToInt32(textBox8.Text) - Convert.ToInt32(textBox7.Text)) * 5000).ToString();

        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text.Length != 0)
            {
                textBox12.Text = ((Convert.ToInt32(textBox11.Text) - Convert.ToInt32(textBox10.Text)) * 5000).ToString();

            }

        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            Control control =
                ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;
            if (color.ShowDialog() == DialogResult.OK)
            {
                control.BackColor = color.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Mafy muons thoat a chac chua","Thong bao",MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
