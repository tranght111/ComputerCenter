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
        public string TenKH { get; set; }
        public int HocPhi { get; set; }
        public string TimeBegin { get; set; }
        public string MoTa { get; set; }
        public int MaLoaiKH { get; set; }
        public int SoLuong { get; set; }

        public static DataTable LayDSKhoaHoc()
        {
            return KhoaHocDAO.LayDSKhoaHoc();
        }

        public static DataTable LayDSKhoaHocKTV()
        {
            return KhoaHocDAO.LayDSKhoaHocKTV();
        }

        public static DataTable display()
        {
            return KhoaHocDAO.display();
        }

        public static int AddKhoaHoc(KhoaHocBUS KHBUS)
        {
            return KhoaHocDAO.AddKhoaHoc(KHBUS);
        }

        public static int EditKhoaHoc(KhoaHocBUS KHBUS)
        {
            return KhoaHocDAO.EditKhoaHoc(KHBUS);
        }

        public static int DelKhoahoc(int MaKH)
        {
            return KhoaHocDAO.DelKhoahoc(MaKH);
        }

        public static DataTable SearchKhoahoc(string TenKH)
        {
            return KhoaHocDAO.SearchKhoahoc(TenKH);
        }

        public static DataTable cbbLayDanhSachLoaiKH()
        {
            return KhoaHocDAO.cbbLayDanhSachLoaiKH();
        }

        public static int KHWidth = 220;
        public static int KHHeigh = 150;


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

        public int DangKyKhoaHoc(int makh, int mahv)
        {
            return KH.DangKyKhoaHoc(makh, mahv);
        }

        public bool KtraSLHocVienDK(int makh)
        {
            return KH.KtraSLHocVienDK(makh);
        }
    }
}

