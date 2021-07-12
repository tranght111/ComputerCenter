
namespace ComputerCenter.GUI
{
    partial class MHXemDanhSachHocVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDSHVTotNghiep = new System.Windows.Forms.CheckBox();
            this.checkBoxPKDiemTN = new System.Windows.Forms.CheckBox();
            this.checkBoxPKDiemKTHP = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbNhomHP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.dgvXemDSHV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Location = new System.Drawing.Point(1125, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(123, 38);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDSHVTotNghiep);
            this.panel1.Controls.Add(this.checkBoxPKDiemTN);
            this.panel1.Controls.Add(this.checkBoxPKDiemKTHP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbMonHoc);
            this.panel1.Controls.Add(this.cbbNhomHP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbKhoaHoc);
            this.panel1.Location = new System.Drawing.Point(31, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 176);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxDSHVTotNghiep
            // 
            this.checkBoxDSHVTotNghiep.AutoSize = true;
            this.checkBoxDSHVTotNghiep.Location = new System.Drawing.Point(32, 142);
            this.checkBoxDSHVTotNghiep.Name = "checkBoxDSHVTotNghiep";
            this.checkBoxDSHVTotNghiep.Size = new System.Drawing.Size(252, 21);
            this.checkBoxDSHVTotNghiep.TabIndex = 10;
            this.checkBoxDSHVTotNghiep.Text = "Xem danh sách học viên tốt nghiệp";
            this.checkBoxDSHVTotNghiep.UseVisualStyleBackColor = true;
            this.checkBoxDSHVTotNghiep.CheckedChanged += new System.EventHandler(this.checkBoxDSHVTotNghiep_CheckedChanged);
            // 
            // checkBoxPKDiemTN
            // 
            this.checkBoxPKDiemTN.AutoSize = true;
            this.checkBoxPKDiemTN.Location = new System.Drawing.Point(32, 103);
            this.checkBoxPKDiemTN.Name = "checkBoxPKDiemTN";
            this.checkBoxPKDiemTN.Size = new System.Drawing.Size(375, 21);
            this.checkBoxPKDiemTN.TabIndex = 9;
            this.checkBoxPKDiemTN.Text = "Xem danh sách học viên phúc khảo điểm thi tốt nghiệp";
            this.checkBoxPKDiemTN.UseVisualStyleBackColor = true;
            this.checkBoxPKDiemTN.CheckedChanged += new System.EventHandler(this.checkBoxPKDiemTN_CheckedChanged);
            // 
            // checkBoxPKDiemKTHP
            // 
            this.checkBoxPKDiemKTHP.AutoSize = true;
            this.checkBoxPKDiemKTHP.Location = new System.Drawing.Point(32, 64);
            this.checkBoxPKDiemKTHP.Name = "checkBoxPKDiemKTHP";
            this.checkBoxPKDiemKTHP.Size = new System.Drawing.Size(406, 21);
            this.checkBoxPKDiemKTHP.TabIndex = 8;
            this.checkBoxPKDiemKTHP.Text = "Xem danh sách học viên phúc khảo điểm kết thúc học phần";
            this.checkBoxPKDiemKTHP.UseVisualStyleBackColor = true;
            this.checkBoxPKDiemKTHP.CheckedChanged += new System.EventHandler(this.checkBoxPKDiemKTHP_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhóm học phần:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Enabled = false;
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(966, 22);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(221, 24);
            this.cbbMonHoc.TabIndex = 3;
            this.cbbMonHoc.SelectionChangeCommitted += new System.EventHandler(this.cbbMonHoc_SelectionChangeCommitted);
            this.cbbMonHoc.Click += new System.EventHandler(this.cbbMonHoc_Click);
            // 
            // cbbNhomHP
            // 
            this.cbbNhomHP.Enabled = false;
            this.cbbNhomHP.FormattingEnabled = true;
            this.cbbNhomHP.Location = new System.Drawing.Point(574, 22);
            this.cbbNhomHP.Name = "cbbNhomHP";
            this.cbbNhomHP.Size = new System.Drawing.Size(221, 24);
            this.cbbNhomHP.TabIndex = 2;
            this.cbbNhomHP.SelectionChangeCommitted += new System.EventHandler(this.cbbNhomHP_SelectionChangeCommitted);
            this.cbbNhomHP.Click += new System.EventHandler(this.cbbNhomHP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoá học:";
            // 
            // cbbKhoaHoc
            // 
            this.cbbKhoaHoc.FormattingEnabled = true;
            this.cbbKhoaHoc.Location = new System.Drawing.Point(119, 22);
            this.cbbKhoaHoc.Name = "cbbKhoaHoc";
            this.cbbKhoaHoc.Size = new System.Drawing.Size(221, 24);
            this.cbbKhoaHoc.TabIndex = 0;
            this.cbbKhoaHoc.SelectionChangeCommitted += new System.EventHandler(this.cbbKhoaHoc_SelectionChangeCommitted);
            this.cbbKhoaHoc.Click += new System.EventHandler(this.cbbKhoaHoc_Click);
            // 
            // dgvXemDSHV
            // 
            this.dgvXemDSHV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvXemDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDSHV.Location = new System.Drawing.Point(49, 238);
            this.dgvXemDSHV.Name = "dgvXemDSHV";
            this.dgvXemDSHV.RowHeadersWidth = 51;
            this.dgvXemDSHV.RowTemplate.Height = 24;
            this.dgvXemDSHV.Size = new System.Drawing.Size(1183, 503);
            this.dgvXemDSHV.TabIndex = 8;
            // 
            // MHXemDanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.dgvXemDSHV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangXuat);
            this.Name = "MHXemDanhSachHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHXemDanhSachHocVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDSHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvXemDSHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoaHoc;
        private System.Windows.Forms.ComboBox cbbNhomHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.CheckBox checkBoxDSHVTotNghiep;
        private System.Windows.Forms.CheckBox checkBoxPKDiemTN;
        private System.Windows.Forms.CheckBox checkBoxPKDiemKTHP;
    }
}