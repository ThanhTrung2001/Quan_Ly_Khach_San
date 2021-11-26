using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiTietDanhSachMonAn_DAO
    {
        static SqlConnection conn;

        public static bool AddNewListFoodDetail(ChiTietDanhSachMonAn chiTiet)
        {
            string command = $"insert into CTDSMonAn values ('{chiTiet.MaChiTiet}', '{chiTiet.MaDSMA}', '{chiTiet.MaMonAn}' , N'{chiTiet.TenMonAn}', {chiTiet.SoLuong}, '{chiTiet.MaDVT}', {chiTiet.Gia}, {chiTiet.ThanhTien}, N'{chiTiet.GhiChu}')";
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
        
        public static List<MonAn> FoodList(string maDS)
        {
            string command = $"select maMonAn, soLuong from CTDSMonAn where maDSMA = '{maDS}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn> danhSach = new List<MonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maMonAn = dt.Rows[i]["maMonAn"].ToString();

                MonAn ma = MonAn_DAO.FoodWithID(maMonAn);
                ma.SoLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());

                danhSach.Add(ma);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
