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
    public class DiemThiTotNghiepBUS
    {
        DiemThiTotNghiepDAO TN = new DiemThiTotNghiepDAO();

        public DataTable LayDSHVThiDatTotNghiep(string MaKhoaHoc)
        {
            return TN.LayDSHVThiDatTotNghiep(MaKhoaHoc);
        }
    }
}
