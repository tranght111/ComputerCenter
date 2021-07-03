using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ComputerCenter
{
    public partial class MHLapDSHocVien : Form
    {
        static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        SqlConnection conn = new SqlConnection(path);
        public MHLapDSHocVien()
        {
            InitializeComponent();
            conn.Open();
        }

        private void MHLapDSHocVien_Load(object sender, EventArgs e)
        {
            LayDSKhoaHoc();
            //LayDSNhomHocPhan();
        }

        void LayDSKhoaHoc()
        {
            var sql = new SqlCommand("SELECT MAKHOAHOC FROM KHOAHOC", conn);
            var dr = sql.ExecuteReader();

            var tableKhoaHoc = new DataTable();
            tableKhoaHoc.Load(dr);
            dr.Dispose();
            cbbKhoaHoc.DisplayMember = "MAKHOAHOC";
            cbbKhoaHoc.DataSource = tableKhoaHoc;
        }
        void LayDSNhomHocPhan()
        {
           /* var cmd = string.Format("SELECT MANHOM FROM NHOMHOCPHAN WHERE MAKHOAHOC = {0}",cbbKhoaHoc.);
            var sql = new SqlCommand(cmd, conn);
            var dr = sql.ExecuteReader();

            var tableKhoaHoc = new DataTable();
            tableKhoaHoc.Load(dr);
            dr.Dispose();
            cbbKhoaHoc.DisplayMember = "MANHOM";
            cbbKhoaHoc.DataSource = tableKhoaHoc;*/
        }

        private void btnDSHVThiDat_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM KHOAHOC K, DIEMTHIKTHP D, MONHOC M, HOCVIEN H, NHOMHOCPHAN N"
                  + " WHERE K.MAKHOAHOC = N.MAKHOAHOC AND N.MANHOM = M.MANHOM AND M.MALOP = D.MALOP AND D.DIEM >= 5 AND"
                  + " K.MAKHOAHOC = {0} AND D.MALOP = {1} AND H.MAHOCVIEN = D.MAHOCVIEN", cbbKhoaHoc.Text, cbbMonHoc.Text);

            var dap = new SqlDataAdapter(sql, conn);
            var table = new DataTable();
            dap.Fill(table);

            dgvDSHV.DataSource = table;
        }

        private void btnDSHVHocLai_Click(object sender, EventArgs e)
        {
            string sql ="SELECT D.MAHOCVIEN, H.TENHOCVIEN, D.DIEM FROM KHOAHOC K, DIEMTHIKTHP D, MONHOC M, HOCVIEN H, NHOMHOCPHAN N"
                   + " WHERE K.MAKHOAHOC = N.MAKHOAHOC AND N.MANHOM = M.MANHOM AND M.MALOP = D.MALOP AND D.DIEM < 5 AND K.MAKHOAHOC = 1 AND D.MALOP = 1 AND H.MAHOCVIEN = D.MAHOCVIEN";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvDSHV.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = string.Format("SELECT MANHOM FROM NHOMHOCPHAN WHERE MAKHOAHOC = {0}", cbbKhoaHoc.Text);
            var sql = new SqlCommand(cmd, conn);
            var dr = sql.ExecuteReader();

            var tableHocPhan = new DataTable();
            tableHocPhan.Load(dr);
            dr.Dispose();
            cbbHocPhan.DisplayMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = string.Format("SELECT MALOP FROM MONHOC WHERE MANHOM = {0}", cbbHocPhan.Text);
            var sql = new SqlCommand(cmd, conn);
            var dr = sql.ExecuteReader();

            var tableMonHoc = new DataTable();
            tableMonHoc.Load(dr);
            dr.Dispose();
            cbbMonHoc.DisplayMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
        }
    }
}
