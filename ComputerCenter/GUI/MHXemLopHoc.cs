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
    public partial class MHXemLopHoc : Form
    {
        public MHXemLopHoc()
        {
            if (Global.role != "GiangVien")
            {
                InitializeComponent();
                HienThiKH();
                
            }
            else
            {
                MHThongTinLopHoc t = new MHThongTinLopHoc();
                this.Close();
                t.Show();
            }

            if (Global.loginname != null)
                btnDangXuat.Enabled = true;
        }

        public void HienThiKH()
        {
            KhoaHocBUS khBus = new KhoaHocBUS();
            List<KhoaHocBUS> KHList = khBus.LayViewDSKhoaHoc();

            foreach (KhoaHocBUS item in KHList)
            {
                Button btn = new Button()
                {
                    Width = KhoaHocBUS.KHWidth,
                    Height = KhoaHocBUS.KHHeigh,
                    TextAlign = ContentAlignment.TopLeft,
                    BackColor = Color.LightCyan
                };
                btn.Text = "Khoa " + item.TenKH + "\n" + "*************************\n" + "Loai " + item.TenLoaiKH + "\nSo luong hoc vien toi da: " + item.SoLuong
                    + "\nHoc phi: " + item.HocPhi + "\nThoi gian bat dau: " + item.TimeBegin + "\n" + item.MoTa;
                btn.Click += btn_Click;
                btn.Tag = item;

                flpKhoaHoc.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            int makh = ((sender as Button).Tag as KhoaHocBUS).MaKH;
            string tenkh = ((sender as Button).Tag as KhoaHocBUS).TenKH;

            MHThongTinLopHoc lh = new MHThongTinLopHoc(makh, tenkh);
            //this.Hide();
            lh.ShowDialog();
            lh.Show();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MHDangNhap dn = new MHDangNhap();
            this.Hide();
            
            dn.Show();
            Global.loginname = null;
            Global.role = null;
        }
    }
}
