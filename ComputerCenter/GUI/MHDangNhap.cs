using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenter.BUS;

namespace ComputerCenter.GUI
{
    public partial class MHDangNhap : Form
    {
        TaiKhoanBUS tk = new TaiKhoanBUS();
        public MHDangNhap()
        {
            InitializeComponent();
        }

        private void MHDangNhap_Load(object sender, EventArgs e)
        {
            cbbRole.Items.Add("HocVien");
            cbbRole.Items.Add("GiangVien");
            cbbRole.Items.Add("NhanVienKhaoThi");
            cbbRole.Items.Add("NhanVienKeToan");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS tk = new TaiKhoanBUS()
            {
                role = cbbRole.SelectedItem.ToString(),
                username = txtUsername.Text,
                password = txtPassword.Text
            };
           if(tk.KtraDangNhapHopLe(tk).HasRows)
            {
                if(tk.username.StartsWith("NVKTHI") || tk.username.StartsWith("nvkthi") || tk.username.StartsWith("NVKThi"))
                {
                    MHNhanVienKhaoThi f = new MHNhanVienKhaoThi();
                    f.Show();
                    this.Hide();
                }
            }
           else
            {
                MessageBox.Show("Login Failed!!! Check your username or password!!!", "Thông báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
