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

        HoaDonBUS hdo = new HoaDonBUS();
        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            hdo.NgayLap = dtpNgayLap.Value;
            hdo.MaKhoaHoc = Convert.ToInt32(textMaNVKToan.Text);
            hdo.TongTien = Convert.ToInt32(textTongTien.Text);
            hdo.MaHocVien = Convert.ToInt32(textMaHV.Text);
            hdo.TenHoaDon = textTenHD.Text;

            if (string.IsNullOrEmpty(textMaKH.Text))
            {
                hdo.MaKhoaHoc = 0;
            }
            else
                hdo.MaKhoaHoc = Convert.ToInt32(textMaKH.Text);

            if (string.IsNullOrEmpty(textMaPhieuPK.Text))
                hdo.MaPhieuPhucKhao = 0;
            else
                hdo.MaPhieuPhucKhao = Convert.ToInt32(textMaPhieuPK.Text);

            if (string.IsNullOrEmpty(textMaPhieuTN.Text))
                hdo.MaPhieuThiTN = 0;
            else
                hdo.MaPhieuThiTN = Convert.ToInt32(textMaPhieuTN.Text);
            HoaDonBUS.ThemHoaDon(hdo);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS.DangXuat();
            this.Close();
        }
    }
}
