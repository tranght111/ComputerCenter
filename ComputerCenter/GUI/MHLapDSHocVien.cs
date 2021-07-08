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
using ComputerCenter.BUS;

namespace ComputerCenter
{
    public partial class MHLapDSHocVien : Form
    {
        MonHocBUS DT = new MonHocBUS();
        KhoaHocBUS KH = new KhoaHocBUS();
        HocPhanBUS HP = new HocPhanBUS();

        public MHLapDSHocVien()
        {
            InitializeComponent();
            //conn.Open();
        }

        private void MHLapDSHocVien_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = KH.LayDSKhoaHoc();

            cbbKhoaHoc.ValueMember = "MAKHOAHOC";
            cbbKhoaHoc.DataSource = tableKhoaHoc;
            cbbKhoaHoc.DisplayMember = "TENKHOAHOC";
        }

        private void btnDSHVThiDat_Click(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();
            DT.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();
            HP.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            var table = DT.LayDSHVThiDatCuaMonHoc(DT);
            dgvDSHV.DataSource = table;
        }

        private void btnDSHVHocLai_Click(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();
            DT.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();
            DT.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            var table = DT.LayDSHVHocLaiCuaMonHoc(DT);

            dgvDSHVHocLai.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();         

            var tableHocPhan = HP.LayDSNhomHocPhan(KH.MaKhoaHoc);
          
            //cbbHocPhan.SelectedIndex = -1;

            DataRow irow = tableHocPhan.NewRow();
            irow["TENNHOM"] = string.Empty;
            tableHocPhan.Rows.InsertAt(irow, 0);

            cbbHocPhan.ValueMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;
            cbbHocPhan.DisplayMember = "TENNHOM";
            cbbHocPhan.SelectedIndex = 0;
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();

            var tableMonHoc = DT.LayDSMonHoc(KH.MaKhoaHoc, HP.MaHocPhan);

            //cbbMonHoc.SelectedIndex = -1;
            DataRow irow = tableMonHoc.NewRow();
            irow["TENLOP"] = string.Empty;
            tableMonHoc.Rows.InsertAt(irow, 0);
   
            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
            cbbMonHoc.DisplayMember = "TENLOP";
            cbbMonHoc.SelectedIndex = 0;
        }
    }
}
