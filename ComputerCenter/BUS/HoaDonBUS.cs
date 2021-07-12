using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    public class HoaDonBUS
    {
        public int MaHoaDon;
        public int MaKhoaHoc;
        public int MaPhieuThiTN;
        public int MaPhieuPhucKhao;
        public string TenHoaDon;
        public DateTime NgayLap;
        public float TongTien;
        public int MaNVKeToan;
        public int MaHocVien;

        // Xem hoa don hoc phi 
        public static DataTable LayDSHoaDonHocPhi()
        {
            return HoaDonDAO.XemHoaDonHocPhi();
        }
        // Xem hoa don thi tot nghiep
        public static DataTable LayDSHoaDonThiTN()
        {
            return HoaDonDAO.XemHoaDonThiTN();
        }
        // Xem hoa don phuc khao
        public static DataTable LayDSHoaDonPhucKhao()
        {
            return HoaDonDAO.XemHoaDonPhucKhao();
        }
        // Tim kiem cac hoa don cua 1 hoc vien cu the
        public static DataTable TimTheoMaHocVien(int MaHocVien)
        {
            return HoaDonDAO.TimTheoMaHocVien(MaHocVien);
        }
        public static void ThemHoaDon(HoaDonBUS hd)
        {
            HoaDonDAO.ThemHoaDon(hd);
        }
    }
}
