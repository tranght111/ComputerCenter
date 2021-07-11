using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    public class HocPhanDAO
    {
        static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        public static DataTable LayDSNhomHocPhan(int MaKhoaHoc)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT*FROM NHOMHOCPHAN WHERE MAKHOAHOC = {0}", MaKhoaHoc);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableHocPhan = new DataTable();
            dr.Fill(tableHocPhan);
            dr.Dispose();

            return tableHocPhan;
        }

        public static DataTable cbbLayDanhSachMaNhomHP()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM NHOMHOCPHAN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableNHP = new DataTable();
            da.Fill(tableNHP);
            da.Dispose();

            return tableNHP;
        }
    }
}
