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

namespace De12
{
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLSinhVien_2023_De12;Integrated Security=True");
        private void XemDiem_Load(object sender, EventArgs e)
        {
            string query="select * from ketqua";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            query = "select distinct ketqua.maso,hoten,khoa.makhoa from ketqua inner join sinhvien on ketqua.maso=sinhvien.maso inner join khoa on sinhvien.makhoa = khoa.makhoa";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            comboBox1.DataSource = dtable;
            comboBox1.DisplayMember = "maso";
            comboBox1.ValueMember = "maso";
            comboBox2.DataSource = dtable;
            comboBox2.DisplayMember = "hoten";
            comboBox2.ValueMember = "hoten";
            textBox1.DataBindings.Add("Text", comboBox1.DataSource, "makhoa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from ketqua where maso = '"+comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }
    }
}
