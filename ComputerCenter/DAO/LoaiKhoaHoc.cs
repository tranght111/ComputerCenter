using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComputerCenter;

namespace ComputerCenter.DAO
{
    public class LoaiKhoaHocDAO : XuLyDuLieu
    {
        // Chon khoa hoc
        public static DataTable ChonKhoaHoc()
        {
            SqlConnection con = new SqlConnection(path);
            var cmd = string.Format("SELECT * FROM LOAIKHOAHOC");
            var da = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
