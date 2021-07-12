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
    class KhoaHocDAO
    {
       //Phát thay đường dẫn vô đây nữa nè 
       // Trang them cho dang nhap nv ke toan cho tui thu lun
        static string path = @"Data Source=DESKTOP-UML28IP;Initial Catalog=ComputerCentre;Integrated Security=True";
        public static DataTable LayDSKhoaHoc()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM KHOAHOC", conn);

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
    }
}

