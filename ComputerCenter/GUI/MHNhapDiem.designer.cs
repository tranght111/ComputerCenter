
namespace ComputerCenter.GUI
{
    partial class MHNhapDiem
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
            this.buttonDTN = new System.Windows.Forms.Button();
            this.buttonDKTHP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDTN
            // 
            this.buttonDTN.Location = new System.Drawing.Point(68, 209);
            this.buttonDTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDTN.Name = "buttonDTN";
            this.buttonDTN.Size = new System.Drawing.Size(128, 55);
            this.buttonDTN.TabIndex = 0;
            this.buttonDTN.Text = "Điểm tốt nghiệp";
            this.buttonDTN.UseVisualStyleBackColor = true;
            this.buttonDTN.Click += new System.EventHandler(this.buttonDTN_Click);
            // 
            // buttonDKTHP
            // 
            this.buttonDKTHP.Location = new System.Drawing.Point(68, 21);
            this.buttonDKTHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDKTHP.Name = "buttonDKTHP";
            this.buttonDKTHP.Size = new System.Drawing.Size(128, 55);
            this.buttonDKTHP.TabIndex = 1;
            this.buttonDKTHP.Text = "Điểm kết thúc học phần";
            this.buttonDKTHP.UseVisualStyleBackColor = true;
            this.buttonDKTHP.Click += new System.EventHandler(this.buttonDKTHP_Click);
            // 
            // MHNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 327);
            this.Controls.Add(this.buttonDKTHP);
            this.Controls.Add(this.buttonDTN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MHNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại điểm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDTN;
        private System.Windows.Forms.Button buttonDKTHP;
    }
}