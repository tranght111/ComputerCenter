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
    public class HocPhanBUS
    {
        public int MaHocPhan { get; set; }


        public static DataTable LayDSNhomHocPhan(int MaKhoaHoc)
        {
            return HocPhanDAO.LayDSNhomHocPhan(MaKhoaHoc);
        }
    }
}
