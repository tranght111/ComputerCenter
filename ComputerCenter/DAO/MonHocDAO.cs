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
    public class MonHocDAO : XuLyDuLieu
    {
        // Chon lop hoc
        public static DataTable ChonLopHoc()
        {
            SqlConnection con = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MONHOC", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
