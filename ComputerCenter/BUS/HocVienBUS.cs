using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;
namespace ComputerCenter.BUS
{
    class HocVienBUS
    {
        public string TenHV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        HocVienDAO hv = new HocVienDAO();

        public int ThemHocVien(HocVienBUS hocvien)
        {
            if (hv.KtraUsernameHopLe(hocvien) != 0) return -1;
            return hv.ThemHocVien(hocvien);
        }

        public DataTable XemDSHV(int makh, object manhom = null, object malop = null)
        {
            return hv.XemDSHV(makh, manhom, malop);
        }

        public DataTable XemTatCaHocVien()
        {
            return hv.XemTatCaHocVien();
        }

        public DataTable LayDSHVtheoMaKH(int makh)
        {
            return hv.LayDSHVtheoMaKH(makh);
        }

        public DataTable LayDSHVtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            return hv.LayDSHVtheoMaKH_MaNhomHP(makh, manhom);
        }

        public DataTable LayDSHVtheoMaKH_MaNhomHP_MaLop(int makh, int manhom, int malop)
        {
            return hv.LayDSHVtheoMaKH_MaNhomHP_MaLop(makh, manhom, malop);
        }

        public DataTable LayDSHVPKDiemTN()
        {
            return hv.LayDSHVPKDiemTN();
        }

        public DataTable LayDSHVPKDiemTNtheoKH(int makh)
        {
            return hv.LayDSHVPKDiemTNtheoKH(makh);
        }

        public DataTable LayDSHVPhucKhaoDiemKTHP()
        {
            return hv.LayDSHVPhucKhaoDiemKTHP();
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH(int makh)
        {
            return hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH(makh);
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            return hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP(makh, manhom);
        }

        public DataTable LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP_MaLop(int makh, int manhom, int malop)
        {
            return hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP_MaLop(makh, manhom, malop);
        }
    }
}
