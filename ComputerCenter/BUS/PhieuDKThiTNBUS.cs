using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    class PhieuDKThiTNBUS
    {
        public int MaPhieuDKTN { set; get; }
        public DateTime NgayLapPhieu { set; get; }

        public static DataTable XemPhieuDangKyThiTN()
        {
            return PhieuDKThiTNDAO.XemPhieuDangKyThiTN();
        }
        public static void AddPieuDKThiTN(PhieuDKThiTNBUS dk)
        {
            PhieuDKThiTNDAO.AddPieuDKThiTN(dk);

        }

        public static DataTable LayDSPhieuDangKyTNCuaHocVien(int MaHV)
        {
            return PhieuDKThiTNDAO.LayDSPhieuDangKyTNCuaHocVien(MaHV);        }

    }
}
