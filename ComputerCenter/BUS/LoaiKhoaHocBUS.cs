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
    public class LoaiKhoaHocBUS
    {
        public int MaLoai;
        public string TenLoaiKhoaHoc;

        public static DataTable ChonKhoaHoc()
        {
            return LoaiKhoaHocDAO.ChonKhoaHoc();
        }
    }
}
