using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    public class NhomHocPhan_MonHocBUS
    {

        public static DataTable cbbMaLopKTHPForm()
        {
            return NhomHocPhan_MonHocDAO.LayDSNhomHocPhan_MonHoc();
        }
    }
}
