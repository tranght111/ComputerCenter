using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public static DataTable LayDSNhomHocPhan(int MaKhoaHoc)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT*FROM NHOMHOCPHAN WHERE MAKHOAHOC = {0}", MaKhoaHoc);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableHocPhan = new DataTable();
            dr.Fill(tableHocPhan);
            dr.Dispose();

            return tableHocPhan;
        }
        public static DataTable cbbLayDanhSachMaNhomHP()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM NHOMHOCPHAN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableNHP = new DataTable();
            da.Fill(tableNHP);
            da.Dispose();

            return tableNHP;
        }
    }
}
