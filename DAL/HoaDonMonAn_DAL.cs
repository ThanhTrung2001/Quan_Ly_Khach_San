using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonMonAn_DAO
    {
        private static SqlConnection conn;

        public static bool AddNewBill(HoaDonMonAn hoaDon)
        {
            string command = $"insert into HoaDonMonAn(maHoaDon, MaKH, maDSMA, tongTien, maTinhTrang) values ('{hoaDon.MaHoaDon}', '{hoaDon.MaKH}', '{hoaDon.MaDSMA}', {hoaDon.TongTien}, '{hoaDon.MaTinhTrang}')";
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

        public static List<HoaDonMonAn> BillList()
        {
            string command = "select * from HoaDonMonAn";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonMonAn> danhSach = new List<HoaDonMonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonMonAn hoaDon = new HoaDonMonAn();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.NgayLap = dt.Rows[i]["ngayLap"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSMA = dt.Rows[i]["maDSMA"].ToString();
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["tinhTrang"].ToString();
                hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();

                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        } 

        public static List<HoaDonMonAn> BillPendingList()
        {
            string command = "select * from HoaDonMonAn where maTinhTrang = 'Pe'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDonMonAn> danhSach = new List<HoaDonMonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonMonAn hoaDon = new HoaDonMonAn();
                hoaDon.MaHoaDon = dt.Rows[i]["maHoaDon"].ToString();
                hoaDon.NgayLap = dt.Rows[i]["ngayLap"].ToString();
                hoaDon.MaNV = dt.Rows[i]["maNV"].ToString();
                hoaDon.MaKH = dt.Rows[i]["maKH"].ToString();
                hoaDon.MaDSMA = dt.Rows[i]["maDSMA"].ToString();
                hoaDon.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                hoaDon.TienNhan = Double.Parse(dt.Rows[i]["tienNhan"].ToString());
                hoaDon.TienThua = Double.Parse(dt.Rows[i]["tienThua"].ToString());
                hoaDon.MaRR = dt.Rows[i]["maRR"].ToString();
                hoaDon.SoTienHoan = Double.Parse(dt.Rows[i]["soTienHoan"].ToString());
                hoaDon.MaTinhTrang = dt.Rows[i]["tinhTrang"].ToString();
                hoaDon.GhiChu = dt.Rows[i]["ghiChu"].ToString();

                danhSach.Add(hoaDon);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool UpdateBillPaid(HoaDonMonAn hoaDon)
        {
            string command = $"update HoaDonMonAn set ngayLap = '{hoaDon.NgayLap}', maNV = '{hoaDon.MaNV}', tienNhan = {hoaDon.TienNhan}, tienThua = {hoaDon.TienThua}, maTinhTrang = '{hoaDon.MaTinhTrang}', ghiChu = N'{hoaDon.GhiChu}' " +
                $"where maHoaDon = '{hoaDon.MaHoaDon}'";
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
