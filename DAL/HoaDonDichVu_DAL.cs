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
    public class HoaDonDichVu_DAL
    {
        static SqlConnection conn;

        public static List<HoaDonDichVu> ServiceBillList()
        {
            string command = "select * from HoaDonDichVu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonDichVu> danhSach = new List<HoaDonDichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDichVu hoaDon = new HoaDonDichVu();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSDV = dt.Rows[i]["maDSDV"].ToString();
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

        public static bool AddNewServiceBill(HoaDonDichVu hoaDon)
        {
            string command = $"insert into HoaDonDichVu(maHoaDon, checkin, checkout, maKH, maDSDV, tongTien, tienNhan, tienThua, maTinhTrang) values ('{hoaDon.MaHoaDon}', '{hoaDon.Checkin}', '{hoaDon.Checkout}', '{hoaDon.MaKH}', '{hoaDon.MaDSDV}',  {hoaDon.TongTien}, {hoaDon.TienNhan}, {hoaDon.TienThua}, '{hoaDon.MaTinhTrang}')";
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

        public static List<HoaDonDichVu> ServiceBillPendingList()
        {
            string command = "select maHoaDon, checkin, checkout, maNV, maKH, maDSDV, tongTien, maTinhTrang from HoaDonDichVu where maTinhTrang = 'Pe'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonDichVu> danhSach = new List<HoaDonDichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDichVu hoaDon = new HoaDonDichVu();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSDV = dt.Rows[i]["maDSDV"].ToString();
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<HoaDonDichVu> ServiceBillCompletedList()
        {
            string command = "select maHoaDon, checkin, checkout, maNV, maKH, maDSDV, tongTien, maTinhTrang from HoaDonDichVu where maTinhTrang = 'Co'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonDichVu> danhSach = new List<HoaDonDichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                HoaDonDichVu hoaDon = new HoaDonDichVu();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSDV = dt.Rows[i]["maDSDV"].ToString();
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

        public static bool UpdateServiceBill(HoaDonDichVu hoaDon)
        {
            string command = $"update HoaDonDichVu set tongTien = {hoaDon.TongTien}, maRR = '{hoaDon.MaRR}', soTienHoan = {hoaDon.SoTienHoan}, tienNhan = {hoaDon.TienNhan}, tienThua = {hoaDon.TienThua}, maTinhTrang = '{hoaDon.MaTinhTrang}', ghiChu = '{hoaDon.GhiChu}'" + $"where maHoaDon = '{hoaDon.MaHoaDon}'";
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

        public static List<HoaDonDichVu> ServiceListWithDate(DateTime date, string customerid)
        {
            string command = $"select * from HoaDonDichVu where Day(checkout) = '{date.Day}' and Month(checkout) = '{date.Month}' and Year(checkout) = '{date.Year}' and maKH like '{customerid}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonDichVu> danhSach = new List<HoaDonDichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDichVu hoaDon = new HoaDonDichVu();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.Checkin = dt.Rows[i]["checkin"].ToString();
                hoaDon.Checkout = dt.Rows[i]["checkout"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSDV = dt.Rows[i]["maDSDV"].ToString();
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                //hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();

                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

    }
}
