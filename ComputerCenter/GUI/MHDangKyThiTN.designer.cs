
namespace ComputerCenter.GUI
{
    partial class MHDangKyThiTN
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
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.dtgPhieuDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(235, 84);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 46);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(450, 84);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(75, 46);
            this.buttonXem.TabIndex = 1;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // dtgPhieuDK
            // 
            this.dtgPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuDK.Location = new System.Drawing.Point(-1, 174);
            this.dtgPhieuDK.Name = "dtgPhieuDK";
            this.dtgPhieuDK.RowHeadersWidth = 51;
            this.dtgPhieuDK.RowTemplate.Height = 24;
            this.dtgPhieuDK.Size = new System.Drawing.Size(800, 275);
            this.dtgPhieuDK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày Lập Phiếu";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(235, 20);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(290, 22);
            this.dtpNgayLap.TabIndex = 5;
            // 
            // MHDangKyThiTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgPhieuDK);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonThem);
            this.Name = "MHDangKyThiTN";
            this.Text = "MHDangKyThiTN";
            this.Load += new System.EventHandler(this.MHDangKyThiTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.DataGridView dtgPhieuDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}