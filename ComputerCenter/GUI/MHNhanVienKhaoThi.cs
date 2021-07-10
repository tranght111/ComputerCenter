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
            //chỗ này nò cục dàng
           //cái form này nó hide thui ạ nên cục dàng nàm quá nhiều lần nó sinh quá nhiều form bị lưu lại chiếm hết port để thực thi nên lỗi ạ
            this.Close();
            //cục dàng xử lí chỗ nào mò màn bấm đăng xuất đăng nhập show lại á
        }

        private void MHNhanVienKhaoThi_Load(object sender, EventArgs e)
        {

        }
    }
}
