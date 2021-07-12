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
    public class NhomHocPhan_MonHocDAO: XuLyDuLieu
    {
        public static DataTable LayDSNhomHocPhan_MonHoc()
        {
            string path = @"Data Source=DESKTOP-UML28IP;Initial Catalog=QL_TT_TINHOC;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con = new SqlConnection(path);
            string query = "SELECT * FROM NHOMHOCPHAN_MONHOC";
            var cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var table = new DataTable();
            da.Fill(table);
            da.Dispose();

            return table;
        }

        public List<NhomHocPhan_MonHocBUS> getMaLopByMaNhom(int manhom)
        {
            string query = "Select * from NHOMHOCPHAN_MONHOC WHERE MANHOM = " + manhom.ToString();
            DataTable data = LayDuLieu(query);

            List<NhomHocPhan_MonHocBUS> dataList = new List<NhomHocPhan_MonHocBUS>();

            foreach (DataRow row in data.Rows)
            {
                NhomHocPhan_MonHocBUS t = new NhomHocPhan_MonHocBUS(row);
                dataList.Add(t);
            }
            return dataList;
        }
    }
}
