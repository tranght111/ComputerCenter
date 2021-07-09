using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;
namespace ComputerCenter.BUS
{
    class HocVienBUS
    {
        public string TenHV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        HocVienDAO hv = new HocVienDAO();

        public int ThemHocVien(HocVienBUS hocvien)
        {
            if (hv.KtraUsernameHopLe(hocvien) != 0) return -1;
            return hv.ThemHocVien(hocvien);
        }


    }
}
