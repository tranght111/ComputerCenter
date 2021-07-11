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
    public class DiemThiTotNghiepBUS
    {
        public int MaHVTN { get; set; }
        public int MaKHTN { get; set; }
        public float DiemTN { get; set; }
        public int MaGVTN { get; set; }
        public int MaPhieuTN { get; set; }

        public static DataTable LayDSHVThiDatTotNghiep(int MaKhoaHoc)
        {
            return DiemThiTotNghiepDAO.LayDSHVThiDatTotNghiep(MaKhoaHoc);
        }

        // Xem diem thi tot nghiep
        public static DataTable LayDiemCuaHocVien()
        {
            return DiemThiTotNghiepDAO.XemDiemTotNghiep();
        }

        public static int AddDiemTNForm(DiemThiTotNghiepBUS DTNBUS)
        {
            return DiemThiTotNghiepDAO.AddDiemTNform(DTNBUS);
        }

        public static int EditDiemTNForm(float DiemTN, int MaHV, int MaKH)
        {
            return DiemThiTotNghiepDAO.EditDiemTNForm(DiemTN, MaHV, MaKH);
        }


        public static int DelDiemTNForm(int MaHV, int MaKH)
        {
            return DiemThiTotNghiepDAO.DelDiemTNForm(MaHV, MaKH);
        }

        public static DataTable SearchDiemTN()
        {
            return DiemThiTotNghiepDAO.SearchDiemTNForm();
        }

        public static DataTable displayTN()
        {
            return DiemThiTotNghiepDAO.displayTNForm();
        }

        public static DataTable cbbMaHVTN()
        {
            return DiemThiTotNghiepDAO.cbbMaHVTNForm();
        }

        public static DataTable cbbMaKHTN()
        {
            return DiemThiTotNghiepDAO.cbbMaKHTNForm();
        }

        public static DataTable cbbMaGVTN()
        {
            return DiemThiTotNghiepDAO.cbbMaGVTNForm();
        }

        public static DataTable cbbMaPhieu_DkiTN()
        {
            return DiemThiTotNghiepDAO.cbbMaPhieu_DkiTNForm();
        }

        public DataTable LayDSTatCaHVTotNghiep()
        {
            return TN.LayDSTatCaHVTotNghiep();
        }
    }
}
