
namespace ComputerCenter.GUI
{
    partial class MHQuanLyKhoaHoc
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
            this.dataGridView_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.labelHocPhi = new System.Windows.Forms.Label();
            this.textBoxHocPhi = new System.Windows.Forms.TextBox();
            this.labelTimeBegin = new System.Windows.Forms.Label();
            this.labeLMaLoai = new System.Windows.Forms.Label();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.textBoxMoTa = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxTimeBegin = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxMaLoaiKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_KhoaHoc
            // 
            this.dataGridView_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KhoaHoc.Location = new System.Drawing.Point(12, 313);
            this.dataGridView_KhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_KhoaHoc.Name = "dataGridView_KhoaHoc";
            this.dataGridView_KhoaHoc.RowHeadersWidth = 51;
            this.dataGridView_KhoaHoc.RowTemplate.Height = 24;
            this.dataGridView_KhoaHoc.Size = new System.Drawing.Size(917, 464);
            this.dataGridView_KhoaHoc.TabIndex = 0;
            this.dataGridView_KhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhoaHoc_CellClick);
            this.dataGridView_KhoaHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhoaHoc_CellDoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(237, 238);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 57);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(420, 238);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 57);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(613, 238);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 57);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(57, 238);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(117, 57);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Xem";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click_1);
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(9, 20);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(89, 17);
            this.labelMaKH.TabIndex = 5;
            this.labelMaKH.Text = "Mã khóa học";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(155, 20);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaKH.Multiline = true;
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(201, 22);
            this.textBoxMaKH.TabIndex = 6;
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(9, 73);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(95, 17);
            this.labelTenKH.TabIndex = 7;
            this.labelTenKH.Text = "Tên khóa học";
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(155, 73);
            this.textBoxTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenKH.Multiline = true;
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(201, 22);
            this.textBoxTenKH.TabIndex = 8;
            // 
            // labelHocPhi
            // 
            this.labelHocPhi.AutoSize = true;
            this.labelHocPhi.Location = new System.Drawing.Point(9, 130);
            this.labelHocPhi.Name = "labelHocPhi";
            this.labelHocPhi.Size = new System.Drawing.Size(56, 17);
            this.labelHocPhi.TabIndex = 9;
            this.labelHocPhi.Text = "Học phí";
            // 
            // textBoxHocPhi
            // 
            this.textBoxHocPhi.Location = new System.Drawing.Point(155, 130);
            this.textBoxHocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHocPhi.Multiline = true;
            this.textBoxHocPhi.Name = "textBoxHocPhi";
            this.textBoxHocPhi.Size = new System.Drawing.Size(201, 22);
            this.textBoxHocPhi.TabIndex = 10;
            // 
            // labelTimeBegin
            // 
            this.labelTimeBegin.AutoSize = true;
            this.labelTimeBegin.Location = new System.Drawing.Point(9, 190);
            this.labelTimeBegin.Name = "labelTimeBegin";
            this.labelTimeBegin.Size = new System.Drawing.Size(119, 17);
            this.labelTimeBegin.TabIndex = 11;
            this.labelTimeBegin.Text = "Thời gian bắt đầu";
            // 
            // labeLMaLoai
            // 
            this.labeLMaLoai.AutoSize = true;
            this.labeLMaLoai.Location = new System.Drawing.Point(401, 135);
            this.labeLMaLoai.Name = "labeLMaLoai";
            this.labeLMaLoai.Size = new System.Drawing.Size(115, 17);
            this.labeLMaLoai.TabIndex = 13;
            this.labeLMaLoai.Text = "Mã loại khóa học";
            // 
            // labelMoTa
            // 
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Location = new System.Drawing.Point(401, 20);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(43, 17);
            this.labelMoTa.TabIndex = 15;
            this.labelMoTa.Text = "Mô tả";
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Location = new System.Drawing.Point(540, 20);
            this.textBoxMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMoTa.Multiline = true;
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.Size = new System.Drawing.Size(201, 22);
            this.textBoxMoTa.TabIndex = 16;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(540, 78);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoLuong.Multiline = true;
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(201, 22);
            this.textBoxSoLuong.TabIndex = 17;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(401, 78);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(64, 17);
            this.labelSoLuong.TabIndex = 18;
            this.labelSoLuong.Text = "Số lượng";
            // 
            // textBoxTimeBegin
            // 
            this.textBoxTimeBegin.Location = new System.Drawing.Point(155, 190);
            this.textBoxTimeBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimeBegin.Multiline = true;
            this.textBoxTimeBegin.Name = "textBoxTimeBegin";
            this.textBoxTimeBegin.Size = new System.Drawing.Size(201, 22);
            this.textBoxTimeBegin.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(795, 238);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 57);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxMaLoaiKH
            // 
            this.comboBoxMaLoaiKH.FormattingEnabled = true;
            this.comboBoxMaLoaiKH.Location = new System.Drawing.Point(540, 135);
            this.comboBoxMaLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaLoaiKH.Name = "comboBoxMaLoaiKH";
            this.comboBoxMaLoaiKH.Size = new System.Drawing.Size(201, 24);
            this.comboBoxMaLoaiKH.TabIndex = 22;
            // 
            // MHQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 750);
            this.Controls.Add(this.comboBoxMaLoaiKH);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxTimeBegin);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxMoTa);
            this.Controls.Add(this.labelMoTa);
            this.Controls.Add(this.labeLMaLoai);
            this.Controls.Add(this.labelTimeBegin);
            this.Controls.Add(this.textBoxHocPhi);
            this.Controls.Add(this.labelHocPhi);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelMaKH);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView_KhoaHoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MHQuanLyKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khóa học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_KhoaHoc;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.Label labelHocPhi;
        private System.Windows.Forms.TextBox textBoxHocPhi;
        private System.Windows.Forms.Label labelTimeBegin;
        private System.Windows.Forms.Label labeLMaLoai;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.TextBox textBoxMoTa;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox textBoxTimeBegin;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxMaLoaiKH;
    }
}

