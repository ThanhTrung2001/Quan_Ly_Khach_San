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
            string command = $"select maMonAn from CTDSMonAn where maDSMA = '{maDS}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn> danhSach = new List<MonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maMonAn = dt.Rows[i]["maMonAn"].ToString();

                

                danhSach.Add();
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
