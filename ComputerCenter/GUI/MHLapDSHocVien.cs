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
            cbbKhoaHoc.DisplayMember = "MAKHOAHOC";
        }

        private void btnDSHVThiDat_Click(object sender, EventArgs e)
        {
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);
            DT.MaLop = int.Parse(cbbMonHoc.Text);
            DT.MaHocPhan = int.Parse(cbbHocPhan.Text);
         
            var table = new DataTable();
            if (string.IsNullOrEmpty(cbbLanThi.Text))
            {
                table = DT.LayDSHVThiDatCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = int.Parse(cbbLanThi.Text);
                table = DT.LayDSHVThiDatCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
            }
            dgvDSHV.DataSource = table;
        }

        private void btnDSHVHocLai_Click(object sender, EventArgs e)
        {
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);
            DT.MaLop = int.Parse(cbbMonHoc.Text);
            DT.MaHocPhan = int.Parse(cbbHocPhan.Text);

            var table = new DataTable();
            if (string.IsNullOrEmpty(cbbLanThi.Text))
            {
                table = DT.LayDSHVHocLaiCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = int.Parse(cbbLanThi.Text);
                table = DT.LayDSHVHocLaiCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
            }

            dgvDSHVHocLai.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);         

            var tableHocPhan = HP.LayDSNhomHocPhan(KH.MaKH);

            cbbHocPhan.ValueMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;

            cbbHocPhan.DisplayMember = "MANHOM";
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.MaHocPhan = int.Parse(cbbHocPhan.Text);
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);

            var tableMonHoc = DT.LayDSMonHoc(KH.MaKH, HP.MaHocPhan);

            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
            cbbMonHoc.DisplayMember = "MALOP";

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.MaHocPhan = int.Parse(cbbHocPhan.Text);
            DT.MaLop = int.Parse(cbbMonHoc.Text);

            var tableLanThi = DT.LayDSLanThiCuaMonHoc(HP.MaHocPhan, DT.MaLop);

            cbbLanThi.ValueMember = "LANTHI";
            cbbLanThi.DataSource = tableLanThi;
            cbbLanThi.DisplayMember = "LANTHI";
            cbbLanThi.SelectedIndex = -1;
        }
    }
}
