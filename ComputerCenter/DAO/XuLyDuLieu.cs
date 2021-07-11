using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    public class XuLyDuLieu
    {
        protected static string path = "Data Source=.\\MSSQLSERVER01;Initial Catalog=QL_TT_TINHOC;Integrated Security=True";

        private SqlConnection con = null;


        protected bool connectDB(string connectStr = null)
        {
            try
            {
                con = new SqlConnection(path + connectStr);
                con.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected void closeConnect()
        {
            con.Close();
        }

        protected string getConnectStr()
        {
            return path;
        }

        protected SqlConnection getSQLconnection()
        {
            return con;
        }


        
        //protected static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        protected static DataTable LayDuLieu(string sql)
        {
            SqlConnection conn = new SqlConnection(path);
        
            var dap = new SqlDataAdapter(sql, conn);
            var table = new DataTable();
            dap.Fill(table);

            return table;
        }

        protected static int ThucThi(string sql)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var rs = cmd.ExecuteNonQuery();
            conn.Close();

            return rs;
        }

        protected DataTable LoadDataWithParameters(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameters[i]);
                        i++;
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);

            return data;
        }
    }
}
