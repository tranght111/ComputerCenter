using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    class KhoaHocDAO
    {
        static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        public DataTable LayDSKhoaHoc()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM KHOAHOC", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }

        public DataTable LayDSKhoaHocKTV()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM KHOAHOC WHERE MALOAI = 1", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }
    }
}
