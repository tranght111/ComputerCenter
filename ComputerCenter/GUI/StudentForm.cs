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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnXemDiemMonHoc_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = DiemThiBUS.LayDSDiemCuaHocVien();
        }

        private void btnXemDiemTotNghiep_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = DiemThiTotNghiepBUS.LayDiemCuaHocVien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemLichThiKTHP_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = LichThiBUS.XemLichThiKTHP();
        }

        private void btnXemLichThiTN_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = LichThiBUS.XemLichThiTN();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDKKH_Click(object sender, EventArgs e)
        {
            MHXemLopHoc xemLH = new MHXemLopHoc();
            this.Hide();
            xemLH.ShowDialog();
            this.Show();
        }

        private void btnDSHVTN_Click(object sender, EventArgs e)
        {
            MHLapDSHVTotNghiep f = new MHLapDSHVTotNghiep();
            this.Hide();
            f.ShowDialog();
        }
    }
}
