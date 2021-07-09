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
        DiemThiBUS DT = new DiemThiBUS();
        KhoaHocBUS KH = new KhoaHocBUS();
        HocPhanBUS HP = new HocPhanBUS();
        public MHLapDSHocVien()
        {
            InitializeComponent();
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
            DT.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
         
            var table = new DataTable();
            if (string.IsNullOrEmpty(cbbLanThi.Text))
            {
                table = DT.LayDSHVThiDatCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = cbbLanThi.SelectedValue.ToString().Trim();
                table = DT.LayDSHVThiDatCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
            }
            dgvDSHV.DataSource = table;
        }

        private void btnDSHVHocLai_Click(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();
            DT.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();
            DT.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();

            var table = new DataTable();
            if (string.IsNullOrEmpty(cbbLanThi.Text))
            {
                table = DT.LayDSHVHocLaiCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = cbbLanThi.SelectedValue.ToString().Trim();
                table = DT.LayDSHVHocLaiCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
            }

            dgvDSHVHocLai.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();         

            var tableHocPhan = HP.LayDSNhomHocPhan(KH.MaKhoaHoc);

            cbbHocPhan.ValueMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;

            cbbHocPhan.DisplayMember = "TENNHOM";
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            KH.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();

            var tableMonHoc = DT.LayDSMonHoc(KH.MaKhoaHoc, HP.MaHocPhan);

            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
            cbbMonHoc.DisplayMember = "TENLOP";

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            DT.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();

            var tableLanThi = DT.LayDSLanThiCuaMonHoc(HP.MaHocPhan, DT.MaLop);

            cbbLanThi.ValueMember = "LANTHI";
            cbbLanThi.DataSource = tableLanThi;
            cbbLanThi.DisplayMember = "LANTHI";
            cbbLanThi.SelectedIndex = -1;
        }
    }
}
