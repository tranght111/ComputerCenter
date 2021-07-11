namespace ComputerCenter.GUI
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.btnXemHDPhucKhao = new System.Windows.Forms.Button();
            this.btnXemHDThiTN = new System.Windows.Forms.Button();
            this.btnXemHDHocPhi = new System.Windows.Forms.Button();
            this.btnTimKiemCacHDCuaHocVien = new System.Windows.Forms.Button();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAccountant = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemHDPhucKhao
            // 
            this.btnXemHDPhucKhao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemHDPhucKhao.FlatAppearance.BorderSize = 0;
            this.btnXemHDPhucKhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHDPhucKhao.ForeColor = System.Drawing.Color.White;
            this.btnXemHDPhucKhao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHDPhucKhao.Location = new System.Drawing.Point(555, 168);
            this.btnXemHDPhucKhao.Name = "btnXemHDPhucKhao";
            this.btnXemHDPhucKhao.Size = new System.Drawing.Size(173, 42);
            this.btnXemHDPhucKhao.TabIndex = 87;
            this.btnXemHDPhucKhao.Text = "Hóa đơn phúc khảo";
            this.btnXemHDPhucKhao.UseVisualStyleBackColor = false;
            this.btnXemHDPhucKhao.Click += new System.EventHandler(this.btnXemHDPhucKhao_Click);
            // 
            // btnXemHDThiTN
            // 
            this.btnXemHDThiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemHDThiTN.FlatAppearance.BorderSize = 0;
            this.btnXemHDThiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHDThiTN.ForeColor = System.Drawing.Color.White;
            this.btnXemHDThiTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHDThiTN.Location = new System.Drawing.Point(555, 120);
            this.btnXemHDThiTN.Name = "btnXemHDThiTN";
            this.btnXemHDThiTN.Size = new System.Drawing.Size(173, 42);
            this.btnXemHDThiTN.TabIndex = 86;
            this.btnXemHDThiTN.Text = "Hóa đơn thi TN";
            this.btnXemHDThiTN.UseVisualStyleBackColor = false;
            this.btnXemHDThiTN.Click += new System.EventHandler(this.btnXemHDThiTN_Click);
            // 
            // btnXemHDHocPhi
            // 
            this.btnXemHDHocPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXemHDHocPhi.FlatAppearance.BorderSize = 0;
            this.btnXemHDHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHDHocPhi.ForeColor = System.Drawing.Color.White;
            this.btnXemHDHocPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHDHocPhi.Location = new System.Drawing.Point(555, 72);
            this.btnXemHDHocPhi.Name = "btnXemHDHocPhi";
            this.btnXemHDHocPhi.Size = new System.Drawing.Size(173, 42);
            this.btnXemHDHocPhi.TabIndex = 85;
            this.btnXemHDHocPhi.Text = "Hóa đơn học phí";
            this.btnXemHDHocPhi.UseVisualStyleBackColor = false;
            this.btnXemHDHocPhi.Click += new System.EventHandler(this.btnXemHDHocPhi_Click);
            // 
            // btnTimKiemCacHDCuaHocVien
            // 
            this.btnTimKiemCacHDCuaHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnTimKiemCacHDCuaHocVien.FlatAppearance.BorderSize = 2;
            this.btnTimKiemCacHDCuaHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemCacHDCuaHocVien.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimKiemCacHDCuaHocVien.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemCacHDCuaHocVien.Image")));
            this.btnTimKiemCacHDCuaHocVien.Location = new System.Drawing.Point(734, 13);
            this.btnTimKiemCacHDCuaHocVien.Name = "btnTimKiemCacHDCuaHocVien";
            this.btnTimKiemCacHDCuaHocVien.Size = new System.Drawing.Size(38, 28);
            this.btnTimKiemCacHDCuaHocVien.TabIndex = 84;
            this.btnTimKiemCacHDCuaHocVien.UseVisualStyleBackColor = false;
            this.btnTimKiemCacHDCuaHocVien.Click += new System.EventHandler(this.btnTimKiemCacHDCuaHocVien_Click);
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Location = new System.Drawing.Point(652, 13);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(76, 37);
            this.txtMaHocVien.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã học viên:";
            // 
            // dgvAccountant
            // 
            this.dgvAccountant.AllowUserToAddRows = false;
            this.dgvAccountant.AllowUserToDeleteRows = false;
            this.dgvAccountant.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAccountant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountant.Location = new System.Drawing.Point(1, 2);
            this.dgvAccountant.Name = "dgvAccountant";
            this.dgvAccountant.ReadOnly = true;
            this.dgvAccountant.RowTemplate.Height = 28;
            this.dgvAccountant.Size = new System.Drawing.Size(531, 308);
            this.dgvAccountant.TabIndex = 81;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(778, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 80;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AccountantForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 312);
            this.Controls.Add(this.btnXemHDPhucKhao);
            this.Controls.Add(this.btnXemHDThiTN);
            this.Controls.Add(this.btnXemHDHocPhi);
            this.Controls.Add(this.btnTimKiemCacHDCuaHocVien);
            this.Controls.Add(this.txtMaHocVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAccountant);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemHDPhucKhao;
        private System.Windows.Forms.Button btnXemHDThiTN;
        private System.Windows.Forms.Button btnXemHDHocPhi;
        private System.Windows.Forms.Button btnTimKiemCacHDCuaHocVien;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAccountant;
        private System.Windows.Forms.Button btnClose;
    }
}