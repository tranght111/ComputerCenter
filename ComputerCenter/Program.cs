using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenter.GUI;

namespace ComputerCenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MHNhanVienKhaoThi());
            //Application.Run(new MHQuanLyKhoaHoc());
            Application.Run(new MHDangNhap());
            //Application.Run(new MHXemLopHoc());
            //Application.Run(new MHXemDanhSachHocVien());
            //Application.Run(new EmployeeForm());
        }

    }

    public class Global
    {
        public static string loginname;
        public static string password;
        public static string role;
    }
}
