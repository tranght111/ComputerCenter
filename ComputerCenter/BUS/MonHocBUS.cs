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
        public MonHocBUS() { }

        public MonHocBUS(DataRow row)
        {
            this.Malop = (int)row["MALOP"];
            this.Tenlop = row["TENLOP"].ToString();
            //HOCPHI
            this.Ngaybatdau = (DateTime)row["NGAYBATDAU"];
            this.Giohoc = row["GIOHOC"].ToString();
            this.Magv = (int)row["MAGV"];
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
        MonHocDAO mhDAO = new MonHocDAO();

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

        public List<MonHocBUS> getLopHocByMaLop(int malop)
        {
            return mhDAO.getLopHocByMaLop(malop);
        }

        public DataTable LayDSLopHocCuaKH(int makh)
        {
            return mhDAO.LayDSLopHocCuaKH(makh);
        }

        public DataTable LayDSMHtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            return mhDAO.LayDSMHtheoMaKH_MaNhomHP(makh, manhom);
        }
    }
}
