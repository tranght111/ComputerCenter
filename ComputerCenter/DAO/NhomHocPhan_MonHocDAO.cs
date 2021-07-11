using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenter.DAO
{
    public class NhomHocPhan_MonHocDAO
    {
        public static DataTable LayDSNhomHocPhan_MonHoc()
        {
            string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM NHOMHOCPHAN_MONHOC";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var table = new DataTable();
            da.Fill(table);
            da.Dispose();

            return table;
        }


    }
}
