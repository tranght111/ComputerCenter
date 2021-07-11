using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenter.BUS;

namespace ComputerCenter.GUI
{
    public partial class MHNhapDiem : Form
    {

        public MHNhapDiem()
        {
            InitializeComponent();
        }

        /*public static void connection()
        {
            TypeDiemBUS.connection();
        }*/

        private void buttonDKTHP_Click(object sender, EventArgs e)
        {
            MHQuanLyDiemThiKetThucHocPhan dtkthp = new MHQuanLyDiemThiKetThucHocPhan();
            //this.Hide();
            dtkthp.Show();
        }

        private void buttonDTN_Click(object sender, EventArgs e)
        {
            MHQuanLyDiemThiTotNghiep dttn = new MHQuanLyDiemThiTotNghiep();
            //this.Hide();
            dttn.Show();
        }

        /*private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Quay về form trang chủ cho NVKhThi
            Application.Exit();
        }*/
    }
}
