using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComputerCenter.BUS;

namespace ComputerCenter.GUI
{
    public partial class MHThemLopHoc : Form
    {
        //ThemLopHocBUS obj = new ThemLopHocBUS();

        public MHThemLopHoc()
        {
            InitializeComponent();
            cbbGV();
            //cbbNHP();
        }

        private void buttonAddLop_Click(object sender, EventArgs e)
        {
            if (textBoxMaLop.Text == "" || textBoxTenLop.Text == "" || textBoxHocPhiLop.Text == "" || textBoxTimeBeginLop.Text == "" || textBoxGioHoc.Text == "" || comboBoxMaGV.Text == "")
            {
                MessageBox.Show("Please fills in the blanks");
            }
            else
            {
                MonHocBUS TLHBUS = new MonHocBUS()
                {
                    MaLop = int.Parse(textBoxMaLop.Text),
                    TenLop = textBoxTenLop.Text,
                    HocPhi = int.Parse(textBoxHocPhiLop.Text),
                    NgayBatDau = textBoxTimeBeginLop.Text,
                    GioHoc = textBoxGioHoc.Text,
                    MaGV = int.Parse(comboBoxMaGV.Text),
                    //MaNhomHP = int.Parse(comboBoxMaNhomHP.Text)
                };

                //NhomHP_MonHocBUS NHPMHBUS = new NhomHP_MonHocBUS()
                //{
                //    MaLop = int.Parse(textBoxMaLop.Text),
                //    MaNhom = int.Parse(comboBoxMaNhomHP.Text)
                //};
                var commd = MonHocBUS.AddLopHoc(TLHBUS);
                if (commd > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }

                clearLop();
            }
        }

        public void clearLop()
        {
            textBoxMaLop.Text = "";
            textBoxTenLop.Text = "";
            textBoxHocPhiLop.Text = "";
            textBoxTimeBeginLop.Text = "";
            textBoxGioHoc.Text = "";
            comboBoxMaGV.Text = "";
            //comboBoxMaNhomHP.Text = "";
        }

        private void buttonExitLop_Click(object sender, EventArgs e)
        {
            //Khoahoc kh = new Khoahoc();
            //this.Hide();
            //kh.Show();
            MHNhanVienKhaoThi f = new MHNhanVienKhaoThi();
            this.Close();
            f.Show();
        }

        private void buttonXemDSLH_Click(object sender, EventArgs e)
        {
            MHQuanLyLopHoc LH = new MHQuanLyLopHoc();
            //this.Hide();
            LH.Show();
        }

        private void comboBoxMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbGV();
        }

        private void cbbGV()
        {
            var tb = MonHocBUS.cbbMaGVLHForm();

            comboBoxMaGV.ValueMember = "TENGV";
            comboBoxMaGV.DataSource = tb;
            comboBoxMaGV.DisplayMember = "MAGV";
        }

        //private void comboBoxMaNhomHP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbNHP();
        //}

        //private void cbbNHP()
        //{
        //    var tb = ThemLopHocBUS.cbbLayDanhSachMaNhomHP();

        //    comboBoxMaNhomHP.ValueMember = "TENNHOM";
        //    comboBoxMaNhomHP.DataSource = tb;
        //    comboBoxMaNhomHP.DisplayMember = "MANHOM";
        //}
    }
}


