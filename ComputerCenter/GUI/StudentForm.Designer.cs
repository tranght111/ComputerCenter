namespace ComputerCenter.GUI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnXemLichThiTN = new System.Windows.Forms.Button();
            this.btnXemLichThiKTHP = new System.Windows.Forms.Button();
            this.btnXemDiemTotNghiep = new System.Windows.Forms.Button();
            this.btnXemDiemMonHoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(853, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(1, 1);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(502, 469);
            this.dgvStudent.TabIndex = 62;
            // 
            // btnXemLichThiTN
            // 
            this.btnXemLichThiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemLichThiTN.FlatAppearance.BorderSize = 0;
            this.btnXemLichThiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichThiTN.ForeColor = System.Drawing.Color.White;
            this.btnXemLichThiTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichThiTN.Location = new System.Drawing.Point(666, 49);
            this.btnXemLichThiTN.Name = "btnXemLichThiTN";
            this.btnXemLichThiTN.Size = new System.Drawing.Size(151, 42);
            this.btnXemLichThiTN.TabIndex = 69;
            this.btnXemLichThiTN.Text = "Lich thi TN";
            this.btnXemLichThiTN.UseVisualStyleBackColor = false;
            this.btnXemLichThiTN.Click += new System.EventHandler(this.btnXemLichThiTN_Click);
            // 
            // btnXemLichThiKTHP
            // 
            this.btnXemLichThiKTHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemLichThiKTHP.FlatAppearance.BorderSize = 0;
            this.btnXemLichThiKTHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichThiKTHP.ForeColor = System.Drawing.Color.White;
            this.btnXemLichThiKTHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichThiKTHP.Location = new System.Drawing.Point(509, 49);
            this.btnXemLichThiKTHP.Name = "btnXemLichThiKTHP";
            this.btnXemLichThiKTHP.Size = new System.Drawing.Size(151, 42);
            this.btnXemLichThiKTHP.TabIndex = 68;
            this.btnXemLichThiKTHP.Text = "Lịch thi KTHP";
            this.btnXemLichThiKTHP.UseVisualStyleBackColor = false;
            this.btnXemLichThiKTHP.Click += new System.EventHandler(this.btnXemLichThiKTHP_Click);
            // 
            // btnXemDiemTotNghiep
            // 
            this.btnXemDiemTotNghiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemDiemTotNghiep.FlatAppearance.BorderSize = 0;
            this.btnXemDiemTotNghiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiemTotNghiep.ForeColor = System.Drawing.Color.White;
            this.btnXemDiemTotNghiep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiemTotNghiep.Location = new System.Drawing.Point(666, 1);
            this.btnXemDiemTotNghiep.Name = "btnXemDiemTotNghiep";
            this.btnXemDiemTotNghiep.Size = new System.Drawing.Size(151, 42);
            this.btnXemDiemTotNghiep.TabIndex = 67;
            this.btnXemDiemTotNghiep.Text = "Điểm tốt nghiệp";
            this.btnXemDiemTotNghiep.UseVisualStyleBackColor = false;
            this.btnXemDiemTotNghiep.Click += new System.EventHandler(this.btnXemDiemTotNghiep_Click);
            // 
            // btnXemDiemMonHoc
            // 
            this.btnXemDiemMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemDiemMonHoc.FlatAppearance.BorderSize = 0;
            this.btnXemDiemMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiemMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnXemDiemMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiemMonHoc.Location = new System.Drawing.Point(509, 1);
            this.btnXemDiemMonHoc.Name = "btnXemDiemMonHoc";
            this.btnXemDiemMonHoc.Size = new System.Drawing.Size(151, 42);
            this.btnXemDiemMonHoc.TabIndex = 66;
            this.btnXemDiemMonHoc.Text = "Điểm KTHP";
            this.btnXemDiemMonHoc.UseVisualStyleBackColor = false;
            this.btnXemDiemMonHoc.Click += new System.EventHandler(this.btnXemDiemMonHoc_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.btnXemLichThiTN);
            this.Controls.Add(this.btnXemLichThiKTHP);
            this.Controls.Add(this.btnXemDiemTotNghiep);
            this.Controls.Add(this.btnXemDiemMonHoc);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnXemLichThiTN;
        private System.Windows.Forms.Button btnXemLichThiKTHP;
        private System.Windows.Forms.Button btnXemDiemTotNghiep;
        private System.Windows.Forms.Button btnXemDiemMonHoc;
    }
}