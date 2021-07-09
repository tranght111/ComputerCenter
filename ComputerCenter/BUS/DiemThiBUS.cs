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
        public string MaLop { get; set; }
        public string MaHocPhan { get; set; }
        public string LanThi { get; set; }

        DiemThiDAO DT = new DiemThiDAO();

        public DataTable LayDSMonHoc(string MaKhoaHoc, string MaHocPhan)
        {
            return DT.LayDSMonHoc(MaKhoaHoc, MaHocPhan);
        }

        public DataTable LayDSHVThiDatCuaMonHocTrongLanThi(string MaHocPhan, string MaLop, string LanThi)
        {
            return DT.LayDSHVThiDatCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public DataTable LayDSHVHocLaiCuaMonHocTrongLanThi(string MaHocPhan, string MaLop, string LanThi)
        {
            return DT.LayDSHVHocLaiCuaMonHocTrongLanThi(MaHocPhan, MaLop, LanThi);
        }

        public DataTable LayDSLanThiCuaMonHoc(string MaHocPhan, string MaLop)
        {
            return DT.LayDSLanThiCuaMonHoc(MaHocPhan, MaLop);
        }

        public DataTable LayDSHVThiDatCuaMonHoc(string MaHocPhan, string MaLop)
        {
            return DT.LayDSHVThiDatCuaMonHoc(MaHocPhan, MaLop);
        }

        public DataTable LayDSHVHocLaiCuaMonHoc(string MaHocPhan, string MaLop)
        {
            return DT.LayDSHVHocLaiCuaMonHoc(MaHocPhan, MaLop);
        }
    }
}
