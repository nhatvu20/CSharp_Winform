using ConsoleTables;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTableConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var data = InitEmployee();
            string[] columnNames = data.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();

            DataRow[] rows = data.Select();

            var table = new ConsoleTable(columnNames);
            foreach (DataRow row in rows)
            {
                table.AddRow(row.ItemArray);
            }
            /*table.Write(Format.MarkDown);
            table.Write(Format.Alternative);
            table.Write(Format.Minimal);
            table.Write(Format.Default);*/
            Console.Read();
        }
        public static DataTable InitEmployee()
        {

            var table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("Gender", typeof(string));

            table.Rows.Add(1, "Nguyễn Thảo", "Vũng Tàu", "Male");
            table.Rows.Add(2, "Nguyễn Đình Tuyên", "Quảng Bình", "Male");
            table.Rows.Add(3, "Trịnh Quốc Khang", "Đồng Nai", "Female");
            table.Rows.Add(4, "Cái Trí Minh", "Quảng Trị", "Male");
            table.Rows.Add(5, "Võ Sơn Băng", "Vĩnh Long", "Female");
            table.Rows.Add(6, "Nguyễn Thị Cẩm Tú", "Kiên Giang", "Female");
            table.Rows.Add(7, "Nguyễn Phương Nhi", "TP. Hồ Chí Minh", "Male");
            table.Rows.Add(8, "Hoàng Thị Thảo", "Quảng Bình", "Female");
            return table;
        }
    }
}
