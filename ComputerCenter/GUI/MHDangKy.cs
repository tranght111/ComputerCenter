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
    public partial class MHDangKy : Form
    {
        HocVienBUS hv = new HocVienBUS();


        public MHDangKy()
        {
            InitializeComponent();
        }

        private void MHDangKy_Load(object sender, EventArgs e)
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nu");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            HocVienBUS hv = new HocVienBUS()
            {
                TenHV = txtTen.Text,
                GioiTinh = cbbGioiTinh.Text,
                DiaChi = txtDiaChi.Text,
                NgaySinh = dtpNgaySinh.Value.ToString(),
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                Username = txtUser.Text,
                Password = txtPassword.Text
                };
            var rs = hv.ThemHocVien(hv);

            if(rs > 0 )
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("username đã tồn tại");
            }
        }
    }
}
