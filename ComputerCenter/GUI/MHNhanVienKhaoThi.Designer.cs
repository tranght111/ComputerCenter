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
            this.btnLapHV = new System.Windows.Forms.Button();
            this.btnLapDSTN = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLapHV
            // 
            this.btnLapHV.Location = new System.Drawing.Point(25, 112);
            this.btnLapHV.Name = "btnLapHV";
            this.btnLapHV.Size = new System.Drawing.Size(105, 36);
            this.btnLapHV.TabIndex = 0;
            this.btnLapHV.Text = "Lập DSHV thi đạt và học lại";
            this.btnLapHV.UseVisualStyleBackColor = true;
            this.btnLapHV.Click += new System.EventHandler(this.btnLapHV_Click);
            // 
            // btnLapDSTN
            // 
            this.btnLapDSTN.Location = new System.Drawing.Point(25, 47);
            this.btnLapDSTN.Name = "btnLapDSTN";
            this.btnLapDSTN.Size = new System.Drawing.Size(111, 36);
            this.btnLapDSTN.TabIndex = 1;
            this.btnLapDSTN.Text = "Lập DSHV tốt nghiệp";
            this.btnLapDSTN.UseVisualStyleBackColor = true;
            this.btnLapDSTN.Click += new System.EventHandler(this.btnLapDSTN_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(713, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MHNhanVienKhaoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLapHV);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnLapDSTN);
            this.Name = "MHNhanVienKhaoThi";
            this.Text = "MHNhanVienKhaoThi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapHV;
        private System.Windows.Forms.Button btnLapDSTN;
        private System.Windows.Forms.Button btnDangXuat;
    }
}