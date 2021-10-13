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
    }
}
