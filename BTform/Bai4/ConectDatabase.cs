﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Bai4
{
    class ConectDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=qlsv2023newnew;Integrated Security=True");
        DataSet dtset = new DataSet();
        
        public DataSet getlist(string query,string tenbang)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);  // Query , sqlconnect
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Truyen sqlCommand
            DataTable dtable = new DataTable();
            adapter.Fill(dtset,tenbang);  // Nhiều datatable
            //adapter.Fill(dtable);
            con.Close();
            //return dtable;
            return dtset;
        }

        public void excute(string crud)
        {
            //"INSERT INTO dssv VALUES(123 , 123,23/05/2023, True, Hà Nội)"
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand(crud, con);  // Query , sqlconnect
                //cmd.CommandType = CommandType.        Procedure
                int lagichaduoc = cmd.ExecuteNonQuery();
                if (lagichaduoc > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Thành công");   //using trc
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Thất bại");   //using trc
                }

                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi " +e.Message.ToString());
            }
        }
    }
}
