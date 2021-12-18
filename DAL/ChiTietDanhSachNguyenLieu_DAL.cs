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
    public class ChiTietDanhSachNguyenLieu_DAL
    {
        static SqlConnection conn;

        public static bool AddNewListIngredientDetail(ChiTietDanhSachNguyenLieu chiTiet)
        {
            //string command = $"insert into CTDSNguyenLieu (maChiTiet, maDSNL, maNL, tenNL, soLuong, maDonViTinh, donGia, thanhTien) values ('{chiTiet.MaChiTiet}', '{chiTiet.MaDSNL}', '{chiTiet.MaNL}' , N'{chiTiet.TenNL}', {chiTiet.SoLuong}, '{chiTiet.MaDVT}', {chiTiet.Gia}, {chiTiet.ThanhTien})";
            string command = $"insert into CTDSNguyenLieu (maChiTiet, maDSNL, maNL, tenNL, soLuong, maDonViTinh, donGia, thanhTien) values ('{chiTiet.MaChiTiet}', '{chiTiet.MaDSNL}', '{chiTiet.MaNL}' , N'{chiTiet.TenNL}', {chiTiet.SoLuong}, '{chiTiet.MaDVT}', {chiTiet.Gia}, {chiTiet.ThanhTien})";
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

        public static List<ChiTietDanhSachNguyenLieu> IngredientList(string maDS)
        {
            string command = $"select * from CTDSNguyenLieu where maDSNL = '{maDS}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietDanhSachNguyenLieu> danhSach = new List<ChiTietDanhSachNguyenLieu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietDanhSachNguyenLieu nl = new ChiTietDanhSachNguyenLieu();
                nl.MaChiTiet = dt.Rows[i]["maChiTiet"].ToString();
                nl.MaDSNL = dt.Rows[i]["maDSNL"].ToString();
                nl.MaNL = dt.Rows[i]["maNL"].ToString();
                nl.TenNL = dt.Rows[i]["tenNL"].ToString();
                nl.SoLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());
                nl.TenNL = dt.Rows[i]["tenNL"].ToString();
                nl.MaDVT =  dt.Rows[i]["maDonViTinh"].ToString();
                nl.Gia =  Double.Parse(dt.Rows[i]["donGia"].ToString());
                nl.ThanhTien = Double.Parse(dt.Rows[i]["thanhTien"].ToString());

                danhSach.Add(nl);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<ChiTietDanhSachNguyenLieu> IngredientLists()
        {
            string command = $"select * from CTDSNguyenLieu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietDanhSachNguyenLieu> danhSach = new List<ChiTietDanhSachNguyenLieu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietDanhSachNguyenLieu nl = new ChiTietDanhSachNguyenLieu();
                nl.MaChiTiet = dt.Rows[i]["maChiTiet"].ToString();
                nl.MaDSNL = dt.Rows[i]["maDSNL"].ToString();
                nl.MaNL = dt.Rows[i]["maNL"].ToString();
                nl.TenNL = dt.Rows[i]["tenNL"].ToString();
                nl.SoLuong = int.Parse(dt.Rows[i]["soLuong"].ToString());
                nl.TenNL = dt.Rows[i]["tenNL"].ToString();
                nl.MaDVT = dt.Rows[i]["maDonViTinh"].ToString();
                nl.Gia = Double.Parse(dt.Rows[i]["donGia"].ToString());
                nl.ThanhTien = Double.Parse(dt.Rows[i]["thanhTien"].ToString());

                danhSach.Add(nl);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool UpdateList(ChiTietDanhSachNguyenLieu ct)
        {
            string command = $"update CTDSNguyenLieu set dongia = {ct.Gia}, thanhTien = {ct.ThanhTien} where maDSNL = '{ct.MaDSNL}' and maNL = '{ct.MaNL}'";
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
