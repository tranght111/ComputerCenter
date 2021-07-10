namespace ComputerCenter.GUI
{
    partial class MHNhanVienKhaoThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHNhanVienKhaoThi));
            this.btnLapHV = new System.Windows.Forms.Button();
            this.btnLapDSTN = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLichThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLapHV
            // 
            this.btnLapHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnLapHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHV.ForeColor = System.Drawing.Color.White;
            this.btnLapHV.Location = new System.Drawing.Point(59, 115);
            this.btnLapHV.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLapHV.Name = "btnLapHV";
            this.btnLapHV.Size = new System.Drawing.Size(258, 82);
            this.btnLapHV.TabIndex = 0;
            this.btnLapHV.Text = "Lập DSHV thi đạt và học lại";
            this.btnLapHV.UseVisualStyleBackColor = false;
            this.btnLapHV.Click += new System.EventHandler(this.btnLapHV_Click);
            // 
            // btnLapDSTN
            // 
            this.btnLapDSTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnLapDSTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapDSTN.ForeColor = System.Drawing.Color.White;
            this.btnLapDSTN.Location = new System.Drawing.Point(59, 17);
            this.btnLapDSTN.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLapDSTN.Name = "btnLapDSTN";
            this.btnLapDSTN.Size = new System.Drawing.Size(258, 82);
            this.btnLapDSTN.TabIndex = 1;
            this.btnLapDSTN.Text = "Lập DSHV tốt nghiệp";
            this.btnLapDSTN.UseVisualStyleBackColor = false;
            this.btnLapDSTN.Click += new System.EventHandler(this.btnLapDSTN_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(709, 346);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(174, 52);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(863, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLichThi
            // 
            this.btnLichThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichThi.ForeColor = System.Drawing.Color.White;
            this.btnLichThi.Location = new System.Drawing.Point(363, 115);
            this.btnLichThi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLichThi.Name = "btnLichThi";
            this.btnLichThi.Size = new System.Drawing.Size(258, 82);
            this.btnLichThi.TabIndex = 22;
            this.btnLichThi.Text = "Lập Lịch Thi";
            this.btnLichThi.UseVisualStyleBackColor = false;
            this.btnLichThi.Click += new System.EventHandler(this.btnLichThi_Click);
            // 
            // MHNhanVienKhaoThi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(898, 415);
            this.Controls.Add(this.btnLichThi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLapHV);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnLapDSTN);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MHNhanVienKhaoThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHNhanVienKhaoThi";
            this.Load += new System.EventHandler(this.MHNhanVienKhaoThi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapHV;
        private System.Windows.Forms.Button btnLapDSTN;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLichThi;
    }
}