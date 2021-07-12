using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.BUS;
using System.Windows.Forms;

namespace ComputerCenter.DAO
{
    public class DiemThiTotNghiepDAO: XuLyDuLieu
    {
        public static DataTable LayDSHVThiDatTotNghiep(int MaKhoaHoc)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM , G.TENGV AS GV_CHAMDIEM FROM DIEMTHITOTNGHIEP D, HOCVIEN H, GIANGVIEN G WHERE H.MAHOCVIEN = D.MAHOCVIEN AND D.MAKHOAHOC = {0} AND D.DIEM >= 5 AND G.MAGV = D.MAGV", MaKhoaHoc);
            var rs = XuLyDuLieu.LayDuLieu(sql);

            return rs;
        }

        // Xem diem thi tot nghiep 
        public static DataTable XemDiemTotNghiep()
        {
            SqlConnection conn = new SqlConnection(path);
            string sql = @"SELECT kh.TENKHOAHOC, d.MAHOCVIEN, d.DIEM 
                            FROM DIEMTHITOTNGHIEP d, DANGKYKHOAHOC dk, KHOAHOC kh
                            WHERE d.MAKHOAHOC=dk.MAKHOAHOC AND dk.MAKHOAHOC=kh.MAKHOAHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhap diem thi tn
        public static int AddDiemTNform(DiemThiTotNghiepBUS DTNBUS)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            var cmd = new SqlCommand("INSERT INTO DIEMTHITOTNGHIEP VALUES(" + DTNBUS.MaHVTN + ", " + DTNBUS.MaKHTN + ", " + DTNBUS.DiemTN + ", " + DTNBUS.MaGVTN + ", " + DTNBUS.MaPhieuTN + ") ", conn);
            var command = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm thành công!");

            return command;
        }
        //sua diem thi tn
        public static int EditDiemTNForm(float DiemTN, int MaHV, int MaKH)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            var cmd = new SqlCommand("UPDATE DIEMTHITOTNGHIEP SET DIEM = " + DiemTN + " WHERE MAKHOAHOC = " + MaKH + " AND MAHOCVIEN = " + MaHV, conn);
            var command = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Cập nhật thành công!");

            return command;
        }

        //xoa diem thi tot nghiep
        public static int DelDiemTNForm(int MaHV, int MaKH)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("DELETE FROM DIEMTHITOTNGHIEP WHERE MAHOCVIEN = " + MaHV + " AND MAKHOAHOC = " + MaKH, con);
            var command = cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!");
            con.Close();

            return command;
        }

        public static DataTable SearchDiemTNForm()
        {
            // Hàm tìm kiếm theo tiêu chí điểm >= 5
            SqlConnection con = new SqlConnection(path);
            con.Open();
            var adapter = new SqlDataAdapter("SELECT * FROM DIEMTHITOTNGHIEP WHERE DIEM >= 5", con);
            var table = new DataTable();
            adapter.Fill(table);

            con.Close();

            return table;
        }

        public static DataTable displayTNForm()
        {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                var table = new DataTable();
                var adapter = new SqlDataAdapter("DBO.SEE_DIEMTN", con);
                adapter.Fill(table);
                con.Close();
            return table;
        }

        public static DataTable cbbMaHVTNForm()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT DISTINCT(MAHOCVIEN) FROM DBO.DANGKYKHOAHOC";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableDiemTN = new DataTable();
            da.Fill(tableDiemTN);
            da.Dispose();

            return tableDiemTN;
        }

        public static DataTable cbbMaKHTNForm()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT DISTINCT(MAKHOAHOC) FROM DBO.DANGKYKHOAHOC";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableDiemTN = new DataTable();
            da.Fill(tableDiemTN);
            da.Dispose();

            return tableDiemTN;
        }

        public static DataTable cbbMaGVTNForm()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM DBO.GIANGVIEN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableDiemTN = new DataTable();
            da.Fill(tableDiemTN);
            da.Dispose();

            return tableDiemTN;
        }

        public static DataTable cbbMaPhieu_DkiTNForm()
        {
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM DBO.PHIEUDKTHITN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableDiemTN = new DataTable();
            da.Fill(tableDiemTN);
            da.Dispose();

            return tableDiemTN;
        }


        public DataTable LayDSTatCaHVTotNghiep()
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM , G.TENGV AS GV_CHAMDIEM FROM DIEMTHITOTNGHIEP D, HOCVIEN H, GIANGVIEN G WHERE H.MAHOCVIEN = D.MAHOCVIEN AND D.DIEM >= 5 AND G.MAGV = D.MAGV");
            var rs = LayDuLieu(sql);

            return rs;
        }
    }
}
