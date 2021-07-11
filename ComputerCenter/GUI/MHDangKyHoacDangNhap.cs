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
    public partial class MHDangKyHoacDangNhap : Form
    {
        public MHDangKyHoacDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MHDangKy dk = new MHDangKy();
            this.Close();
            dk.ShowDialog();
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MHDangNhap dn = new MHDangNhap();
            this.Close();
            dn.ShowDialog();
            
        }
    }
}
