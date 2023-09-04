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

namespace CT_QLCB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //DialogResult c = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            //if (((DialogResult)c))
            //{

            //}
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLCB_2023;Integrated Security=True");
        void hienthi()
        {
            string query = "select * from canbo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
                string query = "insert into canbo values("+txtMaCB.Text+",N'"+txtHT.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+rdNam.Checked+"','"+txtEmail.Text+"','"+txtPhone.Text+"');";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
                hienthi();
            }
            catch
            {
                MessageBox.Show("Mã cán bộ trùng");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from canbo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "update canbo set [Họ tên]=N'"+txtHT.Text+"',[Ngày sinh]='"+dateTimePicker1.Value.ToShortDateString()+"',[Giới tính]='"+rdNam.Checked+"',Email='"+txtEmail.Text+"',Phone='"+txtPhone.Text+"' where [Mã CB]='"+txtMaCB.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete canbo where [Mã CB]='" + txtMaCB.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "select * from canbo where [Mã CB]='"+txtTimTenCB.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            if (txtTimTenCB.Text.Length == 0)
            {
                hienthi();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ToShortDateString();

            rdNam.Checked = (bool)dataGridView1.CurrentRow.Cells[3].Value;
            rdNu.Checked = !(bool)dataGridView1.CurrentRow.Cells[3].Value;
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
