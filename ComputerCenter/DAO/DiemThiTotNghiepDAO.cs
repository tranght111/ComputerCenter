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
        public DataTable LayDSHVThiDatTotNghiep(int MaKhoaHoc)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM , G.TENGV AS GV_CHAMDIEM FROM DIEMTHITOTNGHIEP D, HOCVIEN H, GIANGVIEN G WHERE H.MAHOCVIEN = D.MAHOCVIEN AND D.MAKHOAHOC = {0} AND D.DIEM >= 5 AND G.MAGV = D.MAGV", MaKhoaHoc);
            var rs = LayDuLieu(sql);

            return rs;
        }
    }
}
