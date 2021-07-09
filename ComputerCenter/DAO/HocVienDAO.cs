using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.BUS;
using System.Configuration;

namespace ComputerCenter.DAO
{
    class HocVienDAO:XuLyDuLieu
    {
        public static int ThemHocVien(HocVienBUS hocvien)
        {
            string sql = string.Format("execute proc_ThemHocVien '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}'", hocvien.TenHV, hocvien.GioiTinh, hocvien.DiaChi, hocvien.NgaySinh, hocvien.SDT, hocvien.Email, hocvien.Username, hocvien.Password);
            var rs = ThucThi(sql);

            return rs;
        }

        public static int KtraUsernameHopLe(HocVienBUS hv)
        {
            string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
            using (var conn = new SqlConnection(path))
            {
                conn.Open();

                using (var cmd = new SqlCommand("func_KTraUsernameTonTai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters["@user"].Value = hv.Username;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return (int)cmd.Parameters["@RETURN_VALUE"].Value;
                }
                
            }
        }
    }
}
