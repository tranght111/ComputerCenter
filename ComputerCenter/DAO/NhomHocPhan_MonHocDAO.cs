using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    class NhomHocPhan_MonHocDAO: XuLyDuLieu
    {
        public List<NhomHocPhan_MonHocBUS> getMaLopByMaNhom(int manhom)
        {
            string query = "Select * from NHOMHOCPHAN_MONHOC WHERE MANHOM = " + manhom.ToString();
            DataTable data = LayDuLieu(query);

            List<NhomHocPhan_MonHocBUS> dataList = new List<NhomHocPhan_MonHocBUS>();

            foreach (DataRow row in data.Rows)
            {
                NhomHocPhan_MonHocBUS t = new NhomHocPhan_MonHocBUS(row);
                dataList.Add(t);
            }
            return dataList;
        }
    }
}
