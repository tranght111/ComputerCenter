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
        public int MaLop { get; set; }
        public int MaHocPhan { get; set; }
        public int LanThi { get; set; }

        DiemThiDAO DT = new DiemThiDAO();

        public DataTable LayDSMonHoc(int MaKhoaHoc, int MaHocPhan)
        {
            return DT.LayDSMonHoc(MaKhoaHoc, MaHocPhan);
        }

        public DataTable LayDSHVThiDatCuaMonHocTrongLanThi(int MaHocPhan, int MaLop, int LanThi)
        {
            return DT.LayDSHVThiDatCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public DataTable LayDSHVHocLaiCuaMonHocTrongLanThi(int MaHocPhan, int MaLop, int LanThi)
        {
            return DT.LayDSHVHocLaiCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public DataTable LayDSLanThiCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DT.LayDSLanThiCuaMonHoc(MaHocPhan, MaLop);
        }

        public DataTable LayDSHVThiDatCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DT.LayDSHVThiDatCuaMonHoc(MaHocPhan, MaLop);
        }

        public DataTable LayDSHVHocLaiCuaMonHoc(int MaHocPhan, int MaLop)
        {
            return DT.LayDSHVHocLaiCuaMonHoc(MaHocPhan, MaLop);
        }
    }
}
