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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLSinhVien_2023_De12;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dtable;
        private void Khoa_Load(object sender, EventArgs e)
        {
            string query="select * from khoa";
            cmd = new SqlCommand(query, con);
            dtable = new DataTable();
            adapter=new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            //BindingSource bind = new BindingSource();
            //bind.DataSource = dtable;
            //bindingNavigator1.BindingSource = bind;
            //dataGridView1.DataSource = bind;
            BindingSource bind = new BindingSource();
            bind.DataSource = dtable;
            bindingNavigator1.BindingSource = bind;
            dataGridView1.DataSource = bind;
        }
        void hienthi()
        {
            string query = "select * from khoa";
            cmd = new SqlCommand(query, con);
            dtable = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            //BindingSource bind = new BindingSource();
            //bind.DataSource = dtable;
            //bindingNavigator1.BindingSource = bind;
            //dataGridView1.DataSource = bind;
            BindingSource bind = new BindingSource();
            bind.DataSource = dtable;
            bindingNavigator1.BindingSource = bind;
            dataGridView1.DataSource = bind;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string query = "insert into khoa values('"+textBox1.Text+"',N'"+textBox2.Text+"');";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            hienthi();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string query = "delete khoa where makhoa='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            hienthi();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string query = "update khoa set tenkhoa=N'" + textBox2.Text + "' where makhoa=N'" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            hienthi();
        }
    }
}
