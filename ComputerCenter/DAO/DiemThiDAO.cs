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
    public class DiemThiDAO : XuLyDuLieu
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

        public DataTable LayDSHVThiDatCuaMonHocTrongLanThi(string MaHocPhan, string MaLop, string LanThi)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE D.DIEM >= 5 AND D.MANHOM = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN AND D.LANTHI = {2}", MaHocPhan, MaLop, LanThi);
            var rs = LayDuLieu(sql);

            return rs;
        }

        public DataTable LayDSHVHocLaiCuaMonHocTrongLanThi(string MaHocPhan, string MaLop, string LanThi)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE D.DIEM < 5 AND D.MANHOM = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN AND D.LANTHI = {2}", MaHocPhan, MaLop, LanThi);
            var rs = LayDuLieu(sql);

            return rs;
        }

        public DataTable LayDSLanThiCuaMonHoc(string MaHocPhan, string MaLop)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT DISTINCT LANTHI FROM DIEMTHIKTHP WHERE MANHOM = {0} AND MALOP = {1}", MaHocPhan, MaLop);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableLanThi = new DataTable();
            dr.Fill(tableLanThi);
            dr.Dispose();
            return tableLanThi;
        }

        public DataTable LayDSHVThiDatCuaMonHoc(string MaHocPhan, string MaLop)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, MAX(DIEM) AS DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE MANHOM = {0} AND MALOP = {1} AND D.MAHOCVIEN = H.MAHOCVIEN AND D.DIEM >= 5 GROUP BY D.MAHOCVIEN, MANHOM, MALOP, H.TENHOCVIEN", MaHocPhan, MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }

        public DataTable LayDSHVHocLaiCuaMonHoc(string MaHocPhan, string MaLop)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, MAX(DIEM) AS DIEM FROM DIEMTHIKTHP D, HOCVIEN H WHERE MANHOM = {0} AND MALOP = {1} AND D.MAHOCVIEN = H.MAHOCVIEN AND D.DIEM < 5 GROUP BY D.MAHOCVIEN, MANHOM, MALOP, H.TENHOCVIEN", MaHocPhan, MaLop);
            var rs = LayDuLieu(sql);

            return rs;
        }
    }
}
