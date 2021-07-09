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
    public class KhoaHocBUS
    {
       public int MaKH { get; set; }

        public static DataTable LayDSKhoaHoc()
        {
            return KhoaHocDAO.LayDSKhoaHoc();
        }

        public static DataTable LayDSKhoaHocKTV()
        {
            return KhoaHocDAO.LayDSKhoaHocKTV();
        }
    }
}
