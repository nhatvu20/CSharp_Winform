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

namespace De_01_ck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from nhansu where id = '"+lbID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            query = "select * from nhansu";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            visible();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=2023_QLNS_De1_CK;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select row_number() over (order by id) as STT, * from nhansu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            visible();

        }
        void visible()
        {
            dataGridView1.Columns[5].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rdNam.Checked = (bool)dataGridView1.CurrentRow.Cells[1].Value;
            rdNu.Checked = !(bool)dataGridView1.CurrentRow.Cells[1].Value;
            cbxQueQuan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxDonVi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbxHHHV.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lbID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "update nhansu set [Họ tên]=N'"+txtHT.Text+"',[Giới tính]='"+rdNam.Checked+"',[Quê quán] = N'"+cbxQueQuan.Text+"',[Đơn vị] = N'"+cbxDonVi.Text+"',[Học hàm/Học vị] = N'"+cbxHHHV.Text+"' where id = '"+lbID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            query = "select * from nhansu";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            visible();


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select * from nhansu where [Quê quán] = N'"+cbxQueQuan.Text+"' or [Đơn vị]=N'"+cbxDonVi.Text+"' or [Học hàm/Học vị]=N'"+cbxHHHV.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }
    }
}
