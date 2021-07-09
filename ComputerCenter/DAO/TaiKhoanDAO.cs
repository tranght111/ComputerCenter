using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    public class TaiKhoanDAO:XuLyDuLieu
    { 
        public static SqlDataReader DocThongTinNguoiDung(TaiKhoanBUS tk)
        {
            string sql = string.Format("SELECT* FROM {0} WHERE USERNAME = '{1}' AND PASSWORD = '{2}'", tk.role, tk.username, tk.password);
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            var cmd = new SqlCommand(sql, conn);

            var rs = cmd.ExecuteReader();
            //var rs = ThucThi(sql);
            //conn.Close();
            return rs;
        }

    }
}
