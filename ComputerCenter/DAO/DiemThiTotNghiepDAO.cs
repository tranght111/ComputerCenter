using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    public class DiemThiTotNghiepDAO: XuLyDuLieu
    {
        public static DataTable LayDSHVThiDatTotNghiep(int MaKhoaHoc)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM , G.TENGV AS GV_CHAMDIEM FROM DIEMTHITOTNGHIEP D, HOCVIEN H, GIANGVIEN G WHERE H.MAHOCVIEN = D.MAHOCVIEN AND D.MAKHOAHOC = {0} AND D.DIEM >= 5 AND G.MAGV = D.MAGV", MaKhoaHoc);
            var rs = XuLyDuLieu.LayDuLieu(sql);

            return rs;
        }

        // Xem diem thi tot nghiep 
        public static DataTable XemDiemTotNghiep()
        {
            SqlConnection conn = new SqlConnection(path);
            string sql = @"SELECT kh.TENKHOAHOC, d.MAHOCVIEN, d.DIEM 
                            FROM DIEMTHITOTNGHIEP d, DANGKYKHOAHOC dk, KHOAHOC kh
                            WHERE d.MAKHOAHOC=dk.MAKHOAHOC AND dk.MAKHOAHOC=kh.MAKHOAHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
