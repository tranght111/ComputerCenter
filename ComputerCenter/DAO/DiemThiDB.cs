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
    public class DiemThiDB : XuLyDuLieu
    {
        public DataTable LayDSMonHoc(string MaHocPhan)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT* FROM MONHOC WHERE MANHOM = {0}", MaHocPhan);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableMonHoc = new DataTable();
            dr.Fill(tableMonHoc);
            dr.Dispose();

            return tableMonHoc;
        }

        public DataTable LayDSHVThiDat(string MaKhoaHoc, string MaLop)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM KHOAHOC K, DIEMTHIKTHP D, MONHOC M, HOCVIEN H, NHOMHOCPHAN N WHERE K.MAKHOAHOC = N.MAKHOAHOC AND N.MANHOM = M.MANHOM AND M.MALOP = D.MALOP AND D.DIEM >= 5 AND K.MAKHOAHOC = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN", MaKhoaHoc, MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }

        public DataTable LayDSHVHocLai(string MaKhoaHoc,  string MaLop)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM KHOAHOC K, DIEMTHIKTHP D, MONHOC M, HOCVIEN H, NHOMHOCPHAN N WHERE K.MAKHOAHOC = N.MAKHOAHOC AND N.MANHOM = M.MANHOM AND M.MALOP = D.MALOP AND D.DIEM < 5 AND K.MAKHOAHOC = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN", MaKhoaHoc, MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }

    }
}
