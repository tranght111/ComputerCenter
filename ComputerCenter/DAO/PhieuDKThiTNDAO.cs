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
    public class PhieuDKThiTNDAO
    {
        static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        public static DataTable displayPhieuDKiTNForm()
        {
                var con = new SqlConnection(path);
                con.Open();
                var table = new DataTable();
                var adapter = new SqlDataAdapter("DBO.SEE_PHIEUDKITHITN", con);
                adapter.Fill(table);
                con.Close();

            return table;
        }
        public static int AddPhieuDkiTNForm(PhieuDKThiTNBUS PDKTNBUS)
        {

            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("INSERT INTO PHIEUDKTHITN VALUES(" + PDKTNBUS.MaPhieuDKiTN + ", '" + PDKTNBUS.NgayLapPhieu + "') ", con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static int EditPhieuDkiTNForm(PhieuDKThiTNBUS PDKTNBUS)
        {
            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("UPDATE PHIEUDKTHITN SET NGAYLAPPHIEU = '" + PDKTNBUS.NgayLapPhieu + "' WHERE MAPHIEU = " + PDKTNBUS.MaPhieuDKiTN, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static int DelPhieuDkiTNForm(int MaPhieu)
        {
            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("DELETE FROM PHIEUDKTHITN WHERE MAPHIEU = " + MaPhieu, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static DataTable SearchPhieu(string NgayLapPhieu)
        {
            var con = new SqlConnection(path);
            con.Open();
            var adapter = new SqlDataAdapter("SELECT * FROM PHIEUDKTHITN WHERE NGAYLAPPHIEU LIKE '%" + NgayLapPhieu + "%'", con);
            var table = new DataTable();
            adapter.Fill(table);

            con.Close();

            return table;
        }
    }
}
