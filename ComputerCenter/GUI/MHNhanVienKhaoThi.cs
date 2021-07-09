using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCenter.GUI
{
    public partial class MHNhanVienKhaoThi : Form
    {
        public MHNhanVienKhaoThi()
        {
            InitializeComponent();
        }

        private void btnLapHV_Click(object sender, EventArgs e)
        {
            MHLapDSHocVien f = new MHLapDSHocVien();
            f.Show();
        }

        private void btnLapDSTN_Click(object sender, EventArgs e)
        {
            MHLapDSHVTotNghiep f = new MHLapDSHVTotNghiep();
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MHDangNhap f = new MHDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
