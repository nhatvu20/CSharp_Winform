using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CuaHangQLThueTruyen_doradora
{
    class ConnectDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=2023_QuanLyMuonTruyen;Integrated Security=True");
        public DataTable getlist(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            return dtable;
        }
        public void crud(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
        }
    }
}
