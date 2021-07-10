using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "PHAT" && txtPassword.Text == "12345")
            {
                // Global.loginname = txtUsername.Text;
                // Global.password = txtPassword.Text;
                StudentForm hv = new StudentForm();
                EmployeeForm nv = new EmployeeForm();
                AccountantForm kt = new AccountantForm();
                //kt.ShowDialog();
                //hv.ShowDialog();
                nv.ShowDialog();
            }
        }
    }
}
