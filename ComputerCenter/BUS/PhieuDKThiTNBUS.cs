using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    public class PhieuDKThiTNBUS
    {
        public int MaPhieuDKiTN { get; set; }
        public string NgayLapPhieu { get; set; }

        public static DataTable displayPhieuDKITNForm()
        {
            return PhieuDKThiTNDAO.displayPhieuDKiTNForm();
        }

        public static int AddPhieuDKiTNForm(PhieuDKThiTNBUS PDKTNBUS)
        {
            return PhieuDKThiTNDAO.AddPhieuDkiTNForm(PDKTNBUS);
        }

        public static int EditPhieuDKiTNForm(PhieuDKThiTNBUS PDKTNBUS)
        {
            return PhieuDKThiTNDAO.EditPhieuDkiTNForm(PDKTNBUS);
        }

        public static int DelPhieuDKiTNForm(int MaPhieuDKiTN1)
        {
            return PhieuDKThiTNDAO.DelPhieuDkiTNForm(MaPhieuDKiTN1);
        }

        public static DataTable SearchPhieuDkiTN(string NgayLapPhieuTN1)
        {
            return PhieuDKThiTNDAO.SearchPhieu(NgayLapPhieuTN1);
        }
    }
}
