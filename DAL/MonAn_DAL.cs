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
    public class MonAn_DAO
    {
        static SqlConnection conn;

        public static List<MonAn> FoodList()
        {
            string command = $"select * from MonAn";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn> danhSach = new List<MonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn monAn = new MonAn();
                monAn.MaMonAn = dt.Rows[i]["maMonAn"].ToString();
                monAn.TenMonAn = dt.Rows[i]["tenMonAn"].ToString();
                monAn.MaLoaiMonAn = dt.Rows[i]["maLoaiMonAn"].ToString();
                monAn.LoaiMonAn = LoaiMonAn_DAO.GetFoodType(monAn.MaLoaiMonAn);
                monAn.MaDVT = dt.Rows[i]["maDVT"].ToString();
                monAn.DonViTinh = DonViTinh_DAL.GetMeasure(monAn.MaDVT);
                monAn.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
                monAn.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(monAn);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<MonAn> FoodListWithSearch(string tenMonAn, string maLoaiMonAn)
        {
            string command = $"select * from MonAn where tenMonAn like N'{tenMonAn}%'";
            if (maLoaiMonAn != "all") command = $"select * from MonAn where tenMonAn like N'{tenMonAn}%' and maLoaiMonAn = '{maLoaiMonAn}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn> danhSach = new List<MonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn monAn = new MonAn();
                monAn.MaMonAn = dt.Rows[i]["maMonAn"].ToString();
                monAn.TenMonAn = dt.Rows[i]["tenMonAn"].ToString();
                monAn.MaLoaiMonAn = dt.Rows[i]["maLoaiMonAn"].ToString();
                monAn.LoaiMonAn = LoaiMonAn_DAO.GetFoodType(monAn.MaLoaiMonAn);
                monAn.MaDVT = dt.Rows[i]["maDVT"].ToString();
                monAn.DonViTinh = DonViTinh_DAL.GetMeasure(monAn.MaDVT);
                monAn.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
                monAn.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(monAn);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static MonAn FoodWithID(string id)
        {
            string command = $"select * from MonAn where maMonAn = '{id}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            MonAn monAn = new MonAn();
            monAn.MaMonAn = dt.Rows[0]["maMonAn"].ToString();
            monAn.TenMonAn = dt.Rows[0]["tenMonAn"].ToString();
            monAn.MaLoaiMonAn = dt.Rows[0]["maLoaiMonAn"].ToString();
            monAn.LoaiMonAn = LoaiMonAn_DAO.GetFoodType(monAn.MaLoaiMonAn);
            monAn.MaDVT = dt.Rows[0]["maDVT"].ToString();
            monAn.DonViTinh = DonViTinh_DAL.GetMeasure(monAn.MaDVT);
            monAn.Gia = Double.Parse(dt.Rows[0]["gia"].ToString());
            monAn.GhiChu = dt.Rows[0]["ghiChu"].ToString();

            DataProvider.DongKetNoiDatabase(conn);
            return monAn;
        }
    }
}
