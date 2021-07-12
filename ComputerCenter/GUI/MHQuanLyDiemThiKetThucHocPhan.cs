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
    public partial class MHQuanLyDiemThiKetThucHocPhan : Form
    {

        public MHQuanLyDiemThiKetThucHocPhan()
        {
            InitializeComponent();

            cbbMaHVKTHP();
            cbbMaLopKTHP();
            cbbMaNhomHPKTHP();
        }

        private void buttonExitKTHPForm_Click(object sender, EventArgs e)
        {
            // Quay lại form TypeDiem(để chọn loại điểm khác hoặc thoát)
            MHQuanLyDiemThiKetThucHocPhan typediem = new MHQuanLyDiemThiKetThucHocPhan();
            this.Hide();
            typediem.Show();
        }

        private void buttonSeeKTHPForm_Click(object sender, EventArgs e)
        {
            var table = DiemThiBUS.displayDiemKTHPForm();
            dataGridViewKTHPForm.DataSource = table;
        }

        

        //private void comboBoxMaHVKTHP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaHVKTHP();
        //}

        private void cbbMaHVKTHP()
        {
            var tb = DiemThiBUS.cbbMaHVKTHPForm();

            comboBoxMaHVKTHP.ValueMember = "TENHOCVIEN";
            comboBoxMaHVKTHP.DataSource = tb;
            comboBoxMaHVKTHP.DisplayMember = "MAHOCVIEN";
        }

        //private void comboBoxMaLopKTHP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaLopKTHP();
        //}

        private void cbbMaLopKTHP()
        {
            var tb = NhomHocPhan_MonHocBUS.cbbMaLopKTHPForm();

            comboBoxMaLopKTHP.ValueMember = "MANHOM";
            comboBoxMaLopKTHP.DataSource = tb;
            comboBoxMaLopKTHP.DisplayMember = "MALOP";
        }

        //private void comboBoxMaNhomHPForm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbbMaNhomHPKTHP();
        //}

        private void cbbMaNhomHPKTHP()
        {
            var tb = NhomHocPhan_MonHocBUS.cbbMaLopKTHPForm();

            comboBoxMaNhomHPKTHPForm.ValueMember = "MALOP";
            comboBoxMaNhomHPKTHPForm.DataSource = tb;
            comboBoxMaNhomHPKTHPForm.DisplayMember = "MANHOM";
        }

        private void buttonAdd_DiemKTHP_Click(object sender, EventArgs e)
        {
            //Nhập điểm thi
            if (comboBoxMaHVKTHP.Text == "" || comboBoxMaLopKTHP.Text == "" || comboBoxMaNhomHPKTHPForm.Text == "" || textBoxLanThiKTHP.Text == "" || textBoxDiemKTHP.Text == "")
            {
                MessageBox.Show("Please fills in the blanks");
            }
            else
            {
                DiemThiBUS DKTHPBUS = new DiemThiBUS()
                {
                    MaHV = int.Parse(comboBoxMaHVKTHP.Text),
                    MaLop = int.Parse(comboBoxMaLopKTHP.Text),
                    MaHocPhan = int.Parse(comboBoxMaNhomHPKTHPForm.Text),
                    LanThi = int.Parse(textBoxLanThiKTHP.Text),
                    DiemKTHP = float.Parse(textBoxDiemKTHP.Text)                  
                };

                var commd = DiemThiBUS.AddDiemKTHPForm(DKTHPBUS);
                if(commd > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }

                clearDiemKTHPForm();
            }
        }

        private void buttonEditKTHPForm_Click(object sender, EventArgs e)
        {
            DiemThiBUS DKTHPBUS = new DiemThiBUS()
            {
                MaHV = int.Parse(comboBoxMaHVKTHP.Text),
                MaLop = int.Parse(comboBoxMaLopKTHP.Text),
                MaHocPhan = int.Parse(comboBoxMaNhomHPKTHPForm.Text),
                LanThi = int.Parse(textBoxLanThiKTHP.Text),
                DiemKTHP = float.Parse(textBoxDiemKTHP.Text)
            };

            var commd = DiemThiBUS.EditDiemKTHPForm(DKTHPBUS);
            if (commd > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }

            clearDiemKTHPForm();
        }

        private void buttonDeleteKTHPForm_Click(object sender, EventArgs e)
        {
            var commd = DiemThiBUS.DelDiemKTHPForm(int.Parse(comboBoxMaHVKTHP.Text), int.Parse(comboBoxMaLopKTHP.Text), int.Parse(comboBoxMaNhomHPKTHPForm.Text), int.Parse(textBoxLanThiKTHP.Text));
            if (commd > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void buttonSearchKTHPForm_Click(object sender, EventArgs e)
        {
            var table = DiemThiBUS.SearchDiemKTHPForm();
            dataGridViewKTHPForm.DataSource = table;
        }

        public void clearDiemKTHPForm()
        {
            comboBoxMaHVKTHP.Text = "";
            comboBoxMaLopKTHP.Text = "";
            comboBoxMaNhomHPKTHPForm.Text = "";
            textBoxLanThiKTHP.Text = "";
            textBoxDiemKTHP.Text = "";
        }

        private void dataGridViewKTHPForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMaHVKTHP.Text = dataGridViewKTHPForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxMaLopKTHP.Text = dataGridViewKTHPForm.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxMaNhomHPKTHPForm.Text = dataGridViewKTHPForm.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxLanThiKTHP.Text = dataGridViewKTHPForm.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxDiemKTHP.Text = dataGridViewKTHPForm.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}

