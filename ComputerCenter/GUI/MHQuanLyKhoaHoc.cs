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
    public partial class MHQuanLyKhoaHoc : Form
    {
        
        //KhoahocBUS obj = new KhoahocBUS();

        public MHQuanLyKhoaHoc()
        {
            InitializeComponent();
            DataComboBox();
        }

        private void dataGridView_KhoaHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu như click chuột 2 lần vào row trong bảng KHOAHOC thì có 2 TH:
            // Nếu user là HOCVIEN mới cần xem thông tin thì chạy thẳng tới bảng MONHOC(LOPHOC)
            // Nếu user là NVKTHI thì show form ThemLopHoc
            MHThemLopHoc tlh = new MHThemLopHoc();
            //this.Hide();
            tlh.Show();
        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            var table = KhoaHocBUS.display();
            dataGridView_KhoaHoc.DataSource = table;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxMaKH.Text == "" || textBoxTenKH.Text == "" || textBoxHocPhi.Text == "" || textBoxTimeBegin.Text == "" || textBoxMoTa.Text == "" || textBoxSoLuong.Text == "" || comboBoxMaLoaiKH.Text == "")
            {
                MessageBox.Show("Please fills in the blanks");
            }
            else
            {
                KhoaHocBUS KHBUS = new KhoaHocBUS()
                {
                    MaKH = int.Parse(textBoxMaKH.Text),
                    TenKH = textBoxTenKH.Text,
                    HocPhi = int.Parse(textBoxHocPhi.Text),
                    TimeBegin = textBoxTimeBegin.Text,
                    MoTa = textBoxMoTa.Text,
                    SoLuong = int.Parse(textBoxSoLuong.Text),
                    MaLoaiKH = int.Parse(comboBoxMaLoaiKH.Text)
                };
                var commd = KhoaHocBUS.AddKhoaHoc(KHBUS);
                if(commd > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }

                clear();
            }
        }

        public void clear()
        {
            textBoxMaKH.Text = "";
            textBoxTenKH.Text = "";
            textBoxHocPhi.Text = "";
            textBoxTimeBegin.Text = "";
            textBoxMoTa.Text = "";
            textBoxSoLuong.Text = "";
            comboBoxMaLoaiKH.Text = "";
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            KhoaHocBUS KHBUS = new KhoaHocBUS()
            {
                MaKH = int.Parse(textBoxMaKH.Text),
                TenKH = textBoxTenKH.Text,
                HocPhi = int.Parse(textBoxHocPhi.Text),
                TimeBegin = textBoxTimeBegin.Text,
                MoTa = textBoxMoTa.Text,
                SoLuong = int.Parse(textBoxSoLuong.Text),
                MaLoaiKH = int.Parse(comboBoxMaLoaiKH.Text)
            };
            var commd = KhoaHocBUS.EditKhoaHoc(KHBUS);
            if (commd > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }

            clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var commd = KhoaHocBUS.DelKhoahoc(int.Parse(textBoxMaKH.Text));
            if (commd > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void dataGridView_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaKH.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenKH.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxHocPhi.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTimeBegin.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxMoTa.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxMaLoaiKH.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxSoLuong.Text = dataGridView_KhoaHoc.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var table = KhoaHocBUS.SearchKhoahoc(textBoxTenKH.Text);
            dataGridView_KhoaHoc.DataSource = table;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Chỗ này sẽ thoát ra khỏi màn hình khóa học quay trở về form trang chủ
            Application.Exit();

        }

        //private void comboBoxMaLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataComboBox();
        //}

        private void DataComboBox()
        {
            var tb = KhoaHocBUS.cbbLayDanhSachLoaiKH();

            comboBoxMaLoaiKH.ValueMember = "TENLOAIKHOAHOC";
            comboBoxMaLoaiKH.DataSource = tb;
            comboBoxMaLoaiKH.DisplayMember = "MALOAI";
        }
    }
}


