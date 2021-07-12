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
    class PhieuDKThiTNDAO:XuLyDuLieu
    {
        public static DataTable XemPhieuDangKyThiTN()
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT* FROM PHIEUDKTHITN");
            var dr = new SqlDataAdapter(cmd, conn);
            DataTable tablePHIEUDKTHITN = new DataTable();
            dr.Fill(tablePHIEUDKTHITN);
            return tablePHIEUDKTHITN;
        }
        public static void AddPieuDKThiTN(PhieuDKThiTNBUS dk)
        {
            HocVienBUS hv = new HocVienBUS();
            try
            {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand("DANGKYTHITOTNGHIEP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NGAYLAPPHIEU", SqlDbType.DateTime).Value = dk.NgayLapPhieu;
                cmd.Parameters.Add("@MAHOCVIEN", SqlDbType.Int).Value = hv.LayMaHVtheoUsername(Global.loginname);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record was added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No record added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable LayDSPhieuDangKyTNCuaHocVien(int MaHV)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT MAPHIEU FROM PHIEUDKTHITN WHERE MAHOCVIEN = {0}", MaHV);
            var dr = new SqlDataAdapter(cmd, conn);
            DataTable tablePHIEUDKTHITN = new DataTable();
            dr.Fill(tablePHIEUDKTHITN);
            return tablePHIEUDKTHITN;
        }
    }
}
