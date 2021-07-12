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
    public partial class MHThongTinLopHoc : Form
    {
        int MaKH = 0;

        public MHThongTinLopHoc()
        {
            InitializeComponent();
            btnDkyKH.Enabled = false;
            int maGV = MonHocBUS.LayMaGVtheoUsername(Global.loginname);
            ShowLopHoctheoMaGV(maGV);
        }

        public MHThongTinLopHoc(int makh, string tenkh)
        {
            InitializeComponent();
            MaKH = makh;

            if (Global.role == "NhanVienKhaoThi")
                btnDkyKH.Enabled = false;
            ShowLopHoc(makh);
            labelTenKH.Text = "Khoa hoc " + tenkh + "\nDanh sach lop hoc:";
        }

        void ShowLopHoc(int makh)
        {
            MonHocBUS mhBUS = new MonHocBUS();
            dgvLopHocInfo.DataSource = mhBUS.LayDSLopHocCuaKH(makh);

        }

        void ShowLopHoctheoMaGV(int maGV)
        {
            dgvLopHocInfo.DataSource = MonHocBUS.LayDSLopHocCuaGV(maGV);
        }


        private void btnTroLai_Click_1(object sender, EventArgs e) //thoat form
        {
            this.Close();
        }

        private void btnDkyKH_Click(object sender, EventArgs e) //dang ky khoa hoc
        {
            string username = Global.loginname; // = username cua hoc vien khi dang nhap
            HocVienBUS hv = new HocVienBUS();
            int maHV = hv.LayMaHVtheoUsername(username);

            KhoaHocBUS kh = new KhoaHocBUS();

            if (kh.KtraSLHocVienDK(MaKH))
            {
                if (username != null)
                {
                    if (kh.DangKyKhoaHoc(MaKH, maHV) == 1)
                    {
                        MessageBox.Show("Đăng ký khoá học thành công! \nVui lòng đóng học phí để bắt đầu khoá học!");
                        StudentForm student = new StudentForm();
                        this.Close();
                        student.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error! Vui lòng đăng ký lại!");
                    }
                }
                else
                {
                    MHDangKyHoacDangNhap f = new MHDangKyHoacDangNhap();
                    this.Hide();
                    f.ShowDialog();
                    f.Show();
                }
            }
            else
                MessageBox.Show("Khoá học đã đủ học viên, vui lòng chọn khoá học khác!");

        }
    }
}
