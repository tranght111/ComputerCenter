using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    class NhomHocPhanDAO: XuLyDuLieu
    {
        public List<NhomHocPhanBUS> getNhomHPByMaKH(int makh)
        {
            string query = "Select * from NHOMHOCPHAN where MAKHOAHOC = " + makh.ToString();
            DataTable data = LayDuLieu(query);

            List<NhomHocPhanBUS> NhomHPList = new List<NhomHocPhanBUS>();

            foreach (DataRow row in data.Rows)
            {
                NhomHocPhanBUS nhom = new NhomHocPhanBUS(row);
                NhomHPList.Add(nhom);
            }
            return NhomHPList;
        }

        public DataTable LayDSNhomHPtheoMaKH(int makh)
        {
            DataTable data = new DataTable();
            string query = "exec proc_DSNhomHPcuaKH " + makh;

            data = LayDuLieu(query);

            return data;
        }
    }
}
