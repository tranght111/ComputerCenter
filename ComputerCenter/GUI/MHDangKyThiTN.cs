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
    public partial class MHDangKyThiTN : Form
    {
        PhieuDKThiTNBUS dk = new PhieuDKThiTNBUS();
        public MHDangKyThiTN()
        {
            InitializeComponent();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            dk.NgayLapPhieu = dtpNgayLap.Value;
            PhieuDKThiTNBUS.AddPieuDKThiTN(dk);
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            dtgPhieuDK.DataSource = PhieuDKThiTNBUS.XemPhieuDangKyThiTN();
        }
        private void MHDangKyThiTN_Load(object sender, EventArgs e)
        {

        }

    }
}
