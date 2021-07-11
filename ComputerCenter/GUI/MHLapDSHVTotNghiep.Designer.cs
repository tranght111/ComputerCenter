namespace ComputerCenter.GUI
{
    partial class MHLapDSHVTotNghiep
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
            this.lbKhoaHocKTV = new System.Windows.Forms.Label();
            this.cbbKhoaHocKTV = new System.Windows.Forms.ComboBox();
            this.dgvDSHVTotNghiep = new System.Windows.Forms.DataGridView();
            this.btnLapDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHVTotNghiep)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKhoaHocKTV
            // 
            this.lbKhoaHocKTV.AutoSize = true;
            this.lbKhoaHocKTV.Location = new System.Drawing.Point(49, 52);
            this.lbKhoaHocKTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoaHocKTV.Name = "lbKhoaHocKTV";
            this.lbKhoaHocKTV.Size = new System.Drawing.Size(68, 17);
            this.lbKhoaHocKTV.TabIndex = 0;
            this.lbKhoaHocKTV.Text = "Khóa học";
            // 
            // cbbKhoaHocKTV
            // 
            this.cbbKhoaHocKTV.FormattingEnabled = true;
            this.cbbKhoaHocKTV.Location = new System.Drawing.Point(140, 48);
            this.cbbKhoaHocKTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbKhoaHocKTV.Name = "cbbKhoaHocKTV";
            this.cbbKhoaHocKTV.Size = new System.Drawing.Size(249, 24);
            this.cbbKhoaHocKTV.TabIndex = 1;
            // 
            // dgvDSHVTotNghiep
            // 
            this.dgvDSHVTotNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHVTotNghiep.Location = new System.Drawing.Point(16, 97);
            this.dgvDSHVTotNghiep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSHVTotNghiep.Name = "dgvDSHVTotNghiep";
            this.dgvDSHVTotNghiep.RowHeadersWidth = 51;
            this.dgvDSHVTotNghiep.Size = new System.Drawing.Size(865, 352);
            this.dgvDSHVTotNghiep.TabIndex = 2;
            // 
            // btnLapDS
            // 
            this.btnLapDS.Location = new System.Drawing.Point(616, 48);
            this.btnLapDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLapDS.Name = "btnLapDS";
            this.btnLapDS.Size = new System.Drawing.Size(100, 28);
            this.btnLapDS.TabIndex = 3;
            this.btnLapDS.Text = "Xem";
            this.btnLapDS.UseVisualStyleBackColor = true;
            this.btnLapDS.Click += new System.EventHandler(this.btnLapDS_Click);
            // 
            // MHLapDSHVTotNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 464);
            this.Controls.Add(this.btnLapDS);
            this.Controls.Add(this.dgvDSHVTotNghiep);
            this.Controls.Add(this.cbbKhoaHocKTV);
            this.Controls.Add(this.lbKhoaHocKTV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MHLapDSHVTotNghiep";
            this.Text = "MHXemDSHVTotNghiep";
            this.Load += new System.EventHandler(this.MHLapDSHVTotNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHVTotNghiep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKhoaHocKTV;
        private System.Windows.Forms.ComboBox cbbKhoaHocKTV;
        private System.Windows.Forms.DataGridView dgvDSHVTotNghiep;
        private System.Windows.Forms.Button btnLapDS;
    }
}