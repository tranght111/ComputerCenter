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
        public MHThongTinLopHoc(int makh, string tenkh)
        {
            InitializeComponent();
            ShowLopHoc(makh);
            labelTenKH.Text = "Khoa hoc " + tenkh + "\nDanh sach lop hoc:";
        }

        void ShowLopHoc(int makh)
        {
            MonHocBUS mhBUS = new MonHocBUS();
            dgvLopHocInfo.DataSource = mhBUS.LayDSLopHocCuaKH(makh);

        }

        


        private void btnTroLai_Click_1(object sender, EventArgs e) //thoat form
        {
            this.Close();
        }

        private void btnDkyKH_Click(object sender, EventArgs e) // dang ky tai khoan
        {

        }
    }
}
