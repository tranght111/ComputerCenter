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
        DiemThi DT = new DiemThi();
        KhoaHoc KH = new KhoaHoc();
        HocPhan HP = new HocPhan();

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
            KhoaHoc.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();
            DiemThi.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();
            HocPhan.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            var table = DT.LayDSHVThiDat(KhoaHoc.MaKhoaHoc, DiemThi.MaLop);
            dgvDSHV.DataSource = table;
        }

        private void btnDSHVHocLai_Click(object sender, EventArgs e)
        {
            KhoaHoc.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();
            DiemThi.MaLop = cbbMonHoc.SelectedValue.ToString().Trim();
            HocPhan.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
            var table = DT.LayDSHVHocLai(KhoaHoc.MaKhoaHoc, DiemThi.MaLop);

            dgvDSHVHocLai.DataSource = table;
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhoaHoc.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString().Trim();         

            var tableHocPhan = HP.LayDSNhomHocPhan(KhoaHoc.MaKhoaHoc);
          
            cbbHocPhan.ValueMember = "MANHOM";
            cbbHocPhan.DataSource = tableHocPhan;
            
            cbbHocPhan.DisplayMember = "TENNHOM";
            //cbbHocPhan.SelectedIndex = -1;
        }


        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HocPhan.MaHocPhan = cbbHocPhan.SelectedValue.ToString().Trim();
         
            var tableMonHoc = DT.LayDSMonHoc(HocPhan.MaHocPhan);
            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DataSource = tableMonHoc;
            cbbMonHoc.DisplayMember = "TENLOP";
            //cbbMonHoc.SelectedIndex = -1;
        }
    }
}
