using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenter.BUS;

namespace ComputerCenter.GUI
{
    public partial class MHLapDSHVTotNghiep : Form
    {
        KhoaHocBUS KH = new KhoaHocBUS();
        DiemThiTotNghiepBUS TN = new DiemThiTotNghiepBUS();

        public MHLapDSHVTotNghiep()
        {
            InitializeComponent();
        }

        private void MHLapDSHVTotNghiep_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = KhoaHocBUS.LayDSKhoaHocKTV();

            cbbKhoaHocKTV.ValueMember = "MAKHOAHOC";
            cbbKhoaHocKTV.DataSource = tableKhoaHoc;
            cbbKhoaHocKTV.DisplayMember = "MAKHOAHOC";
        }

        private void btnLapDS_Click(object sender, EventArgs e)
        {
            KH.MaKH = int.Parse(cbbKhoaHocKTV.Text);

            var table = DiemThiTotNghiepBUS.LayDSHVThiDatTotNghiep(KH.MaKH);

            dgvDSHVTotNghiep.DataSource = table;
        }
    }
}
