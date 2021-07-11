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
    public partial class MHLapPhieuDKiTN : Form
    {
        public MHLapPhieuDKiTN()
        {
            InitializeComponent();
        }

        private void buttonSeePhieuForm_Click(object sender, EventArgs e)
        {
            var table = PhieuDKThiTNBUS.displayPhieuDKITNForm();
            dataGridViewLapPhieuDkiTN.DataSource = table;
        }

        private void buttonAdd_Phieu_Click(object sender, EventArgs e)
        {
            if (textBoxMaPhieu.Text == "" || textBoxNgayLap.Text == "")
            {
                MessageBox.Show("Please fills in the blanks");
            }
            else
            {
                PhieuDKThiTNBUS PDKTNBUS = new PhieuDKThiTNBUS()
                {
                    MaPhieuDKiTN = int.Parse(textBoxMaPhieu.Text),
                    NgayLapPhieu = textBoxNgayLap.Text
                };

                var commd = PhieuDKThiTNBUS.AddPhieuDKiTNForm(PDKTNBUS);
                if (commd > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }

                clearPhieuDKiTNForm();
            }
        }

        private void buttonDeletePhieu_Click(object sender, EventArgs e)
        {
            var commd = PhieuDKThiTNBUS.DelPhieuDKiTNForm(int.Parse(textBoxMaPhieu.Text));
            if (commd > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void buttonSearchPhieu_Click(object sender, EventArgs e)
        {
            var table = PhieuDKThiTNBUS.SearchPhieuDkiTN(textBoxNgayLap.Text);
            dataGridViewLapPhieuDkiTN.DataSource = table;
        }

        private void buttonEditPhieuForm_Click(object sender, EventArgs e)
        {
            PhieuDKThiTNBUS PDKTNBUS = new PhieuDKThiTNBUS()
            {
                MaPhieuDKiTN = int.Parse(textBoxMaPhieu.Text),
                NgayLapPhieu = textBoxNgayLap.Text
            };

            var commd = PhieuDKThiTNBUS.EditPhieuDKiTNForm(PDKTNBUS);
            if (commd > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }

            clearPhieuDKiTNForm();
        }

        private void buttonExitPhieu_Click(object sender, EventArgs e)
        {
            // Quay lại form trang chủ cho Nhân viên khảo thí
            Application.Exit();
        }

        private void dataGridViewLapPhieuDkiTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaPhieu.Text = dataGridViewLapPhieuDkiTN.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNgayLap.Text = dataGridViewLapPhieuDkiTN.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void clearPhieuDKiTNForm()
        {
            textBoxMaPhieu.Text = "";
            textBoxNgayLap.Text = "";
        }
    }
}
