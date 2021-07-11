using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    class KhoaHocDAO: XuLyDuLieu
    {
        //static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        public DataTable LayDSKhoaHoc()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOAHOC", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }

        public DataTable LayDSKhoaHocKTV()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM KHOAHOC WHERE MALOAI = 1", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }

        
        public List<KhoaHocBUS> LayViewDSKhoaHoc()
        {
            string query = "Select * from DSKhoaHoc";
            DataTable data = LayDuLieu(query);

            List<KhoaHocBUS> KHList = new List<KhoaHocBUS>();

            foreach (DataRow row in data.Rows)
            {
                KhoaHocBUS kh = new KhoaHocBUS(row);
                KHList.Add(kh);
            }
            return KHList;
        }

        public int DangKyKhoaHoc(int makh, int mahv)
        {
            string query = "insert into dbo.DANGKYKHOAHOC values (" + makh + ", " + mahv + ")";
            int rs = ThucThi(query);

            return rs;
        }

        public bool KtraSLHocVienDK(int makh)
        {
            string query = "exec proc_SLHocVienDKKhoaHoc " + makh;
            var t = LayDuLieu(query);
            int sldk = 0;
            foreach (DataRow item in t.Rows)
            {
                sldk = (int)item["SL"];
            }

            string query2 = "Select SOLUONGTOIDA from KHOAHOC where MAKHOAHOC = " + makh;
            t = LayDuLieu(query2);
            int max = 0;

            foreach (DataRow item in t.Rows)
            {
                max = (int)item["SOLUONGTOIDA"];
            }

            if (sldk < max)
                return true;
            return false;
        }
    }
}
