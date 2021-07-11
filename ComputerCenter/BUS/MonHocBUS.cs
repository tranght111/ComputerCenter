using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    class MonHocBUS
    {
        public int Malop { get; set; }
        public string Tenlop { get; set; }
        public int Hocphi { get; set; }
        public DateTime Ngaybatdau { get; set; }
        public string Giohoc { get; set; }
        public int Magv { get; set; }

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

        MonHocDAO mhDAO = new MonHocDAO();


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
