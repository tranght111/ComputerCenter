using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.DAO;
using ComputerCenter.GUI;

namespace ComputerCenter.BUS
{
    public class TaiKhoanBUS
    {
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public static SqlDataReader KtraDangNhapHopLe(TaiKhoanBUS tk)
        {
            if(tk.role == "NhanVienKhaoThi" || tk.role == "NhanVienKeToan")
            {
                tk.role = "NhanVien";
            }

            return TaiKhoanDAO.DocThongTinNguoiDung(tk);
        }

        public static void DangXuat()
        {
            //MHDangNhap f = new MHDangNhap();
            //f.Show();
        }
    }
}
