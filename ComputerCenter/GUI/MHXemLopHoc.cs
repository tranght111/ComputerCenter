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
            InitializeComponent();
            HienThiKH();
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
                btn.Text = "Khoa " + item.Tenkhoahoc + "\n" + "*************************\n" + "Loai " + item.Loaikh + "\nSo luong hoc vien toi da: " + item.Sltoida
                    + "\nHoc phi: " + item.Hocphi + "\nThoi gian bat dau: " + item.Thoigianbatdau + "\n" + item.Mota;
                btn.Click += btn_Click;
                btn.Tag = item;

                flpKhoaHoc.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            int makh = ((sender as Button).Tag as KhoaHocBUS).MaKH;
            string tenkh = ((sender as Button).Tag as KhoaHocBUS).Tenkhoahoc;

            MHThongTinLopHoc lh = new MHThongTinLopHoc(makh, tenkh);
            //this.Hide();
            lh.ShowDialog();
            this.Show();

        }
    }
}
