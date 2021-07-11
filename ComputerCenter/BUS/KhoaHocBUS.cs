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
    public class KhoaHocBUS
    {
        public int MaKH { get; set; }
        public string Tenkhoahoc { get; set; }
        public int Hocphi { get; set; }
        public DateTime Thoigianbatdau { get; set; }
        public string Mota { get; set; }
        public int Maloai { get; set; }
        public string Loaikh { get; set; }
        public int Sltoida { get; set; }


        public static int KHWidth = 220;
        public static int KHHeigh = 150;


        KhoaHocDAO KH = new KhoaHocDAO();

        public DataTable LayDSKhoaHoc()
        {
            return KH.LayDSKhoaHoc();
        }

        public DataTable LayDSKhoaHocKTV()
        {
            return KH.LayDSKhoaHocKTV();
        }

        public KhoaHocBUS() { }

        public KhoaHocBUS(DataRow row)
        {
            this.Tenkhoahoc = row["TENKHOAHOC"].ToString();
            this.MaKH = (int)row["MAKHOAHOC"];
            //this.Hocphi = (int)row["HOCPHI"];
            this.Thoigianbatdau = (DateTime)row["THOIGIANBATDAU"];
            this.Mota = row["MOTA"].ToString();
            this.Sltoida = (int)row["SOLUONGTOIDA"];
            this.Loaikh = row["TENLOAIKHOAHOC"].ToString();
        }

        public List<KhoaHocBUS> LayViewDSKhoaHoc()
        {
            return KH.LayViewDSKhoaHoc();
        }
    }
}
