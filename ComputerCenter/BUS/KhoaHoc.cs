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
    public class KhoaHoc
    {
       public static string MaKhoaHoc;

        KhoaHocDB KH = new KhoaHocDB();

        public DataTable LayDSKhoaHoc()
        {
            return KH.LayDSKhoaHoc();
        }

        public DataTable LayDSKhoaHocKTV()
        {
            return KH.LayDSKhoaHocKTV();
        }
    }
}
