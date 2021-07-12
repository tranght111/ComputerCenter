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

            Global.loginname = txtUsername.Text;
            Global.password = txtPassword.Text;
            Global.role = tk.role;

           if(TaiKhoanBUS.KtraDangNhapHopLe(tk).HasRows)
            {
                if(tk.username.StartsWith("NVKTHI") || tk.username.StartsWith("nvkthi") || tk.username.StartsWith("NVKThi"))
                {
                    MHNhanVienKhaoThi f = new MHNhanVienKhaoThi();
                  
                    this.Hide();
                    f.Show();
                    f.FormClosed += F_FormClosed;
                }
                
                else
                if (tk.username.StartsWith("nvktoan") || tk.username.StartsWith("NVKTOAN") || tk.username.StartsWith("Nvktoan"))
                {
                    AccountantForm f = new AccountantForm();

                    this.Hide();
                    f.Show();
                    f.FormClosed += F_FormClosed;
                }
                else
                {
                    StudentForm f = new StudentForm();

                    this.Hide();
                    f.Show();
                    f.FormClosed += F_FormClosed;
                    
                }

                
            }
           else
            {
                MessageBox.Show("Login Failed!!! Check your username or password!!!", "Thông báo");
            }

            if (tk.getRoleOfUser(tk.username) == "HocVien")
            {
                MHXemLopHoc f = new MHXemLopHoc();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            //Clear login data when show again
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbbRole.SelectedIndex = -1;
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            MHXemLopHoc xemLH = new MHXemLopHoc();
            this.Hide();
            xemLH.ShowDialog();
            //xemLH.Show();
        }
    }
}
