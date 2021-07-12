using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    class PhieuPhucKhaoDAO:XuLyDuLieu
    {
        public static DataTable XemPhieuPhucKhaoTN()
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT P.MAPHIEUPHUCKHAO_DIEMTN, P.MAKHOAHOC, P.MAHOCVIEN FROM PHIEUPHUCKHAO_TN P, HOCVIEN H WHERE H.MAHOCVIEN = (SELECT MAHOCVIEN FROM HOCVIEN WHERE USERNAME = '{0}') AND H.MAHOCVIEN = P.MAHOCVIEN", Global.loginname);
            var dr = new SqlDataAdapter(cmd, conn);
            DataTable tablePHIEUPHUCKHAOTN = new DataTable();
            dr.Fill(tablePHIEUPHUCKHAOTN);
            return tablePHIEUPHUCKHAOTN;
        }
        public static DataTable XemPhieuPhucKhaoKTHP()
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT* FROM PHIEUPHUCKHAO_DIEMKTHP");
            var dr = new SqlDataAdapter(cmd, conn);
            DataTable tablePHIEUPHUCKHAOKTHP = new DataTable();
            dr.Fill(tablePHIEUPHUCKHAOKTHP);
            return tablePHIEUPHUCKHAOKTHP;
        }

        public static void ThemPhieuDangKyPhucKhao(PhieuPhucKhaoBUS p)
        {
            try
            {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand("DANGKYPHUCKHAO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = p.LyDo;
                cmd.Parameters.Add("@MAHV", SqlDbType.Int).Value = p.MaHV;
                cmd.Parameters.Add("@LANTHI", SqlDbType.Int).Value = p.LanThi;
                cmd.Parameters.Add("@MALOP", SqlDbType.Int).Value = p.MaLop;
                cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = p.MaKH;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("No record added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Record was added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

