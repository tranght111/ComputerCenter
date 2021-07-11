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
    public partial class MHXemDanhSachHocVien : Form
    {

        public MHXemDanhSachHocVien()
        {
            InitializeComponent();
            XemTatCaHocVien();
        }

        public void XemTatCaHocVien()
        {
            HocVienBUS hvBUS = new HocVienBUS();
            dgvXemDSHV.DataSource = hvBUS.XemTatCaHocVien();

        }

        public void XemDSHVtheoMaKH()
        {
            int maKH = (int)cbbKhoaHoc.SelectedValue;

            HocVienBUS hvBUS = new HocVienBUS();
            var listHV = hvBUS.LayDSHVtheoMaKH(maKH);
            dgvXemDSHV.DataSource = listHV;
        }

        private void cbbKhoaHoc_Click(object sender, EventArgs e)
        {
            DataTable listKH = new DataTable();

            listKH = KhoaHocBUS.LayDSKhoaHoc();

            cbbKhoaHoc.DataSource = listKH;
            cbbKhoaHoc.ValueMember = "MAKHOAHOC";
            cbbKhoaHoc.DisplayMember = "TENKHOAHOC";
        }

        private void cbbKhoaHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (checkBoxPKDiemTN.CheckState == CheckState.Checked)
            {
                XemDSHVPKDiemTN();
            }
            else
            {
                if (checkBoxDSHVTotNghiep.CheckState == CheckState.Checked)
                {
                    XemDSHVTotNghiep();
                }
                else
                {
                    if (checkBoxPKDiemKTHP.CheckState == CheckState.Checked)
                    {
                        XemDSHVPKDiemKTHP();

                        NhomHocPhanBUS t = new NhomHocPhanBUS();
                        int makh = (int)cbbKhoaHoc.SelectedValue;
                        var listNhomHP = t.LayDSNhomHPtheoMaKH(makh);

                        cbbMonHoc.Text = null;
                        cbbMonHoc.Enabled = false;
                        cbbNhomHP.Enabled = true;

                        cbbNhomHP.DataSource = listNhomHP;
                        cbbNhomHP.Text = null;
                    }
                    else
                    {
                        XemDSHVtheoMaKH();

                        NhomHocPhanBUS t = new NhomHocPhanBUS();
                        int makh = (int)cbbKhoaHoc.SelectedValue;
                        var listNhomHP = t.LayDSNhomHPtheoMaKH(makh);

                        cbbMonHoc.Text = null;
                        cbbMonHoc.Enabled = false;
                        cbbNhomHP.Enabled = true;

                        cbbNhomHP.DataSource = listNhomHP;
                        cbbNhomHP.Text = null;
                    }
                }
            }

            
        }

        
        void XemDSHVtheoMaKH_MaNhomHP()
        {
            int maKH = (int)cbbKhoaHoc.SelectedValue;
            int maNhom = (int)cbbNhomHP.SelectedValue;

            HocVienBUS hvBUS = new HocVienBUS();
            var listHV = hvBUS.LayDSHVtheoMaKH_MaNhomHP(maKH, maNhom);
            dgvXemDSHV.DataSource = listHV;
        }

        void XemDSHVtheoMaKH_MaNhomHP_MaLop()
        {
            int maKH = (int)cbbKhoaHoc.SelectedValue;
            int maNhom = (int)cbbNhomHP.SelectedValue;
            int maLop = (int)cbbMonHoc.SelectedValue;

            HocVienBUS hvBUS = new HocVienBUS();
            var listHV = hvBUS.LayDSHVtheoMaKH_MaNhomHP_MaLop(maKH, maNhom, maLop);
            dgvXemDSHV.DataSource = listHV;
        }

        private void cbbNhomHP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (checkBoxPKDiemKTHP.CheckState == CheckState.Checked)
            {
                XemDSHVPKDiemKTHP();
            }
            else XemDSHVtheoMaKH_MaNhomHP();

            int maKH = (int)cbbKhoaHoc.SelectedValue;
            int maNhom = (int)cbbNhomHP.SelectedValue;

            cbbMonHoc.Enabled = true;

            MonHocBUS mhBUS = new MonHocBUS();
            var listMH = mhBUS.LayDSMHtheoMaKH_MaNhomHP(maKH, maNhom);
            cbbMonHoc.DataSource = listMH;
            cbbMonHoc.Text = null;
        }

        private void cbbNhomHP_Click(object sender, EventArgs e)
        {
            cbbNhomHP.ValueMember = "MANHOM";
            cbbNhomHP.DisplayMember = "TENNHOM";
        }

        private void cbbMonHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (checkBoxPKDiemKTHP.CheckState == CheckState.Checked)
            {
                XemDSHVPKDiemKTHP();
            }
            else
            {
                XemDSHVtheoMaKH_MaNhomHP_MaLop();
            }
                
        }

        private void cbbMonHoc_Click(object sender, EventArgs e)
        {
            cbbMonHoc.ValueMember = "MALOP";
            cbbMonHoc.DisplayMember = "TENLOP";
        }

        void XemDSHVPKDiemKTHP()
        {
            HocVienBUS hv = new HocVienBUS();
            DataTable data = new DataTable();

            if (cbbKhoaHoc.SelectedIndex == -1)
            {
                dgvXemDSHV.DataSource = hv.LayDSHVPhucKhaoDiemKTHP();
            }
            else
            {
                int maKH = (int)cbbKhoaHoc.SelectedValue;
                dgvXemDSHV.DataSource = hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH(maKH);

                if (cbbNhomHP.SelectedIndex != -1)
                {
                    int maNhom = (int)cbbNhomHP.SelectedValue;
                    dgvXemDSHV.DataSource = hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP(maKH, maNhom);

                    if (cbbMonHoc.SelectedIndex != -1)
                    {
                        int maLop = (int)cbbMonHoc.SelectedValue;
                        dgvXemDSHV.DataSource = hv.LayDSHVPhucKhaoDiemKTHPtheoMaKH_MaNhomHP_MaLop(maKH, maNhom, maLop);
                    }
                }
                
            }
        }

        private void checkBoxPKDiemKTHP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPKDiemKTHP.CheckState == CheckState.Checked)
            {
                /*
                cbbMonHoc.Text = null;
                cbbNhomHP.Text = null;
                cbbNhomHP.Enabled = false;
                cbbMonHoc.Enabled = false;*/
                checkBoxPKDiemTN.Enabled = false;
                checkBoxDSHVTotNghiep.Enabled = false;

                XemDSHVPKDiemKTHP();
            }
            else
            {
                checkBoxPKDiemTN.Enabled = true;
                checkBoxDSHVTotNghiep.Enabled = true;

                if (cbbKhoaHoc.SelectedIndex == -1)
                {
                    XemTatCaHocVien();
                }
                else
                {
                    if (cbbNhomHP.SelectedIndex == -1)
                    {
                        if (cbbMonHoc.SelectedIndex == -1)
                            XemDSHVtheoMaKH();
                    }
                    else
                    {
                        if (cbbMonHoc.SelectedIndex == -1)
                            XemDSHVtheoMaKH_MaNhomHP();
                        else
                            XemDSHVtheoMaKH_MaNhomHP_MaLop();
                    }
                }
            }
        }

        void XemDSHVPKDiemTN()
        {
            HocVienBUS hv = new HocVienBUS();
            DataTable listHVPKDiemTN = new DataTable();

            if (cbbKhoaHoc.SelectedIndex == -1)
            {
                listHVPKDiemTN = hv.LayDSHVPKDiemTN();
            }
            else
            {
                int maKH = (int)cbbKhoaHoc.SelectedValue;
                listHVPKDiemTN = hv.LayDSHVPKDiemTNtheoKH(maKH);
            }

            dgvXemDSHV.DataSource = listHVPKDiemTN;
        }

        private void checkBoxPKDiemTN_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxPKDiemTN.CheckState == CheckState.Checked)
            {
                
                cbbMonHoc.Text = null;
                cbbNhomHP.Text = null;
                cbbNhomHP.Enabled = false;
                cbbMonHoc.Enabled = false;
                checkBoxPKDiemKTHP.Enabled = false;
                checkBoxDSHVTotNghiep.Enabled = false;

                XemDSHVPKDiemTN();
            }
            else
            {
                checkBoxPKDiemKTHP.Enabled = true;
                checkBoxDSHVTotNghiep.Enabled = true;

                if (cbbKhoaHoc.SelectedIndex == -1)
                {
                    XemTatCaHocVien();
                }
                else
                {
                    XemDSHVtheoMaKH();
                }
            }
            
        }

        void XemDSHVTotNghiep()
        {
            DiemThiTotNghiepBUS TN = new DiemThiTotNghiepBUS();
            DataTable listHVTotNghiep = new DataTable();

            if (cbbKhoaHoc.SelectedIndex == -1)
            {
                listHVTotNghiep = TN.LayDSTatCaHVTotNghiep();
            }
            else
            {
                int maKH = (int)cbbKhoaHoc.SelectedValue;
                listHVTotNghiep = DiemThiTotNghiepBUS.LayDSHVThiDatTotNghiep(maKH);
            }

            dgvXemDSHV.DataSource = listHVTotNghiep;
        }

        private void checkBoxDSHVTotNghiep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDSHVTotNghiep.CheckState == CheckState.Checked)
            {
                cbbMonHoc.Text = null;
                cbbNhomHP.Text = null;
                cbbNhomHP.Enabled = false;
                cbbMonHoc.Enabled = false;
                checkBoxPKDiemKTHP.Enabled = false;
                checkBoxPKDiemTN.Enabled = false;

                XemDSHVTotNghiep();
            }
            else
            {
                checkBoxPKDiemKTHP.Enabled = true;
                checkBoxPKDiemTN.Enabled = true;

                if (cbbKhoaHoc.SelectedIndex == -1)
                {
                    XemTatCaHocVien();
                }
                else
                {
                    XemDSHVtheoMaKH();
                }
            }
        }
    }
}
