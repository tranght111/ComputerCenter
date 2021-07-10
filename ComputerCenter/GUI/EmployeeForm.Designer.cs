namespace ComputerCenter.GUI
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhongThi_Add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNVKTThi_Add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGioThi_Add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayThi_Add = new System.Windows.Forms.DateTimePicker();
            this.cbbKhoaHoc_Add = new System.Windows.Forms.ComboBox();
            this.cbbLop_Add = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLichThi_Add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.txtTenLichThi_Update = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaLichThi_Update = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGioThi_Update = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPhongThi_Update = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSuaLichThi = new System.Windows.Forms.Button();
            this.btnThemLichThi = new System.Windows.Forms.Button();
            this.btnXemLichThiTN = new System.Windows.Forms.Button();
            this.btnXemLichThiKTHP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(894, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(2, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 28;
            this.dgvEmployee.Size = new System.Drawing.Size(460, 431);
            this.dgvEmployee.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ngày thi:";
            // 
            // txtPhongThi_Add
            // 
            this.txtPhongThi_Add.Location = new System.Drawing.Point(98, 124);
            this.txtPhongThi_Add.Name = "txtPhongThi_Add";
            this.txtPhongThi_Add.Size = new System.Drawing.Size(111, 37);
            this.txtPhongThi_Add.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 82;
            this.label2.Text = "Phòng thi:";
            // 
            // txtNVKTThi_Add
            // 
            this.txtNVKTThi_Add.Location = new System.Drawing.Point(98, 223);
            this.txtNVKTThi_Add.Name = "txtNVKTThi_Add";
            this.txtNVKTThi_Add.Size = new System.Drawing.Size(111, 37);
            this.txtNVKTThi_Add.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 30);
            this.label7.TabIndex = 88;
            this.label7.Text = "NV gác thi:";
            // 
            // txtGioThi_Add
            // 
            this.txtGioThi_Add.Location = new System.Drawing.Point(98, 191);
            this.txtGioThi_Add.Name = "txtGioThi_Add";
            this.txtGioThi_Add.Size = new System.Drawing.Size(111, 37);
            this.txtGioThi_Add.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 30);
            this.label8.TabIndex = 86;
            this.label8.Text = "Giờ thi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayThi_Add);
            this.groupBox1.Controls.Add(this.cbbKhoaHoc_Add);
            this.groupBox1.Controls.Add(this.cbbLop_Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenLichThi_Add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNVKTThi_Add);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGioThi_Add);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhongThi_Add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(468, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 270);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập Lịch Thi";
            // 
            // dtpNgayThi_Add
            // 
            this.dtpNgayThi_Add.Location = new System.Drawing.Point(98, 159);
            this.dtpNgayThi_Add.Name = "dtpNgayThi_Add";
            this.dtpNgayThi_Add.Size = new System.Drawing.Size(111, 37);
            this.dtpNgayThi_Add.TabIndex = 97;
            // 
            // cbbKhoaHoc_Add
            // 
            this.cbbKhoaHoc_Add.FormattingEnabled = true;
            this.cbbKhoaHoc_Add.Location = new System.Drawing.Point(98, 91);
            this.cbbKhoaHoc_Add.Name = "cbbKhoaHoc_Add";
            this.cbbKhoaHoc_Add.Size = new System.Drawing.Size(111, 38);
            this.cbbKhoaHoc_Add.TabIndex = 95;
            this.cbbKhoaHoc_Add.SelectedIndexChanged += new System.EventHandler(this.cbbKhoaHoc_Add_SelectedIndexChanged);
            // 
            // cbbLop_Add
            // 
            this.cbbLop_Add.FormattingEnabled = true;
            this.cbbLop_Add.Location = new System.Drawing.Point(98, 57);
            this.cbbLop_Add.Name = "cbbLop_Add";
            this.cbbLop_Add.Size = new System.Drawing.Size(111, 38);
            this.cbbLop_Add.TabIndex = 94;
            this.cbbLop_Add.SelectedIndexChanged += new System.EventHandler(this.cbbLop_Add_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 96;
            this.label3.Text = "Khóa học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 94;
            this.label4.Text = "Lớp:";
            // 
            // txtTenLichThi_Add
            // 
            this.txtTenLichThi_Add.Location = new System.Drawing.Point(98, 26);
            this.txtTenLichThi_Add.Name = "txtTenLichThi_Add";
            this.txtTenLichThi_Add.Size = new System.Drawing.Size(111, 37);
            this.txtTenLichThi_Add.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 30);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tên Lịch Thi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgayThi);
            this.groupBox2.Controls.Add(this.txtTenLichThi_Update);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaLichThi_Update);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtGioThi_Update);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtPhongThi_Update);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(694, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 194);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa:";
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Location = new System.Drawing.Point(97, 113);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(111, 37);
            this.dtpNgayThi.TabIndex = 94;
            // 
            // txtTenLichThi_Update
            // 
            this.txtTenLichThi_Update.Location = new System.Drawing.Point(97, 53);
            this.txtTenLichThi_Update.Name = "txtTenLichThi_Update";
            this.txtTenLichThi_Update.Size = new System.Drawing.Size(111, 37);
            this.txtTenLichThi_Update.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 30);
            this.label11.TabIndex = 92;
            this.label11.Text = "Tên Lịch Thi:";
            // 
            // txtMaLichThi_Update
            // 
            this.txtMaLichThi_Update.Location = new System.Drawing.Point(97, 21);
            this.txtMaLichThi_Update.Name = "txtMaLichThi_Update";
            this.txtMaLichThi_Update.Size = new System.Drawing.Size(111, 37);
            this.txtMaLichThi_Update.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 30);
            this.label12.TabIndex = 90;
            this.label12.Text = "Mã Lịch Thi:";
            // 
            // txtGioThi_Update
            // 
            this.txtGioThi_Update.Location = new System.Drawing.Point(97, 145);
            this.txtGioThi_Update.Name = "txtGioThi_Update";
            this.txtGioThi_Update.Size = new System.Drawing.Size(111, 37);
            this.txtGioThi_Update.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 30);
            this.label14.TabIndex = 86;
            this.label14.Text = "Giờ thi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 30);
            this.label15.TabIndex = 84;
            this.label15.Text = "Ngày thi:";
            // 
            // txtPhongThi_Update
            // 
            this.txtPhongThi_Update.Location = new System.Drawing.Point(97, 83);
            this.txtPhongThi_Update.Name = "txtPhongThi_Update";
            this.txtPhongThi_Update.Size = new System.Drawing.Size(111, 37);
            this.txtPhongThi_Update.TabIndex = 83;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 30);
            this.label16.TabIndex = 82;
            this.label16.Text = "Phòng thi:";
            // 
            // btnSuaLichThi
            // 
            this.btnSuaLichThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnSuaLichThi.FlatAppearance.BorderSize = 0;
            this.btnSuaLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLichThi.ForeColor = System.Drawing.Color.White;
            this.btnSuaLichThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLichThi.Location = new System.Drawing.Point(696, 324);
            this.btnSuaLichThi.Name = "btnSuaLichThi";
            this.btnSuaLichThi.Size = new System.Drawing.Size(151, 42);
            this.btnSuaLichThi.TabIndex = 96;
            this.btnSuaLichThi.Text = "Sửa Lịch Thi";
            this.btnSuaLichThi.UseVisualStyleBackColor = false;
            this.btnSuaLichThi.Click += new System.EventHandler(this.btnSuaLichThi_Click);
            // 
            // btnThemLichThi
            // 
            this.btnThemLichThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnThemLichThi.FlatAppearance.BorderSize = 0;
            this.btnThemLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLichThi.ForeColor = System.Drawing.Color.White;
            this.btnThemLichThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichThi.Location = new System.Drawing.Point(539, 324);
            this.btnThemLichThi.Name = "btnThemLichThi";
            this.btnThemLichThi.Size = new System.Drawing.Size(151, 42);
            this.btnThemLichThi.TabIndex = 93;
            this.btnThemLichThi.Text = "Lập Lịch Thi";
            this.btnThemLichThi.UseVisualStyleBackColor = false;
            this.btnThemLichThi.Click += new System.EventHandler(this.btnThemLichThi_Click);
            // 
            // btnXemLichThiTN
            // 
            this.btnXemLichThiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemLichThiTN.FlatAppearance.BorderSize = 0;
            this.btnXemLichThiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichThiTN.ForeColor = System.Drawing.Color.White;
            this.btnXemLichThiTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichThiTN.Location = new System.Drawing.Point(696, 372);
            this.btnXemLichThiTN.Name = "btnXemLichThiTN";
            this.btnXemLichThiTN.Size = new System.Drawing.Size(151, 42);
            this.btnXemLichThiTN.TabIndex = 95;
            this.btnXemLichThiTN.Text = "Lich thi TN";
            this.btnXemLichThiTN.UseVisualStyleBackColor = false;
            this.btnXemLichThiTN.Click += new System.EventHandler(this.btnXemLichThiTN_Click_1);
            // 
            // btnXemLichThiKTHP
            // 
            this.btnXemLichThiKTHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemLichThiKTHP.FlatAppearance.BorderSize = 0;
            this.btnXemLichThiKTHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichThiKTHP.ForeColor = System.Drawing.Color.White;
            this.btnXemLichThiKTHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichThiKTHP.Location = new System.Drawing.Point(539, 372);
            this.btnXemLichThiKTHP.Name = "btnXemLichThiKTHP";
            this.btnXemLichThiKTHP.Size = new System.Drawing.Size(151, 42);
            this.btnXemLichThiKTHP.TabIndex = 94;
            this.btnXemLichThiKTHP.Text = "Lịch thi KTHP";
            this.btnXemLichThiKTHP.UseVisualStyleBackColor = false;
            this.btnXemLichThiKTHP.Click += new System.EventHandler(this.btnXemLichThiKTHP_Click_1);
            // 
            // EmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSuaLichThi);
            this.Controls.Add(this.btnXemLichThiTN);
            this.Controls.Add(this.btnXemLichThiKTHP);
            this.Controls.Add(this.btnThemLichThi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvEmployee);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNVKTThi_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGioThi_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhongThi_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLichThi_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenLichThi_Update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaLichThi_Update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGioThi_Update;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhongThi_Update;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbKhoaHoc_Add;
        private System.Windows.Forms.ComboBox cbbLop_Add;
        private System.Windows.Forms.Button btnSuaLichThi;
        private System.Windows.Forms.Button btnThemLichThi;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Button btnXemLichThiTN;
        private System.Windows.Forms.Button btnXemLichThiKTHP;
        private System.Windows.Forms.DateTimePicker dtpNgayThi_Add;
    }
}