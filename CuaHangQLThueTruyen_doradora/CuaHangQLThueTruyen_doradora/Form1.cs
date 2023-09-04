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

namespace CuaHangQLThueTruyen_doradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void visible()
        {
            dataGridView1.Columns[1].Visible = false;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            int num = 0;
            try
            {
                int check = int.Parse(txtSDT.Text);
                txtSDT.Text = sdt;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtSDT.Text = "";
            }
            //if (!int.TryParse(txtSDT.Text,out num))
            //{
            //    MessageBox.Show("Vui lòng nhập số!");
            //    txtSDT.Text = "";
            //}
            //else
            //{
            //    txtSDT.Text = sdt;
            //}
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=2023_QuanLyMuonTruyen;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Truyen> list = new List<Truyen>()
            {
                new Truyen{tentruyen="Doraemon",dongia=3000 },
                new Truyen{tentruyen="Conan",dongia=2000},
                new Truyen{tentruyen="Thủy thủ mặt trăng",dongia=1000},
                new Truyen{tentruyen="Thủ lĩnh thẻ bài Sakura",dongia=1000},
                new Truyen{tentruyen="Khuyển dạ soa",dongia=1000}
            };
            string query = "select row_number() over (order by id) as STT, * from truyen";
            //SqlCommand cmd = new SqlCommand(query,con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dtable = new DataTable();
            //adapter.Fill(dtable);
            ConnectDatabase con1 = new ConnectDatabase();
            dataGridView1.DataSource = con1.getlist(query) ;

            //query = "select distinct [Tên khách],id from truyen";
            //cbxTenK.DataSource = con1.getlist(query);
            //cbxTenK.DisplayMember = "Tên khách";
            //cbxTenK.ValueMember = "id";

            //query = "select [Đơn giá/Ngày],[Tên truyện] from truyen";
            //cbxTenT.DataSource = con1.getlist(query);
            //cbxTenT.DisplayMember = "Tên truyện";

            //txtDG.DataBindings.Add("Text", cbxTenT.DataSource, "Đơn giá/Ngày");
            cbxTenT.DataSource = list;
            cbxTenT.DisplayMember = "tentruyen";

            txtDG.DataBindings.Add("Text", cbxTenT.DataSource, "dongia");
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            //string query = "insert into truyen values(N'" + txtKH.Text + "','" + txtSDT.Text + "','" + cbxTenT.Text + "'," + txtDG.Text + ",'" + dateTimePicker1Muon.Value.ToShortDateString() + "','','',N'chưa trả')";
            string query = "insert into truyen ([Tên khách], [Số điện thoại], [Tên truyện], [Đơn giá/Ngày], [Ngày mượn], [Ghi chú]) values(N'" + txtKH.Text + "','" + txtSDT.Text + "',N'" + cbxTenT.Text + "'," + txtDG.Text + ",'" + dateTimePicker1Muon.Value.ToShortDateString() + "',N'chưa trả')";
            ConnectDatabase con2 = new ConnectDatabase();
            con2.crud(query);
            query = "select row_number() over (order by id) as STT, * from truyen";
            dataGridView1.DataSource = con2.getlist(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKH.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbxTenT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1Muon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2Tra.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            ConnectDatabase con3 = new ConnectDatabase();
            string query = "update truyen set [Ngày trả]='"+dateTimePicker2Tra.Value.ToShortDateString()+ "', [Ghi chú] = '' where id='" + labelID.Text+"'";
            con3.crud(query);
            query = "SELECT row_number() over (order by id) as STT,id, [Tên khách], [Số điện thoại], [Tên truyện], [Đơn giá/Ngày], [Ngày mượn], [Ngày trả], [Thành tiền], [Ghi chú] FROM truyen";
            dataGridView1.DataSource = con3.getlist(query);
            query = "update truyen set [Thành tiền] = datediff(day,[Ngày mượn],[Ngày trả])*[Đơn giá/Ngày] where id='" + labelID.Text + "'";
            con3.crud(query);
        }

        class Truyen
        {
            public string tentruyen { get; set; }
            public int dongia { get; set; }
        }
    }
}
