using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietDanhSachDichVu_DAL
    {
        static SqlConnection conn;
        public static bool AddNewListServiceDetail(ChiTietDanhSachDichVu chiTiet)
        {
            string command = $"insert into CTDSDichVu (maChiTietDV, maDSDV, maDV, maLoaiDichVu, gia, soluong, maDVT, thanhtien) values ('{chiTiet.MaChiTietDV}' , '{chiTiet.MaDSDV}', '{chiTiet.MaDV}', '{chiTiet.MaLoaiDV}', {chiTiet.Gia}, {chiTiet.SoLuong}, '{chiTiet.MaDVT}', {chiTiet.ThanhTien})";
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
        
         public static List<ChiTietDanhSachDichVu> ServiceList()
        {
            string command = $"select * from CTDSDichVu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietDanhSachDichVu> danhSach = new List<ChiTietDanhSachDichVu>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietDanhSachDichVu chitiet = new ChiTietDanhSachDichVu();
                chitiet.MaChiTietDV = dt.Rows[i]["maChiTietDV"].ToString();
                chitiet.MaDSDV = dt.Rows[i]["maDSDV"].ToString();
                chitiet.MaDV = dt.Rows[i]["maDV"].ToString();
                chitiet.MaLoaiDV = dt.Rows[i]["maLoaiDichVu"].ToString();
                chitiet.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
                chitiet.SoLuong = Int32.Parse(dt.Rows[i]["soLuong"].ToString());
                chitiet.MaDVT = dt.Rows[i]["maDVT"].ToString();
                chitiet.ThanhTien = Double.Parse(dt.Rows[i]["gia"].ToString());

                danhSach.Add(chitiet);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<DichVu> ServiceLists(string id)
        {
            string command = $"select maDV,soLuong from CTDSDichVu where maDSDV = '{id}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<DichVu> danhSach = new List<DichVu>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string maDichvu = dt.Rows[i]["maDV"].ToString();
                DichVu ma = DichVu_DAL.ServiceWithID(maDichvu);
                ma.SoLuong = Int32.Parse(dt.Rows[i]["soLuong"].ToString());
                danhSach.Add(ma);
            }
            
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

    }
}
