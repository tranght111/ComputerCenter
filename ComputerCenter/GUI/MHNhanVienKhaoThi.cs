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
            TaiKhoanBUS.DangXuat();
            this.Close();
            /*MHDangNhap f = new MHDangNhap();
            f.Show();*/
        }

        private void MHNhanVienKhaoThi_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.ShowDialog();
        }

        private void btnXemKhoaHoc_Click(object sender, EventArgs e)
        {
            MHQuanLyKhoaHoc f = new MHQuanLyKhoaHoc();
            f.ShowDialog();
        }

        //private void btnLapPhieuDKthiTn_Click(object sender, EventArgs e)
        //{
        //    MHLapPhieuDKiTN f = new MHLapPhieuDKiTN();
        //    f.ShowDialog();
        //}

        private void btnNhapDiemThi_Click(object sender, EventArgs e)
        {
            MHNhapDiem f = new MHNhapDiem();
            f.ShowDialog();
        }

        private void btnXemLH_Click(object sender, EventArgs e)
        {
            MHXemLopHoc f = new MHXemLopHoc();
            f.ShowDialog();
        }

        private void btnXemDSHV_Click(object sender, EventArgs e)
        {
            MHXemDanhSachHocVien f = new MHXemDanhSachHocVien();
            f.ShowDialog();
        }
    }
}
