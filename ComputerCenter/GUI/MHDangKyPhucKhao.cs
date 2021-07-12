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
    public partial class MHDangKyPhucKhao : Form
    {
          PhieuPhucKhaoBUS pkh = new PhieuPhucKhaoBUS();
            public MHDangKyPhucKhao()
            {
                InitializeComponent();
            }


            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void textMALOP_TextChanged(object sender, EventArgs e)
            {

            }

            private void buttonxXEMTN_Click(object sender, EventArgs e)
            {
                dtgPHUCKHAO.DataSource = PhieuPhucKhaoBUS.XemPhieuPhucKhaoTN();
            }

            private void buttonDANGKY_Click(object sender, EventArgs e)
            {
                pkh.LyDo = textLYDO.Text;
                pkh.MaHV = Convert.ToInt32(textMAHV.Text);

                if (string.IsNullOrEmpty(textMAKH.Text))
                {
                    pkh.MaKH = 0;
                }
                else
                    pkh.MaKH = Convert.ToInt32(textMAKH.Text);

                if (string.IsNullOrEmpty(textMALOP.Text))
                    pkh.MaLop = 0;
                else
                    pkh.MaLop = Convert.ToInt32(textMALOP.Text);

                if (string.IsNullOrEmpty(textLANTHI.Text))
                    pkh.LanThi = 0;
                else
                    pkh.LanThi = Convert.ToInt32(textLANTHI.Text);

                PhieuPhucKhaoBUS.ThemPhieuPhucKhao(pkh);
            }

            private void buttonXEMKTHP_Click(object sender, EventArgs e)
            {
                dtgPHUCKHAO.DataSource = PhieuPhucKhaoBUS.XemPhieuPhucKhaoKTHP();
            }

            private void MHDangKyPhucKhao_Load(object sender, EventArgs e)
            {

            }
        
    }
}
