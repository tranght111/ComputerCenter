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
            //string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
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


        public DataTable XemDSHV(int makh, object manhom = null, object malop = null)
        {
            DataTable data = new DataTable();
            object[] parameters = new object[] { makh, manhom, malop };

            string query = string.Format("exec proc_DSHocVien '{0}', '{1}', '{2}'", parameters);

            //data = LoadDataWithParameters(query, parameters);
            data = LayDuLieu(query);

            return data;
        }

        public DataTable XemTatCaHocVien()
        {
            DataTable data = new DataTable();
            string query = "select * from view_AllHocVien";
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVtheoMaKH(int makh)
        {
            DataTable data = new DataTable();
            string query = "exec proc_DSHVtheoMaKH " + makh;
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            DataTable data = new DataTable();
            string query = string.Format("exec proc_DSHVtheoMaKHvaMaNhomHP '{0}', '{1}'", makh, manhom);
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVtheoMaKH_MaNhomHP_MaLop(int makh, int manhom, int malop)
        {
            DataTable data = new DataTable();
            string query = string.Format("exec proc_DSHVtheoMaKH_MaNhomHP_MaLop '{0}', '{1}', '{2}'", makh, manhom, malop);
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPKDiemTN()
        {
            DataTable data = new DataTable();
            string query = "select * from View_DSHocVienPhucKhaoDiemTN";
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPKDiemTNtheoKH(int makh)
        {
            DataTable data = new DataTable();
            string query = "exec proc_DSHocVienPhucKhaoDiemTNTheoKH " + makh;
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPhucKhaoDiemKTHP()
        {
            DataTable data = new DataTable();
            string query = "select * from view_DSHVPhucKhaoDiemKTHP";
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH(int makh)
        {
            DataTable data = new DataTable();
            string query = "exec proc_DSHVPhucKhaoDiemKTHPtheoKH " + makh;
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            DataTable data = new DataTable();
            string query = string.Format("exec proc_DSHVPhucKhaoDiemKTHPtheoKH_NhomHP '{0}', '{1}'", makh, manhom);
            data = LayDuLieu(query);

            return data;
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP_MaLop(int makh, int manhom, int malop)
        {
            DataTable data = new DataTable();
            string query = string.Format("exec proc_DSHVPhucKhaoDiemKTHPtheoKH_NhomHP_MaLop '{0}', '{1}', '{2}'", makh, manhom, malop);
            data = LayDuLieu(query);

            return data;
        }

        public int LayMaHVtheoUsername(string username)
        {
            string query = "select MAHOCVIEN from HOCVIEN where USERNAME = '" + username + "'";
            var t = LayDuLieu(query);
            int maHV = 0;
            foreach (DataRow item in t.Rows)
            {
                maHV = (int)item["MAHOCVIEN"];
            }

            return maHV;
        }
    }
}
