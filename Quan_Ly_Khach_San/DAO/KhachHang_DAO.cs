using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DAO
{
    public class KhachHang_DAO
    { 

        static SqlConnection conn;

        public static List<KhachHang> CustomerList()
        {
            string command = "select * from KhachHang";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang> danhSach = new List<KhachHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKH = dt.Rows[i]["maKH"].ToString();
                khachHang.TenKhachHang = dt.Rows[i]["tenKhachHang"].ToString();
                khachHang.SDT = dt.Rows[i]["SDT"].ToString();
                khachHang.CMND = dt.Rows[i]["CMND"].ToString();
                khachHang.DiaChi = dt.Rows[i]["diaChi"].ToString();
                khachHang.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(khachHang);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static  bool AddNewCustomer(KhachHang khachHang)
        {
            string command = $"insert into KHACHHANG values (N'{khachHang.MaKH}',N'{khachHang.TenKhachHang}',N'{khachHang.SDT}', N'{khachHang.CMND}',N'{khachHang.DiaChi}',N'{khachHang.GhiChu}')";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataProvider.ThucThiLenhTruyVan(command, conn);
                DataProvider.DongKetNoiDatabase(conn);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoiDatabase(conn);
                return false;
            }
        }

        public static bool DeleteCustomer(string maKH)
        {
            string command = $"delete from KHACHHANG where maKH = '{maKH}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataProvider.ThucThiLenhTruyVan(command, conn);
                DataProvider.DongKetNoiDatabase(conn);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoiDatabase(conn);
                return false;
            }
        }

        public static bool UpdateCustomer(KhachHang khachHang)
        {
            string command = $"update KHACHHANG set tenKhachHang = N'{khachHang.TenKhachHang}',SDT = N'{khachHang.SDT}', CMND = N'{khachHang.CMND}',diaChi = N'{khachHang.DiaChi}', ghiChu = N'{khachHang.GhiChu}' where maKH = '{khachHang.MaKH}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataProvider.ThucThiLenhTruyVan(command, conn);
                DataProvider.DongKetNoiDatabase(conn);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoiDatabase(conn);
                return false;
            }
        }

        public static List<KhachHang> SearchedCustomer(string searchString)
        {
            string command = $"select * from KhachHang where maKH like '%{searchString}%' or tenKhachHang like N'%{searchString}%' or SDT like '{searchString}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang> danhSach = new List<KhachHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKH = dt.Rows[i]["maKH"].ToString();
                khachHang.TenKhachHang = dt.Rows[i]["tenKhachHang"].ToString();
                khachHang.SDT = dt.Rows[i]["SDT"].ToString();
                khachHang.CMND = dt.Rows[i]["CMND"].ToString();
                khachHang.DiaChi = dt.Rows[i]["diaChi"].ToString();
                khachHang.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(khachHang);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
