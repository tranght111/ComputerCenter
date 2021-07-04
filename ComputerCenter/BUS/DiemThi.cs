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
    public class DiemThi
    {
        public static string MaLop;

        DiemThiDB DT = new DiemThiDB();

        public DataTable LayDSMonHoc(string MaHocPhan)
        {
            return DT.LayDSMonHoc(MaHocPhan);
        }

        public DataTable LayDSHVThiDat(string MaKhoaHoc, string MaLop)
        {
            return DT.LayDSHVThiDat(MaKhoaHoc, MaLop);
        }

        public DataTable LayDSHVHocLai(string MaKhoaHoc, string MaLop)
        {
            return DT.LayDSHVHocLai(MaKhoaHoc, MaLop);
        }

    }
}
