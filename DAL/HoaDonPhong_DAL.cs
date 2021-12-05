using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonPhong_DAL
    {
        private static SqlConnection conn;

        public static List<HoaDonPhong> RoomBillList()
        {
            string command = "select * from HoaDonPhong";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();

                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool AddNewBill(HoaDonPhong hoaDon)
        {
            string command = $"insert into HoaDonPhong(maHoaDon, checkin, checkout, maKH, maPhong, soNgayO, tongTien, tienNhan, tienThua, maTinhTrang) values ('{hoaDon.MaHoaDon}', '{hoaDon.Checkin}', '{hoaDon.Checkout}', '{hoaDon.MaKH}', '{hoaDon.MaPhong}', '{hoaDon.SoNgayO}', {hoaDon.TongTien}, {hoaDon.TienNhan}, {hoaDon.TienThua}, '{hoaDon.MaTinhTrang}')";
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

        public static List<HoaDonPhong> RoomBillPendingList()
        {
            string command = "select maHoaDon, checkin, checkout, maNV, maKH, maPhong, soNgayO, tongTien, maTinhTrang from HoaDonPhong where maTinhTrang = 'Pe'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<HoaDonPhong> RoomBillCompletedList()
        {
            string command = "select maHoaDon, checkin, checkout, maNV, maKH, maPhong, soNgayO, tongTien, tienNhan, tienThua, maRR, soTienHoan, maTinhTrang, ghiChu from HoaDonPhong where maTinhTrang = 'Co'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool UpdateRoom(String idPhong)
        {
            string command = $"update Phong set tinhTrang = 'Hired' where maPhong = '{idPhong}'";
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

        public static bool UpdateRoomBill(HoaDonPhong hoaDonPhong)
        {
            string command = $"update HoaDonPhong set tongTien = {hoaDonPhong.TongTien}, maRR = '{hoaDonPhong.MaRR}', soTienHoan = {hoaDonPhong.SoTienHoan}, tienNhan = {hoaDonPhong.TienNhan}, tienThua = {hoaDonPhong.TienThua}, maTinhTrang = '{hoaDonPhong.MaTinhTrang}', ghiChu = '{hoaDonPhong.GhiChu}'" + $"where maHoaDon = '{hoaDonPhong.MaHoaDon}'";
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

        public static bool UpdateRoomAfter(String idPhong)
        {
            string command = $"update Phong set tinhTrang = 'Empty' where maPhong = '{idPhong}'";
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

        public static List<HoaDonPhong> RoomListWithDate(DateTime date, string CustomerID)
        {
            string command = $"select maHoaDon, checkin, checkout, maNV, maKH, maPhong, soNgayO, tongTien, tienNhan, tienThua, maRR, soTienHoan, maTinhTrang, ghiChu " + $"from HoaDonPhong where Day(checkout) = '{date.Day}' and Month(checkout) = '{date.Month}' and Year(checkout) = '{date.Year}' and maKH like '{CustomerID}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                //if (dt.Rows[i]["maRR"] == null)
                //{
                //    hoaDon.MaRR = "";
                //    hoaDon.SoTienHoan = 0;
                //} else
                //{
                //    hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                //    hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                //}
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                //if (dt.Rows[i]["ghiChu"] == null)
                //    hoaDon.GhiChu = "";
                //else
                //    hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                    danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<HoaDonPhong> RoomListWithMonth(string thang, string nam, string CustomerID)
        {
            string command = $"select maHoaDon, checkin, checkout, maNV, maKH, maPhong, soNgayO, tongTien, tienNhan, tienThua, maRR, soTienHoan, maTinhTrang, ghiChu " +
                $"from HoaDonPhong where Month(checkout) = '{thang}' and Year(checkout) = '{nam}' and maKH like '{CustomerID}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                //if (dt.Rows[i]["maRR"] == null)
                //{
                //    hoaDon.MaRR = "";
                //    hoaDon.SoTienHoan = 0;
                //} else
                //{
                //    hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                //    hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                //}
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                //if (dt.Rows[i]["ghiChu"] == null)
                //    hoaDon.GhiChu = "";
                //else
                //    hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<HoaDonPhong> SearchedHoaDonPhong(string searchString)
        {
            string command = $"select * from HoaDonPhong where maKH like '%{searchString}%' and maTinhTrang = 'Pe' or maHoaDon like N'%{searchString}%' and maTinhTrang = 'Pe' or ghiChu like '{searchString}%' and maTinhTrang = 'Pe' ";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonPhong> danhSach = new List<HoaDonPhong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaPhong = dt.Rows[i]["maPhong"].ToString();
                hoaDon.SoNgayO = int.Parse(dt.Rows[i]["soNgayO"].ToString());
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
