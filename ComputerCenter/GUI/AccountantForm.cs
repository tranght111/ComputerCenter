using ComputerCenter.BUS;
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
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemHDHocPhi_Click(object sender, EventArgs e)
        {
            dgvAccountant.DataSource = HoaDonBUS.LayDSHoaDonHocPhi();
        }

        private void btnXemHDThiTN_Click(object sender, EventArgs e)
        {
            dgvAccountant.DataSource = HoaDonBUS.LayDSHoaDonThiTN();
        }

        private void btnXemHDPhucKhao_Click(object sender, EventArgs e)
        {
            dgvAccountant.DataSource = HoaDonBUS.LayDSHoaDonPhucKhao();
        }

        private void btnTimKiemCacHDCuaHocVien_Click(object sender, EventArgs e)
        {
            int MaHocVien = Convert.ToInt32(txtMaHocVien.Text);
            dgvAccountant.DataSource = HoaDonBUS.TimTheoMaHocVien(MaHocVien);
        }
    }
}
