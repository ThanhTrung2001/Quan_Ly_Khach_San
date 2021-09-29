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
            string command = $"insert into PhieuThanhToan (maPhieu, ngayLap, maDL, maDSNL, tongTien, maTrangThai, ghiChu) values ('{p.MaPhieu}', '{p.NgayLap}', '{p.MaDL}', '{p.MaDSNL}', {p.TongTien}, '{p.MaTrangThai}', '{p.GhiChu}')";
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

        public static List<PhieuThanhToan> BillAgentList(string id)
        {
            string command = $"select * from PhieuThanhToan where maPhieu like '{id}%'";
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
    }
}
