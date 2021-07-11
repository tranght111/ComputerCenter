
namespace ComputerCenter.GUI
{
    partial class MHThongTinLopHoc
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
            this.dgvLopHocInfo = new System.Windows.Forms.DataGridView();
            this.btnDkyKH = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.labelTenKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopHocInfo
            // 
            this.dgvLopHocInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLopHocInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocInfo.Location = new System.Drawing.Point(12, 65);
            this.dgvLopHocInfo.Name = "dgvLopHocInfo";
            this.dgvLopHocInfo.RowHeadersWidth = 51;
            this.dgvLopHocInfo.RowTemplate.Height = 24;
            this.dgvLopHocInfo.Size = new System.Drawing.Size(930, 283);
            this.dgvLopHocInfo.TabIndex = 1;
            // 
            // btnDkyKH
            // 
            this.btnDkyKH.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDkyKH.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDkyKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDkyKH.Location = new System.Drawing.Point(369, 354);
            this.btnDkyKH.Name = "btnDkyKH";
            this.btnDkyKH.Size = new System.Drawing.Size(214, 54);
            this.btnDkyKH.TabIndex = 5;
            this.btnDkyKH.Text = "Đăng ký khoá học";
            this.btnDkyKH.UseVisualStyleBackColor = false;
            this.btnDkyKH.Click += new System.EventHandler(this.btnDkyKH_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Location = new System.Drawing.Point(854, 372);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(88, 31);
            this.btnTroLai.TabIndex = 6;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click_1);
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.Location = new System.Drawing.Point(12, 7);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(0, 26);
            this.labelTenKH.TabIndex = 7;
            // 
            // MHThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 415);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnDkyKH);
            this.Controls.Add(this.dgvLopHocInfo);
            this.Name = "MHThongTinLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHThongTinLopHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopHocInfo;
        private System.Windows.Forms.Button btnDkyKH;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label labelTenKH;
    }
}