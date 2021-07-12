using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    class NhomHocPhanBUS
    {
        public int Manhom { get ; set ; }
        public string Tennhom { get ; set ; }
        public int Makhoahoc { get ; set ; }

        public NhomHocPhanBUS() { }

        public NhomHocPhanBUS(DataRow row)
        {
            this.Tennhom = row["TENNHOM"].ToString();
            this.Manhom = (int)row["MANHOM"];
            this.Makhoahoc = (int)row["MAKHOAHOC"];
        }

        NhomHocPhanDAO nhomHPDAO = new NhomHocPhanDAO();


        public List<NhomHocPhanBUS> getNhomHPByMaKH(int makh)
        {
            return nhomHPDAO.getNhomHPByMaKH(makh);
        }

        public List<int> getMaNhomByMaKH(int makh)
        {
            List<int> MaNhomList = new List<int>();
            foreach (NhomHocPhanBUS item in this.getNhomHPByMaKH(makh))
            {
                MaNhomList.Add(item.Manhom);
            }

            return MaNhomList;
        }

        public DataTable LayDSNhomHPtheoMaKH(int makh)
        {
            return nhomHPDAO.LayDSNhomHPtheoMaKH(makh);
        }

        public static DataTable LayDSNhomHocPhan(int MaKhoaHoc)
        {
            return NhomHocPhanDAO.LayDSNhomHocPhan(MaKhoaHoc);
        }

        public static DataTable cbbLayDanhSachMaNhomHP()
        {
            return NhomHocPhanDAO.cbbLayDanhSachMaNhomHP();
        }
    }
}
