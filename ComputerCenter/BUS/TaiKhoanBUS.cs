using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    public class TaiKhoanBUS
    {
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        TaiKhoanDAO tkd = new TaiKhoanDAO();
        public SqlDataReader KtraDangNhapHopLe(TaiKhoanBUS tk)
        {
            if(tk.role == "NhanVienKhaoThi" || tk.role == "NhanVienKeToan")
            {
                tk.role = "NhanVien";
            }

            return tkd.DocThongTinNguoiDung(tk);
        }
    }
}
