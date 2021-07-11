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
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int HocPhi { get; set; }
        public string NgayBatDau { get; set; }
        public string GioHoc { get; set; }
        public int MaGV { get; set; }

        public static DataTable ChonLopHoc()
        {
            return MonHocDAO.ChonLopHoc();
        }

        public static DataTable displayLHForm()
        {
            return MonHocDAO.displayLHForm();
        }

        public static int EditLopHoc(MonHocBUS LHBUS)
        {
            return MonHocDAO.EditLopHoc(LHBUS);
        }

        public static int DelLopHoc(int MaLop)
        {

            return MonHocDAO.DelLopHoc(MaLop);
        }

        public static DataTable SearchLopHoc(string TenLop)
        {
            return MonHocDAO.SearchLopHoc(TenLop);
        }

        public static DataTable cbbMaGVLHForm()
        {
            return MonHocDAO.cbbMaGVLHForm();
        }

        public static DataTable cbbMaNhomHPLHForm()
        {
            return MonHocDAO.cbbMaNhomHPLHForm();
        }

        public static int AddLopHoc(MonHocBUS TLHBUS)
        {

            return MonHocDAO.AddLopHoc(TLHBUS);
        }
    }
}
