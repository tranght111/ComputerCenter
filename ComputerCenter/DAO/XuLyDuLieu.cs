using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    public class XuLyDuLieu
    {
        protected static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        protected static DataTable LayDuLieu(string sql)
        {
            SqlConnection conn = new SqlConnection(path);
        
            var dap = new SqlDataAdapter(sql, conn);
            var table = new DataTable();
            dap.Fill(table);

            return table;
        }

        protected static int ThucThi(string sql)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var rs = cmd.ExecuteNonQuery();
            conn.Close();

            return rs;
        }
    }
}
