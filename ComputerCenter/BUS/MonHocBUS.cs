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
        public int MaLop;
        public string TenLop;

        public static DataTable ChonLopHoc()
        {
            return MonHocDAO.ChonLopHoc();
        }
    }
}
