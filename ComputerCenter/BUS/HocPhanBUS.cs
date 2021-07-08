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
        public string MaHocPhan { get; set; }

        HocPhanDAO HP = new HocPhanDAO();

        public DataTable LayDSNhomHocPhan(string MaKhoaHoc)
        {
            return HP.LayDSNhomHocPhan(MaKhoaHoc);
        }
    }
}
