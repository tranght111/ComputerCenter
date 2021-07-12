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
        NhomHocPhanBUS HP = new NhomHocPhanBUS();
        public MHLapDSHocVien()
        {
            InitializeComponent();
        }

        private void MHLapDSHocVien_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = KhoaHocBUS.LayDSKhoaHoc();

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
                table = DiemThiBUS.LayDSHVThiDatCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = int.Parse(cbbLanThi.Text);
                table = DiemThiBUS.LayDSHVThiDatCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
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
                table = DiemThiBUS.LayDSHVHocLaiCuaMonHoc(DT.MaHocPhan, DT.MaLop);
            }
            else
            {
                DT.LanThi = int.Parse(cbbLanThi.Text);
                table = DiemThiBUS.LayDSHVHocLaiCuaMonHocTrongLanThi(DT.MaHocPhan, DT.MaLop, DT.LanThi);
            }

            dgvDSHVHocLai.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);         

            var tableHocPhan = NhomHocPhanBUS.LayDSNhomHocPhan(KH.MaKH);

            cbbHocPhan.ValueMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;

            cbbHocPhan.DisplayMember = "MANHOM";
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.Manhom = int.Parse(cbbHocPhan.Text);
            KH.MaKH = int.Parse(cbbKhoaHoc.Text);

            var tableMonHoc = DiemThiBUS.LayDSMonHoc(KH.MaKH, HP.Manhom);

            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
            cbbMonHoc.DisplayMember = "MALOP";

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HP.Manhom = int.Parse(cbbHocPhan.Text);
            DT.MaLop = int.Parse(cbbMonHoc.Text);

            var tableLanThi = DiemThiBUS.LayDSLanThiCuaMonHoc(HP.Manhom, DT.MaLop);

            cbbLanThi.ValueMember = "LANTHI";
            cbbLanThi.DataSource = tableLanThi;
            cbbLanThi.DisplayMember = "LANTHI";
            cbbLanThi.SelectedIndex = -1;
        }
    }
}
