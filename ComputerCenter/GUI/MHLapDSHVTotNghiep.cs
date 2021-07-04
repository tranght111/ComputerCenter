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
        KhoaHoc KH = new KhoaHoc();
        DiemThiTN TN = new DiemThiTN();

        public MHLapDSHVTotNghiep()
        {
            InitializeComponent();
        }

        private void MHLapDSHVTotNghiep_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = KH.LayDSKhoaHocKTV();

            cbbKhoaHocKTV.ValueMember = "MAKHOAHOC";
            cbbKhoaHocKTV.DataSource = tableKhoaHoc;
            cbbKhoaHocKTV.DisplayMember = "TENKHOAHOC";
        }

        private void btnLapDS_Click(object sender, EventArgs e)
        {
            KhoaHoc.MaKhoaHoc = cbbKhoaHocKTV.SelectedValue.ToString().Trim();

            var table = TN.LayDSHVThiDatTotNghiep(KhoaHoc.MaKhoaHoc);

            dgvDSHVTotNghiep.DataSource = table;
        }
    }
}
