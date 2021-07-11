using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComputerCenter;
using ComputerCenter.BUS;

namespace ComputerCenter.DAO
{
    public class MonHocDAO : XuLyDuLieu
    {
        // Chon lop hoc
        public static DataTable ChonLopHoc()
        {
            SqlConnection con = new SqlConnection(path);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MONHOC", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable displayLHForm()
        {
            var con = new SqlConnection(path);
            con.Open();
            var table = new DataTable();
            var adapter = new SqlDataAdapter("DBO.LAYDANHSACHLOPHOC", con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public static int EditLopHoc(MonHocBUS LHBUS)
        {
            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("UPDATE MONHOC SET TENLOP = '" + LHBUS.TenLop + "', HOCPHI = " + LHBUS.HocPhi + ", NGAYBATDAU = '" + LHBUS.NgayBatDau + "', GIOHOC = '" + LHBUS.GioHoc + "', MAGV = " + LHBUS.MaGV + " WHERE MALOP = " + LHBUS.MaLop, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        public static int DelLopHoc(int MaLop)
        {
            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("DELETE FROM MONHOC WHERE MALOP = " + MaLop, con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;
        }

        //public static int DelNHPMH(int MaLop, int MaNhom)
        //{
        //    con.Open();
        //    cmd = new SqlCommand("DELETE FROM NHOMHOCPHAN_MONHOC WHERE MALOP = " + MaLop + " AND MANHOM = " + MaNhom, con);
        //    var command1 = cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("Xóa thành công!");

        //    return command1;
        //}

        public static DataTable SearchLopHoc(string TenLop)
        {
            var con = new SqlConnection(path);
            con.Open();
            var adapter = new SqlDataAdapter("SELECT * FROM MONHOC WHERE TENLOP LIKE '%" + TenLop + "%' ", con);
            var table = new DataTable();
            adapter.Fill(table);
            con.Close();

            return table;
        }

        public static DataTable cbbMaGVLHForm()
        {
            var con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM GIANGVIEN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableGV = new DataTable();
            da.Fill(tableGV);
            da.Dispose();

            return tableGV;
        }

        public static DataTable cbbMaNhomHPLHForm()
        {
            var con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM NHOMHOCPHAN";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var tableNHP = new DataTable();
            da.Fill(tableNHP);
            da.Dispose();

            return tableNHP;
        }

        public static int AddLopHoc(MonHocBUS TLHBUS)
        {
            var con = new SqlConnection(path);
            con.Open();
            var cmd = new SqlCommand("INSERT INTO MONHOC VALUES(" + TLHBUS.MaLop + ", '" + TLHBUS.TenLop + "', " + TLHBUS.HocPhi + ", '" + TLHBUS.NgayBatDau + "', '" + TLHBUS.GioHoc + "', " + TLHBUS.MaGV + ") ", con);
            var command = cmd.ExecuteNonQuery();
            con.Close();

            return command;

        }

        public MonHocDAO() { }

        public List<MonHocBUS> getLopHocByMaLop(int malop)
        {
            string query = "Select * from MONHOC WHERE MALOP = " + malop.ToString();
            DataTable data = LayDuLieu(query);

            List<MonHocBUS> MHList = new List<MonHocBUS>();

            foreach (DataRow row in data.Rows)
            {
                MonHocBUS mh = new MonHocBUS(row);
                MHList.Add(mh);
            }
            return MHList;
        }

        public DataTable LayDSLopHocCuaKH(int makh)
        {
            XuLyDuLieu db = new XuLyDuLieu();
            connectDB();
            string query = "EXEC proc_DSLopHocCuaKhoaHoc " + makh;

            SqlCommand cmd = new SqlCommand(query, getSQLconnection());
            cmd.Parameters.AddWithValue("MaKhoaHoc", makh);
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            closeConnect();

            return data;
        }

        public DataTable LayDSMHtheoMaKH_MaNhomHP(int makh, int manhom)
        {
            DataTable data = new DataTable();

            string query = string.Format("exec proc_DSMonHoctheoMaKH_MaNhomHP '{0}', '{1}'", makh, manhom);
            data = LayDuLieu(query);

            return data;
        }
    }
}
