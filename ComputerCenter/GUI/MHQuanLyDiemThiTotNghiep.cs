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
    public partial class MHQuanLyDiemThiTotNghiep : Form
    {

        public MHQuanLyDiemThiTotNghiep()
        {
            InitializeComponent();
            //cbbMaHV_TN();
            //cbbMaKH_TN();
            //cbbMaGV_TN();
            //cbbMaPhieuDki_TN();
        }

        private void dataGridViewTNForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMaHVTN.DataBindings.Clear();
            comboBoxMaHVTN.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxMaKH_TN.DataBindings.Clear();
            comboBoxMaKH_TN.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDiemTN.DataBindings.Clear();
            textBoxDiemTN.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxMaGV_TN.DataBindings.Clear();
            comboBoxMaGV_TN.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxMaPhieuDkiTN.DataBindings.Clear();
            comboBoxMaPhieuDkiTN.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            //textBoxNgayLap.Text = dataGridViewTNForm.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        //private void comboBoxMaHVTN_SelectedIndexChanged(object sender, EventArgs e)
        //{ 
        //    cbbMaHV_TN();
        //}

        /*private void cbbMaHV_TN()
        {
            var tb = DiemThiTotNghiepBUS.cbbMaHVTN();

            comboBoxMaHVTN.ValueMember = "MAKHOAHOC";
            comboBoxMaHVTN.DataSource = tb;
            comboBoxMaHVTN.DisplayMember = "MAHOCVIEN";
        }*/

        //private void comboBoxMaKH_TN_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaKH_TN();
        //}

        /*private void cbbMaKH_TN()
        {
            var tb = DiemThiTotNghiepBUS.cbbMaKHTN();

            comboBoxMaKH_TN.ValueMember = "MAHOCVIEN";
            comboBoxMaKH_TN.DataSource = tb;
            comboBoxMaKH_TN.DisplayMember = "MAKHOAHOC";
        }
        */
        //private void comboBoxMaGV_TN_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaGV_TN();
        //}

        private void cbbMaGV_TN()
        {
            var tb = DiemThiTotNghiepBUS.cbbMaGVTN();

            comboBoxMaGV_TN.ValueMember = "TENGV";
            comboBoxMaGV_TN.DataSource = tb;
            comboBoxMaGV_TN.DisplayMember = "MAGV";
        }

        //private void comboBoxMaPhieuDkiTN_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaPhieuDki_TN();
        //}

        /*private void cbbMaPhieuDki_TN()
        {
            var tb = DiemThiTotNghiepBUS.cbbMaPhieu_DkiTN();

            comboBoxMaPhieuDkiTN.ValueMember = "NGAYLAPPHIEU";
            comboBoxMaPhieuDkiTN.DataSource = tb;
            comboBoxMaPhieuDkiTN.DisplayMember = "MAPHIEU";
        }*/

        public void clearDiemTNForm()
        {
            comboBoxMaHVTN.Text = "";
            comboBoxMaKH_TN.Text = "";
            comboBoxMaGV_TN.Text = "";
            comboBoxMaPhieuDkiTN.Text = "";
            textBoxDiemTN.Text = "";
            //textBoxNgayLap.Text = "";
        }

        private void buttonAdd_DiemTN_Click(object sender, EventArgs e)
        {
            if (comboBoxMaHVTN.Text == "" || comboBoxMaKH_TN.Text == "" || comboBoxMaGV_TN.Text == "" || comboBoxMaPhieuDkiTN.Text == "" || textBoxDiemTN.Text == "")
            {
                MessageBox.Show("Please fills in the blanks");
            }
            else
            {
                DiemThiTotNghiepBUS DTNBUS = new DiemThiTotNghiepBUS()
                {
                    MaHVTN = int.Parse(comboBoxMaHVTN.Text),
                    MaKHTN = int.Parse(comboBoxMaKH_TN.Text),
                    MaGVTN = int.Parse(comboBoxMaGV_TN.Text),
                    MaPhieuTN = int.Parse(comboBoxMaPhieuDkiTN.Text),
                    DiemTN = float.Parse(textBoxDiemTN.Text)
                };

                

                var commd = DiemThiTotNghiepBUS.AddDiemTNForm(DTNBUS);
                if (commd > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }

                clearDiemTNForm();

                //Demo INSERT INTO DIEMTHITOTNGHIEP(MAHOCVIEN, MAKHOAHOC, DIEM, MAGV, MAPHIEU_TN)
                //values(3, 4, 10, 1, 3)
            }
        }

        private void buttonSeeTNForm_Click(object sender, EventArgs e)
        {
            var table = DiemThiTotNghiepBUS.displayTN();
            dataGridViewTNForm.DataSource = table;
        }

        

        private void buttonEditTNForm_Click(object sender, EventArgs e)
        {
            DiemThiTotNghiepBUS DTNBUS = new DiemThiTotNghiepBUS()
            {
                MaHVTN = int.Parse(comboBoxMaHVTN.Text),
                MaKHTN = int.Parse(comboBoxMaKH_TN.Text),
                MaGVTN = int.Parse(comboBoxMaGV_TN.Text),
                MaPhieuTN = int.Parse(comboBoxMaPhieuDkiTN.Text),
                DiemTN = float.Parse(textBoxDiemTN.Text)
            };

            var commd = DiemThiTotNghiepBUS.EditDiemTNForm(float.Parse(textBoxDiemTN.Text), int.Parse(comboBoxMaHVTN.Text), int.Parse(comboBoxMaKH_TN.Text));
            if (commd > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }

            clearDiemTNForm();
        }

        private void buttonDeleteTNForm_Click(object sender, EventArgs e)
        {
            var commd = DiemThiTotNghiepBUS.DelDiemTNForm(int.Parse(comboBoxMaHVTN.Text), int.Parse(comboBoxMaKH_TN.Text));
            if (commd > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void buttonSearchTNForm_Click(object sender, EventArgs e)
        {
            var table = DiemThiTotNghiepBUS.SearchDiemTN();
            dataGridViewTNForm.DataSource = table;
        }

       private void buttonExitTNForm_Click(object sender, EventArgs e)
        {
            // Quay về form TypeDiem
           //TypeDiem tDiem = new TypeDiem();
            //this.Hide();
            //tDiem.Show();
        }

        private void MHQuanLyDiemThiTotNghiep_Load(object sender, EventArgs e)
        {
            //lay ds khoahoc KTV
            var table = KhoaHocBUS.LayDSKhoaHocKTV();

            comboBoxMaKH_TN.ValueMember = "MAKHOAHOC";
            comboBoxMaKH_TN.DataSource = table;
            comboBoxMaKH_TN.DisplayMember = "MAKHOAHOC";

            //lay ds Giaovien
            cbbMaGV_TN();
        }

        private void comboBoxMaKH_TN_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((comboBoxMaKH_TN.Text));

            var table = KhoaHocBUS.LayDSHocVienCuaKhoaHoc(int.Parse(comboBoxMaKH_TN.Text));

            comboBoxMaHVTN.ValueMember = "MAHOCVIEN";
            comboBoxMaHVTN.DataSource = table;
            comboBoxMaHVTN.DisplayMember = "MAHOCVIEN";
        }

        private void comboBoxMaHVTN_SelectedIndexChanged(object sender, EventArgs e)
        {
            var table = PhieuDKThiTNBUS.LayDSPhieuDangKyTNCuaHocVien(int.Parse(comboBoxMaHVTN.Text));

            comboBoxMaPhieuDkiTN.ValueMember = "MAPHIEU";
            comboBoxMaPhieuDkiTN.DataSource = table;
            comboBoxMaPhieuDkiTN.DisplayMember = "MAPHIEU";
        }
    }
}
