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

        public static DataTable LayDSKhoaHoc()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOAHOC", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }

        public static DataTable LayDSKhoaHocKTV()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM KHOAHOC WHERE MALOAI = 1", conn);

            var tableKhoaHoc = new DataTable();
            da.Fill(tableKhoaHoc);
            da.Dispose();

            return tableKhoaHoc;
        }


        public static DataTable display()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            con.Open();
            var table = new DataTable();
            var adapter = new SqlDataAdapter("DBO.LAYDANHSACHKHOAHOC", con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public static int AddKhoaHoc(KhoaHocBUS KHBUS)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("INSERT INTO KHOAHOC VALUES(" + KHBUS.MaKH + ", '" + KHBUS.TenKH + "', " + KHBUS.HocPhi + ", '" + KHBUS.TimeBegin + "', '" + KHBUS.MoTa + "', " + KHBUS.MaLoaiKH + ", " + KHBUS.SoLuong + ") ", con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static int EditKhoaHoc(KhoaHocBUS KHBUS)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("UPDATE KHOAHOC SET TENKHOAHOC = '" + KHBUS.TenKH + "', HOCPHI = " + KHBUS.HocPhi + ", THOIGIANBATDAU = '" + KHBUS.TimeBegin + "', MOTA = '" + KHBUS.MoTa + "', SOLUONGTOIDA = " + KHBUS.SoLuong + ", MALOAI = " + KHBUS.MaLoaiKH + " WHERE MAKHOAHOC = " + KHBUS.MaKH, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static int DelKhoahoc(int MaKH)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("DELETE FROM KHOAHOC WHERE MAKHOAHOC = " + MaKH, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static DataTable SearchKhoahoc(string TenKH)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var adapter = new SqlDataAdapter("SELECT * FROM KHOAHOC WHERE TENKHOAHOC LIKE '%" + TenKH + "%' ", con);
            var table = new DataTable();
            adapter.Fill(table);
            con.Close();

            return table;
        }

        public static DataTable cbbLayDanhSachLoaiKH()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM LOAIKHOAHOC";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableLoaiKhoaHoc = new DataTable();
            da.Fill(tableLoaiKhoaHoc);
            da.Dispose();

            return tableLoaiKhoaHoc;
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

        public static DataTable LayDSHocVienCuaKhoaHoc(int MaKH)
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = string.Format("SELECT MAHOCVIEN FROM DANGKYKHOAHOC WHERE MAKHOAHOC = {0}", MaKH);
            //var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var table = new DataTable();
            da.Fill(table);
            da.Dispose();

            return table;

        }
    }
}
