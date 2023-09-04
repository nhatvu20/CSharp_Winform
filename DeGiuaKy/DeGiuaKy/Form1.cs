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

namespace DeGiuaKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Datagidview_Visible()
        {

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=2023_QLNhanSu;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dtable = new DataTable();
            //adapter.Fill(dtable);
            ConnectDatabase con1 = new ConnectDatabase();
            dataGridView1.DataSource = con1.getlist(query);
            Datagidview_Visible();
            query = "select * from donviphongban";
            con1 = new ConnectDatabase();
            cbxDVPB.DataSource= con1.getlist(query);
            cbxDVPB.DisplayMember = "donviphongban";
            cbxDVPB.ValueMember = "madonvi";

            cbxDVPB2.DataSource = con1.getlist(query);
            cbxDVPB2.DisplayMember = "donviphongban";
            cbxDVPB2.ValueMember = "madonvi";

            query = "select * from bangmucluong";
            con1 = new ConnectDatabase();
            cbxML.DataSource = con1.getlist(query);
            cbxML.DisplayMember = "mucluong";
            cbxML.ValueMember = "mamucluong";
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtHT.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDC.Text = "";
            txtBHXH.Text = "";
            cbxDVPB.Text = "";
            cbxML.Text = "";

            //try
            //{
            //    string gioitinh = "False";   // hoac la kieu 0 1 int
            //    if (cbxGT.Text == "Nam")
            //    {
            //        gioitinh = "True";
            //    }
            //    string crud = "INSERT INTO nhansu VALUES(N'" + txtHT.Text + "','" + gioitinh + "','" + dateTimePicker1.Text + "','" + txtCCCD.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "','" + txtSDT.Text + "'," + txtBHXH.Text + "," + cbxDVPB.SelectedValue + "," + cbxML.SelectedValue + ")";
            //    SqlCommand cmd = new SqlCommand(crud, con);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable dtable = new DataTable();
            //    adapter.Fill(dtable);
            //    dataGridView1.DataSource = dtable;
            //    string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
            //    ConnectDatabase con1 = new ConnectDatabase();
            //    dataGridView1.DataSource = con1.getlist(query);
            //    Datagidview_Visible();
            //}
            //catch
            //{
            //    MessageBox.Show("Nhập trùng thông tin rồi!!!");
            //}

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string crud = "Delete nhansu where socccd = '"+txtCCCD.Text+"'";
            SqlCommand cmd = new SqlCommand(crud, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
            ConnectDatabase con1 = new ConnectDatabase();
            dataGridView1.DataSource = con1.getlist(query);
            Datagidview_Visible();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string gioitinh = "Nữ";
            if ((bool)dataGridView1.CurrentRow.Cells[2].Value == true)
            {
                gioitinh = "Nam";
            }
            cbxGT.Text = gioitinh;
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCCCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDC.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBHXH.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDVPB.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cbxML.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            chkDLV.Checked=(bool)dataGridView1.CurrentRow.Cells[11].Value;


            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;


        }

        private void rdDangLam_CheckedChanged(object sender, EventArgs e)
        {
            //string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='True'";
            //ConnectDatabase con1 = new ConnectDatabase();
            //dataGridView1.DataSource = con1.getlist(query);
            //Datagidview_Visible();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void rdDaNghiLam_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='False'";
            ConnectDatabase con1 = new ConnectDatabase();
            dataGridView1.DataSource = con1.getlist(query);
            Datagidview_Visible();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";

            if (rdDangLam.Checked)
            {
                query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu" +
                    " inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong" +
                    " inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='True' and nhansu.madonvi=" + cbxDVPB2.SelectedValue + "";
            }
            else if (rdDaNghiLam.Checked)
            {
                query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='False' and nhansu.madonvi=" + cbxDVPB2.SelectedValue + "";

            }
            else
            {
                query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where nhansu.madonvi=" + cbxDVPB2.SelectedValue + "";

            }




            if (txtHT1.Text.Length > 0)
            {
                if (cbxDVPB2.Text.Length > 0)
                {
                    query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
                        "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where hoten like '%" + txtHT1.Text + "%'";

                }
                else
                {
                    query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
                        "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where hoten like '%" + txtHT1.Text + "%'";

                }
            }

            //if (rdDangLam.Checked)
            //{
            //    query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //        "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='True'";
            //}
            //else if (rdDaNghiLam.Checked)
            //{
            //    query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //        "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='False'";

            //}
            //else
            //{
            //    query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //        "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
            //}

            //if ((txtHT1.Text.Length > 0 && rdDangLam.Checked) || (rdDaNghiLam.Checked && txtHT1.Text.Length > 0))
            //{
            //    if (rdDangLam.Checked)
            //    {
            //        query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //            "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='True' and nhansu.madonvi=" + cbxDVPB2.SelectedValue + "";
            //    }
            //    else if (rdDaNghiLam.Checked)
            //    {
            //        query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //            "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi where tinhtrang='False' and nhansu.madonvi=" + cbxDVPB2.SelectedValue + "";

            //    }
            //    else
            //    {
            //        query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong " +
            //            "inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
            //    }
            //}



            ConnectDatabase con1 = new ConnectDatabase();
            dataGridView1.DataSource = con1.getlist(query);
            Datagidview_Visible();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh = "False";   // hoac la kieu 0 1 int
                if (cbxGT.Text == "Nam")
                {
                    gioitinh = "True";
                }
                string crud = "INSERT INTO nhansu VALUES(N'" + txtHT.Text + "','" + gioitinh + "','" + dateTimePicker1.Text + "','" + txtCCCD.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "','" + txtSDT.Text + "'," + txtBHXH.Text + "," + cbxDVPB.SelectedValue + "," + cbxML.SelectedValue + ")";
                SqlCommand cmd = new SqlCommand(crud, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
                string query = "select row_number() over (order by socccd) as 'ID', hoten as 'Họ tên', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', socccd as 'CCCD' ,email, sodienthoai as 'Số điện thoại', diachi as 'Địa chỉ', mucdongbhxh as 'Mức đóng BHXH', donviphongban,mucluong,tinhtrang from nhansu inner join bangmucluong on nhansu.mamucluong = bangmucluong.mamucluong inner join donviphongban on donviphongban.madonvi=nhansu.madonvi";
                ConnectDatabase con1 = new ConnectDatabase();
                dataGridView1.DataSource = con1.getlist(query);
                Datagidview_Visible();
            }
            catch
            {
                MessageBox.Show("Nhập trùng thông tin rồi!!!");
            }
        }
    }
}
