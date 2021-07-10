using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComputerCenter;

namespace ComputerCenter.DAO
{
    public class HoaDonDAO : XuLyDuLieu
    {
        // Xem hoa don hoc phi 
        public static DataTable XemHoaDonHocPhi()
        {
            SqlConnection con = new SqlConnection(path);
            string sql = @"SELECT h.MAHOADON, h.TENHOADON, hv.MAHOCVIEN, hv.TENHOCVIEN, kh.MAKHOAHOC, kh.TENKHOAHOC, h.TONGTIEN, h.NGAYLAP, nv.TENNV
                            FROM HOADONHOCPHI hd, HOADON h, KHOAHOC kh, HOCVIEN hv, NHANVIENKETOAN kt, NHANVIEN nv
                            WHERE hd.MAHOADON=h.MAHOADON and hd.MAKHOAHOC=kh.MAKHOAHOC and h.MAHOCVIEN=hv.MAHOCVIEN
	                        and h.MANVKTOAN=kt.MANVKTOAN and kt.MANVKTOAN=nv.MANV";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Xem hoa don tot nghiep
        public static DataTable XemHoaDonThiTN()
        {
            SqlConnection con = new SqlConnection(path);
            string sql = @"SELECT h.MAHOADON, h.TENHOADON, p.*, hv.MAHOCVIEN, hv.TENHOCVIEN, h.TONGTIEN, h.NGAYLAP, nv.TENNV
                            FROM HOADONTHITOTNGHIEP hd, HOADON h, PHIEUDKTHITN p, HOCVIEN hv, NHANVIENKETOAN kt, NHANVIEN nv
                            WHERE hd.MAHOADON=h.MAHOADON and hd.MAPHIEUTHITN=p.MAPHIEU and h.MAHOCVIEN=hv.MAHOCVIEN
	                        and h.MANVKTOAN=kt.MANVKTOAN and kt.MANVKTOAN=nv.MANV";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Xem hoa don phuc khao 
        public static DataTable XemHoaDonPhucKhao()
        {
            SqlConnection con = new SqlConnection(path);
            string sql = @"SELECT h.MAHOADON, h.TENHOADON, p.*, hv.MAHOCVIEN, hv.TENHOCVIEN, h.TONGTIEN, h.NGAYLAP, nv.TENNV
                            FROM HOADONPHUCKHAO hd, HOADON h, PHIEUPHUCKHAO p, HOCVIEN hv, NHANVIENKETOAN kt, NHANVIEN nv
                            WHERE hd.MAHOADON=h.MAHOADON and hd.MAPHIEUPHUCKHAO=p.MAPHIEUPHUCKHAO and h.MAHOCVIEN=hv.MAHOCVIEN
	                         and h.MANVKTOAN=kt.MANVKTOAN and kt.MANVKTOAN=nv.MANV";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Tim kiem cac hoa don cua 1 hoc vien cu the 
        public static DataTable TimTheoMaHocVien(int maHocVien)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiemCacHDCuaHocVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maHV", SqlDbType.Int).Value = maHocVien;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}