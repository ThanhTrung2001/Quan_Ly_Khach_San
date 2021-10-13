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
    public class NguyenLieu_DAL
    {
        static SqlConnection conn;

        public static List<NguyenLieu> IngredientList()
        {
            string command = "select * from NguyenLieu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu> danhSach = new List<NguyenLieu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu nguyenLieu = new NguyenLieu();
                nguyenLieu.MaNL = dt.Rows[i]["maNL"].ToString();
                nguyenLieu.TenNL = dt.Rows[i]["tenNL"].ToString();
                nguyenLieu.MaLoaiNL = dt.Rows[i]["maLoaiNL"].ToString();
                nguyenLieu.LoaiNL = LoaiNguyenLieu_DAL.GetIngredientType(nguyenLieu.MaLoaiNL);
                nguyenLieu.MaDVT = dt.Rows[i]["maDVT"].ToString();
                nguyenLieu.DVT1 = DonViTinh_DAL.GetMeasure(nguyenLieu.MaDVT);
                nguyenLieu.SoLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());

                danhSach.Add(nguyenLieu);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool AddNewIngredient(NguyenLieu nguyenLieu)
        {
            string command = $"insert into NguyenLieu values ('{nguyenLieu.MaNL}',N'{nguyenLieu.TenNL.ToUpper()}', '{nguyenLieu.MaLoaiNL}', '{nguyenLieu.MaDVT}', {nguyenLieu.SoLuong})";
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

        public static List<NguyenLieu> IngredientListWithSearch(string name, string type)
        {
            string command = $"select * from NguyenLieu where tenNL like '{name}%' ";
            if (type != "") command += $"and maLoaiNL = '{type}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu> danhSach = new List<NguyenLieu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu nguyenLieu = new NguyenLieu();
                nguyenLieu.MaNL = dt.Rows[i]["maNL"].ToString();
                nguyenLieu.TenNL = dt.Rows[i]["tenNL"].ToString();
                nguyenLieu.MaLoaiNL = dt.Rows[i]["maLoaiNL"].ToString();
                nguyenLieu.LoaiNL = LoaiNguyenLieu_DAL.GetIngredientType(nguyenLieu.MaLoaiNL);
                nguyenLieu.MaDVT = dt.Rows[i]["maDVT"].ToString();
                nguyenLieu.DVT1 = DonViTinh_DAL.GetMeasure(nguyenLieu.MaDVT);
                nguyenLieu.SoLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());

                danhSach.Add(nguyenLieu);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static NguyenLieu IngredientWithID(string id)
        {
            string command = $"select * from NguyenLieu where maNL = '{id}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.MaNL = dt.Rows[0]["maNL"].ToString();
            nguyenLieu.TenNL = dt.Rows[0]["tenNL"].ToString();
            nguyenLieu.MaLoaiNL = dt.Rows[0]["maLoaiNL"].ToString();
            nguyenLieu.LoaiNL = LoaiNguyenLieu_DAL.GetIngredientType(nguyenLieu.MaLoaiNL);
            nguyenLieu.MaDVT = dt.Rows[0]["maDVT"].ToString();
            nguyenLieu.DVT1 = DonViTinh_DAL.GetMeasure(nguyenLieu.MaDVT);
            nguyenLieu.SoLuong = int.Parse(dt.Rows[0]["soLuong"].ToString());

            DataProvider.DongKetNoiDatabase(conn);
            return nguyenLieu;
        }

        public static bool UpdateAmount(string id, int amount)
        {
            string command = $"update NguyenLieu set soLuong = {amount} where maNL = '{id}'";
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
