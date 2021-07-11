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
    public class DiemThiBUS
    {
        public int MaHV { get; set; }
        public int MaLop { get; set; }
        public int MaHocPhan { get; set; }
        public int LanThi { get; set; }
        public float DiemKTHP { get; set; }

        public static DataTable LayDSMonHoc(int MaKhoaHoc, int MaHocPhan)
        {
            return DiemThiDAO.LayDSMonHoc(MaKhoaHoc, MaHocPhan);
        }

        public static DataTable LayDSHVThiDatCuaMonHocTrongLanThi(int MaHocPhan, int MaLop, int LanThi)
        {
            return DiemThiDAO.LayDSHVThiDatCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public static DataTable LayDSHVHocLaiCuaMonHocTrongLanThi(int MaHocPhan, int MaLop, int LanThi)
        {
            return DiemThiDAO.LayDSHVHocLaiCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public static DataTable LayDSLanThiCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DiemThiDAO.LayDSLanThiCuaMonHoc(MaHocPhan, MaLop);
        }

        public static DataTable LayDSHVThiDatCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DiemThiDAO.LayDSHVThiDatCuaMonHoc(MaHocPhan, MaLop);
        }

        public static DataTable LayDSHVHocLaiCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DiemThiDAO.LayDSHVHocLaiCuaMonHoc(MaHocPhan, MaLop);
        }

        // Xem diem thi ket thuc hoc phan
        public static DataTable LayDSDiemCuaHocVien()
        {
            return DiemThiDAO.XemDiemMonHoc();
        }

        public static DataTable cbbMaHVKTHPForm()
        {
            return DiemThiDAO.cbbMaHVKTHPForm();
        }

        public static DataTable displayDiemKTHPForm()
        {
            return DiemThiDAO.displayKTHP();
        }

        public static int AddDiemKTHPForm(DiemThiBUS DKTHPBUS)
        {
            return DiemThiDAO.AddDiemKTHPForm(DKTHPBUS);
        }

        public static int EditDiemKTHPForm(DiemThiBUS DKTPBUS)
        {
            return DiemThiDAO.EditDiemKTHPForm(DKTPBUS);
        }

        public static int DelDiemKTHPForm(int MaHV1, int MaLop1, int MaNhom1, int LanThi1)
        {
            return DiemThiDAO.DelDiemKTHPForm(MaHV1, MaLop1, MaNhom1, LanThi1);
        }

        public static DataTable SearchDiemKTHPForm()
        {
            return DiemThiDAO.SearchDiemKTHPForm();
        }
    }
}
