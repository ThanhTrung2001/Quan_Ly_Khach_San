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
    public class PhieuThanhToan_DAL
    {
        private static SqlConnection conn;

        public static bool AddNewBillAgent(PhieuThanhToan p)
        {
            string command = $"insert into PhieuThanhToan (maPhieu, ngayLap, maDSNL, tongTien, maTrangThai) values ('{p.MaPhieu}', '{p.NgayLap}', '{p.MaDSNL}', {p.TongTien}, '{p.MaTrangThai}')";
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

        public static List<PhieuThanhToan> BillAgentList(string id, string tt)
        {
            string command = $"select * from PhieuThanhToan where maPhieu like '{id}%' and  maTrangThai like '{tt}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<PhieuThanhToan> danhSach = new List<PhieuThanhToan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuThanhToan p = new PhieuThanhToan();
                p.MaPhieu = dt.Rows[i]["maPhieu"].ToString();
                p.NgayLap = dt.Rows[i]["ngayLap"].ToString();
                p.MaDL = dt.Rows[i]["maDL"].ToString();
                p.MaNV = dt.Rows[i]["maNV"].ToString();
                p.MaDSNL = dt.Rows[i]["maDSNL"].ToString();
                p.TongTien = Double.Parse(dt.Rows[i]["tongTien"].ToString());
                p.MaTrangThai = dt.Rows[i]["maTrangThai"].ToString();
                p.TinhTrang = TinhTrang_DAO.GetStatus(p.MaTrangThai);
                p.GhiChu = dt.Rows[i]["ghiChu"].ToString();


                danhSach.Add(p);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool UpdateTotal(double total, string maDSNL)
        {
            string command = $"update PhieuThanhToan set tongTien = {total} where maDSNL = '{maDSNL}'";
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
        public static bool UpdateConfirm(string maDL, string note, string maDSNL)
        {
            string command = $"update PhieuThanhToan set maDL = '{maDL}', ghiChu = '{note}', maTrangThai = 'Co' where maDSNL = '{maDSNL}'";
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
