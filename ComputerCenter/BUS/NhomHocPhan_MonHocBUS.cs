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
        public int Malop { get ; set ; }
        public int Manhom { get ; set ; }

        public NhomHocPhan_MonHocBUS() { }

        public NhomHocPhan_MonHocBUS(DataRow row)
        {
            this.Malop = (int)row["MALOP"];
            this.Manhom = (int)row["MANHOM"];
        }

        public List<NhomHocPhan_MonHocBUS> getMaLopByMaNhom(int manhom)
        {
            NhomHocPhan_MonHocDAO t = new NhomHocPhan_MonHocDAO();
            return t.getMaLopByMaNhom(manhom);
        }

        public static DataTable cbbMaLopKTHPForm()
        {
            return NhomHocPhan_MonHocDAO.LayDSNhomHocPhan_MonHoc();
        }
    }
}
