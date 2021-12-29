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
    public class LoaiNguyenLieu_DAL
    {
        static SqlConnection conn;
        public static List<LoaiNguyenLieu> IngredientType()
        {
            string command = $"select * from LoaiNguyenLieu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<LoaiNguyenLieu> danhSach = new List<LoaiNguyenLieu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiNguyenLieu loaiNL = new LoaiNguyenLieu();
                loaiNL.MaLoaiNL = dt.Rows[i]["maLoaiNL"].ToString();
                loaiNL.TLoaiNguyenLieu = dt.Rows[i]["loaiNguyenLieu"].ToString();

                danhSach.Add(loaiNL);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static string GetIngredientType(string maDVT)
        {
            string command = $"select loaiNguyenLieu from LoaiNguyenLieu where maLoaiNL = '{maDVT}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            string donViTinh;
            donViTinh = dt.Rows[0]["loaiNguyenLieu"].ToString();

            return donViTinh;
        }

        public static bool AddIngredientType(LoaiNguyenLieu lnl)
        {
            string command = $"insert into LoaiNguyenLieu values ('{lnl.MaLoaiNL}',N'{lnl.TLoaiNguyenLieu.ToUpper()}')";
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
