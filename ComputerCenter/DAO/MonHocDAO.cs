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
    class MonHocDAO: XuLyDuLieu
    {
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
