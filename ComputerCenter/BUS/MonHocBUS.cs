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
    public class MonHocBUS
    {
        public string MaLop { get; set; }
        public string MaHocPhan { get; set; }


        MonHocDAO DT = new MonHocDAO();

        public DataTable LayDSMonHoc(string MaKhoaHoc, string MaHocPhan)
        {
            return DT.LayDSMonHoc(MaKhoaHoc, MaHocPhan);
        }

        public DataTable LayDSHVThiDatCuaMonHoc(MonHocBUS mh)
        {
            return DT.LayDSHVThiDatCuaMonHoc(mh);
        }

        public DataTable LayDSHVHocLaiCuaMonHoc(MonHocBUS mh)
        {
            return DT.LayDSHVHocLaiCuaMonHoc(mh);
        }

    }
}
