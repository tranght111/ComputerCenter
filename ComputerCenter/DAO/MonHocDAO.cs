using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComputerCenter;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    public class MonHocDAO : XuLyDuLieu
    {
        public DataTable LayDSMonHoc(string MaKhoaHoc, string MaHocPhan)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT* FROM v_LayDanhSachMonHoc WHERE MAKHOAHOC = {0} AND MANHOM = {1}", MaKhoaHoc, MaHocPhan);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableMonHoc = new DataTable();
            dr.Fill(tableMonHoc);
            dr.Dispose();

            return tableMonHoc;
        }

        public DataTable LayDSHVThiDatCuaMonHoc(MonHocBUS mh)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE D.DIEM >= 5 AND D.MANHOM = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN", mh.MaHocPhan, mh.MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }

        public DataTable LayDSHVHocLaiCuaMonHoc(MonHocBUS mh)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE D.DIEM < 5 AND D.MANHOM = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN", mh.MaHocPhan, mh.MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }

    }
}
