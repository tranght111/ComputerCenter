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
           if(TaiKhoanBUS.KtraDangNhapHopLe(tk).HasRows)
            {
                if(tk.username.StartsWith("NVKTHI") || tk.username.StartsWith("nvkthi") || tk.username.StartsWith("NVKThi"))
                {
                    MHNhanVienKhaoThi f = new MHNhanVienKhaoThi();
                    this.Hide();
                    f.Show();
                    f.FormClosed += F_FormClosed;
                    //cái này hì cục dàng bấm += xong gòi bấm nút TAB gà nó tự generate hàm cho cục dàng hui ạ..sưng cục dàng iu qué i huiii dạ chụt chụt ah iu iu iu dạ xơm xơm cục dàng iu iu nò
                    //cái process còn lại là cái này vẫn còn chạy nò cục dàng cái này là cái form login ban đầu hỏ anh iu dạ đúng gòi ạ, cục dàng bấm đăng xuất cục dàng show ra cái mới mò còn cái này cục dàng iu hide đi nhưng mò mình k close dược cái này âu
                    //anh iu nàm nó lỗi cho cục dàng coi nò
                    //dạ xong gòi ó cục dàng iu, dạ í hí hí sưng anh iu qué i hui nò

                }
            }
           else
            {
                MessageBox.Show("Login Failed!!! Check your username or password!!!", "Thông báo");
            }
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            //Clear login data when show again
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbbRole.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
