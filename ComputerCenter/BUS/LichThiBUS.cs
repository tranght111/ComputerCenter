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
    public class LichThiBUS 
    {
        public int MaLichThi;
        public string TenLichThi;
        public int MaLop;
        public int MaKhoaHoc;
        public string PhongThi;
        public DateTime NgayThi;
        public string GioThi;
        public int MaNVKTThi;

        // Xem lich thi KTHP
        public static DataTable XemLichThiKTHP()
        {
            return LichThiDAO.XemLichThiKTHP();
        }
        // Xem lich thi tot nghiep 
        public static DataTable XemLichThiTN()
        {
            return LichThiDAO.XemLichThiTN();
        }
        // Them lich thi 
        public static void ThemLichThi(LichThiBUS lt)
        {
            LichThiDAO.ThemLichThi(lt);
        }
        // Sua lich thi
        public static void SuaLichThi(LichThiBUS lt)
        {
            LichThiDAO.SuaLichThi(lt);
        }
    }
}
