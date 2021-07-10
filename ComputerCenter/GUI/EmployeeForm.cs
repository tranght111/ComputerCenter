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
    public partial class EmployeeForm : Form
    {
        LichThiBUS lt = new LichThiBUS();
        LoaiKhoaHocBUS kh = new LoaiKhoaHocBUS();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void btnXemLichThiKTHP_Click(object sender, EventArgs e)
        //{
        //    dgvEmployee.DataSource = LichThiBUS.XemLichThiKTHP();
        //}

        //private void btnXemLichThiTN_Click(object sender, EventArgs e)
        //{
        //    dgvEmployee.DataSource = LichThiBUS.XemLichThiTN();
        //}

        //private void btnXemLichThiKTHP_Click_1(object sender, EventArgs e)
        //{
        //    dgvEmployee.DataSource = LichThiBUS.XemLichThiKTHP();
        //}

        //private void btnXemLichThiTN_Click_1(object sender, EventArgs e)
        //{
        //    dgvEmployee.DataSource = LichThiBUS.XemLichThiTN();
        //}

        private void btnSuaLichThi_Click(object sender, EventArgs e)
        {
            lt.TenLichThi = txtTenLichThi_Update.Text;
            lt.PhongThi = txtPhongThi_Update.Text;
            lt.NgayThi = dtpNgayThi.Value;
            lt.GioThi = txtGioThi_Update.Text;
            lt.MaLichThi = Convert.ToInt32(txtMaLichThi_Update.Text);
            LichThiBUS.SuaLichThi(lt);
        }

        private void btnXemLichThiTN_Click_1(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = LichThiBUS.XemLichThiTN();
        }

        private void btnXemLichThiKTHP_Click_1(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = LichThiBUS.XemLichThiKTHP();
        }

        private void btnThemLichThi_Click(object sender, EventArgs e)
        {
            lt.TenLichThi = txtTenLichThi_Add.Text;
            lt.PhongThi = txtPhongThi_Add.Text;
            lt.NgayThi = dtpNgayThi_Add.Value;
            lt.GioThi = txtGioThi_Add.Text;
            lt.MaNVKTThi = Convert.ToInt32(txtNVKTThi_Add.Text);

            if (string.IsNullOrEmpty(cbbLop_Add.Text))
                lt.MaLop = 0;
            else
                lt.MaLop = Convert.ToInt32(cbbLop_Add.SelectedValue);

            if (string.IsNullOrEmpty(cbbKhoaHoc_Add.Text))
                lt.MaKhoaHoc = 0;
            else
                lt.MaKhoaHoc = Convert.ToInt32(cbbLop_Add.SelectedValue);

            // lt.MaLop = Convert.ToInt32(cbbLop_Add.SelectedValue);
            // lt.MaKhoaHoc = Convert.ToInt32(cbbKhoaHoc_Add.SelectedValue);
            LichThiBUS.ThemLichThi(lt);
        }

        private void cbbLop_Add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbKhoaHoc_Add_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kh.MaLoai = int.Parse(cbbKhoaHoc_Add.Text);
            //kh.TenLoaiKhoaHoc = cbbKhoaHoc_Add.Text.ToString();
            //var tableKhoaHoc = LoaiKhoaHocBUS.ChonKhoaHoc();
            //cbbKhoaHoc_Add.DataSource = tableKhoaHoc;
            //cbbKhoaHoc_Add.DisplayMember = "TENLOAIKHOAHOC";
            //cbbKhoaHoc_Add.ValueMember = "MALOAI";
            
            //cbbKhoaHoc_Add.SelectedIndex = -1;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = LoaiKhoaHocBUS.ChonKhoaHoc();
            cbbKhoaHoc_Add.DataSource = tableKhoaHoc;
            cbbKhoaHoc_Add.DisplayMember = "TENLOAIKHOAHOC";
            cbbKhoaHoc_Add.ValueMember = "MALOAI";
            cbbKhoaHoc_Add.SelectedIndex = -1;

            var tableLopHoc = MonHocBUS.ChonLopHoc();
            cbbLop_Add.DataSource = tableLopHoc;
            cbbLop_Add.DisplayMember = "TENLOP";
            cbbLop_Add.ValueMember = "MALOP";
            cbbLop_Add.SelectedIndex = -1;
        }
    }
}
