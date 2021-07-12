using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    class PhieuPhucKhaoBUS
    {
       
            public string LyDo { set; get; }
            public int MaHV { set; get; }
            public int LanThi { set; get; }
            public int MaLop { set; get; }
            public int MaKH { set; get; }
            //Xem phieu phuc khao TN   
            public static DataTable XemPhieuPhucKhaoTN()
            {
                return PhieuPhucKhaoDAO.XemPhieuPhucKhaoTN();
            }
            //Xem phieu phuc khao KTHP   
            public static DataTable XemPhieuPhucKhaoKTHP()
            {
                return PhieuPhucKhaoDAO.XemPhieuPhucKhaoKTHP();
            }
            //dang ki phuc khao
            public static void ThemPhieuPhucKhao(PhieuPhucKhaoBUS PK)
            {
                PhieuPhucKhaoDAO.ThemPhieuDangKyPhucKhao(PK);
            }

    }
}
