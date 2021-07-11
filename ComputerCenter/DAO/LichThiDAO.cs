using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComputerCenter;
using ComputerCenter.BUS;
using System.Windows.Forms;

namespace ComputerCenter.DAO
{
    public class LichThiDAO : XuLyDuLieu
    {
        // Xem lich thi KTHP
        public static DataTable XemLichThiKTHP()
        {
            SqlConnection con = new SqlConnection(path);
            string sql = @"SELECT kh.TENKHOAHOC, l.TENLICHTHI, mh.TENLOP, nhp.TENNHOM, l.PHONGTHI, l.NGAYTHI, l.GIOTHI
                            FROM LICHTHIKTHP lt, LICHTHI l, MONHOC mh, NHOMHOCPHAN_MONHOC hp, NHOMHOCPHAN nhp, KHOAHOC kh
                            WHERE lt.MALICHTHI_KTHP=l.MALICHTHI AND lt.MALOP=mh.MALOP and mh.MALOP= hp.MALOP and hp.MANHOM=nhp.MANHOM and kh.MAKHOAHOC=nhp.MAKHOAHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Xem lich thi tot nghiep 
        public static DataTable XemLichThiTN()
        {
            SqlConnection con = new SqlConnection(path);
            string sql = @"SELECT kh.TENKHOAHOC, l.TENLICHTHI, l.PHONGTHI, l.NGAYTHI, l.GIOTHI, l.MANVKTHI
                            FROM LICHTHITN lt, LICHTHI l, KHOAHOC kh
                            WHERE lt.MALICHTHI_TN=l.MALICHTHI AND lt.MAKHOAHOC=kh.MAKHOAHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Them lich thi 
        public static void ThemLichThi(LichThiBUS lt)
        {
            try
            {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand("THEMLICHTHI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENLICHTHI", SqlDbType.NVarChar).Value = lt.TenLichThi;
                cmd.Parameters.Add("@PHONGTHI", SqlDbType.VarChar).Value = lt.PhongThi;
                cmd.Parameters.Add("@NGAYTHI", SqlDbType.DateTime).Value = lt.NgayThi;
                cmd.Parameters.Add("@GIOTHI", SqlDbType.VarChar).Value = lt.GioThi;
                cmd.Parameters.Add("@MANVKT", SqlDbType.Int).Value = lt.MaNVKTThi;
                cmd.Parameters.Add("@MALOP", SqlDbType.Int).Value = lt.MaLop;
                cmd.Parameters.Add("@MAKHOAHOC", SqlDbType.Int).Value = lt.MaKhoaHoc;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                MessageBox.Show("Record was added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No record added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sua lich thi
        public static void SuaLichThi(LichThiBUS lt)
        {
            try
            {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand("CHINHSUALICHTHI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENLICHTHI", SqlDbType.NVarChar).Value = lt.TenLichThi;
                cmd.Parameters.Add("@PHONGTHI", SqlDbType.VarChar).Value = lt.PhongThi;
                cmd.Parameters.Add("@NGAYTHI", SqlDbType.DateTime).Value = lt.NgayThi;
                cmd.Parameters.Add("@GIOTHI", SqlDbType.VarChar).Value = lt.GioThi;
                cmd.Parameters.Add("@MALT", SqlDbType.Int).Value = lt.MaLichThi;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                MessageBox.Show("Record was updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No record updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
