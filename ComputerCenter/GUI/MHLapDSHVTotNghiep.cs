﻿using System;
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
    public partial class MHLapDSHVTotNghiep : Form
    {
        KhoaHocBUS KH = new KhoaHocBUS();
        DiemThiTotNghiepBUS TN = new DiemThiTotNghiepBUS();

        public MHLapDSHVTotNghiep()
        {
            InitializeComponent();
        }

        private void MHLapDSHVTotNghiep_Load(object sender, EventArgs e)
        {
            var tableKhoaHoc = KH.LayDSKhoaHocKTV();

            cbbKhoaHocKTV.ValueMember = "MAKHOAHOC";
            cbbKhoaHocKTV.DataSource = tableKhoaHoc;
            cbbKhoaHocKTV.DisplayMember = "TENKHOAHOC";
        }

        private void btnLapDS_Click(object sender, EventArgs e)
        {
            KH.MaKhoaHoc = cbbKhoaHocKTV.SelectedValue.ToString().Trim();

            var table = TN.LayDSHVThiDatTotNghiep(KH.MaKhoaHoc);

            dgvDSHVTotNghiep.DataSource = table;
        }
    }
}
