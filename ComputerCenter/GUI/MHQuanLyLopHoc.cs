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
    public partial class MHQuanLyLopHoc : Form
    {
        
        public MHQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            cbbGVForm();
            //cbbNHPForm();
        }

        private void buttonSeeLHForm_Click(object sender, EventArgs e)
        {
            var table = MonHocBUS.displayLHForm();
            dataGridView_LopHocForm.DataSource = table;
        }



        private void buttonExitLHForm_Click(object sender, EventArgs e)
        {
            // Chỗ này quay lại giao diện KHOAHOC hoặc quay về form trang chủ(mng cho ý kiến nha!!)
            //Khoahoc KHForm = new Khoahoc();
            MHNhanVienKhaoThi f = new MHNhanVienKhaoThi();
            this.Close();
            f.Show();
;        }

        private void buttonEditLHForm_Click(object sender, EventArgs e)
        {
            MonHocBUS LHBUS = new MonHocBUS()
            {
                MaLop = int.Parse(textBoxMaLopForm.Text),
                TenLop = textBoxTenLopForm.Text,
                HocPhi = int.Parse(textBoxHocPhiLopForm.Text),
                NgayBatDau = textBoxTimeBeginLopForm.Text,
                GioHoc = textBoxGioHocForm.Text,
                MaGV = int.Parse(comboBoxMaGVForm.Text),
                //MaNhomHP = int.Parse(comboBoxMaNhomHPForm.Text)
            };

            var commd = MonHocBUS.EditLopHoc(LHBUS);
            if (commd > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }

            clearLopHocForm();
        }

        public void clearLopHocForm()
        {
            textBoxMaLopForm.Text = "";
            textBoxTenLopForm.Text = "";
            textBoxHocPhiLopForm.Text = "";
            textBoxTimeBeginLopForm.Text = "";
            textBoxGioHocForm.Text = "";
            comboBoxMaGVForm.Text = "";
            //comboBoxMaNhomHPForm.Text = "";
        }

        private void dataGridView_LopHocForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaLopForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenLopForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxHocPhiLopForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTimeBeginLopForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxGioHocForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxMaGVForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[5].Value.ToString();
            //comboBoxMaNhomHPForm.Text = dataGridView_LopHocForm.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonDeleteLHForm_Click(object sender, EventArgs e)
        {
            var commd = MonHocBUS.DelLopHoc(int.Parse(textBoxMaLopForm.Text)); 
            if (commd > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void buttonSearchLHForm_Click(object sender, EventArgs e)
        {
            var table = MonHocBUS.SearchLopHoc(textBoxTenLopForm.Text);
            dataGridView_LopHocForm.DataSource = table;
        }

        private void comboBoxMaGVForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbGVForm();
        }

        private void cbbGVForm()
        {
            var tb = MonHocBUS.cbbMaGVLHForm();

            comboBoxMaGVForm.ValueMember = "TENGV";
            comboBoxMaGVForm.DataSource = tb;
            comboBoxMaGVForm.DisplayMember = "MAGV";
        }

        //private void comboBoxMaNhomHPForm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbNHPForm();
        //}

        //private void cbbNHPForm()
        //{
        //    var tb = LopHocBUS.cbbMaNhomHPLHForm();

        //    comboBoxMaNhomHPForm.ValueMember = "TENNHOM";
        //    comboBoxMaNhomHPForm.DataSource = tb;
        //    comboBoxMaNhomHPForm.DisplayMember = "MANHOM";
        //}
    }
}
