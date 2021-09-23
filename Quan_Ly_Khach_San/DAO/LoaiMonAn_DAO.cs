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
    public class LoaiMonAn_DAO
    {
        static SqlConnection conn;
        public static List<LoaiMonAn> FoodTypeList()
        {
            string command = $"select * from LoaiMonAn";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<LoaiMonAn> danhSach = new List<LoaiMonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiMonAn loaiMonAn = new LoaiMonAn();
                loaiMonAn.MaLoaiMonAn = dt.Rows[i]["maLoaiMonAn"].ToString();
                loaiMonAn.TLoaiMonAn = dt.Rows[i]["loaiMonAn"].ToString();
                danhSach.Add(loaiMonAn);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static string GetFoodType(string maLoaiMonAn)
        {
            string command = $"select loaiMonAn from LoaiMonAn where maLoaiMonAn = '{maLoaiMonAn}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            string loaiMonAn;
            loaiMonAn = dt.Rows[0]["loaiMonAn"].ToString();

            return loaiMonAn;
        }
    }
}
