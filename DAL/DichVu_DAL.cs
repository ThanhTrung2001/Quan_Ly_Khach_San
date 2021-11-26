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
    public class DichVu_DAL
    {
        static SqlConnection conn;

        public static List<DichVu> ServiceList()
        {
            string command = $"select * from DichVu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DichVu> danhSach = new List<DichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu dichVu = new DichVu();
                dichVu.MaDV = dt.Rows[i]["maDV"].ToString();
                dichVu.TenDV = dt.Rows[i]["tenDV"].ToString();
                dichVu.MaLoaiDV = dt.Rows[i]["maLoaiDichVu"].ToString();
                dichVu.MaDVT = dt.Rows[i]["maDVT"].ToString();
                dichVu.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
                dichVu.SoLuong = Int32.Parse(dt.Rows[i]["soLuong"].ToString());
                dichVu.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                danhSach.Add(dichVu);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static List<DichVu> ServiceListWithSearch(string tenDV)
        {
            string command = $"select * from DichVu where tenDV like N'{tenDV}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DichVu> danhSach = new List<DichVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu dichVu = new DichVu();
                dichVu.MaDV = dt.Rows[i]["maDV"].ToString();
                dichVu.TenDV = dt.Rows[i]["tenDV"].ToString();
                dichVu.MaLoaiDV = LoaiDichVu_DAL.GetServiceType(dichVu.MaLoaiDV);
                dichVu.MaDVT = DonViTinh_DAL.GetMeasure(dichVu.MaDVT);
                dichVu.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
                dichVu.SoLuong = Int32.Parse(dt.Rows[i]["soLuong"].ToString());
                dichVu.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                danhSach.Add(dichVu);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static DichVu ServiceWithID(string id)
        {
            string command = $"select * from DichVu where maDV = '{id}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

                DichVu dichVu = new DichVu();
                dichVu.MaDV = dt.Rows[0]["maDV"].ToString();
                dichVu.TenDV = dt.Rows[0]["tenDV"].ToString();
                dichVu.MaLoaiDV = LoaiDichVu_DAL.GetServiceType(dichVu.MaLoaiDV);
                dichVu.MaDVT = DonViTinh_DAL.GetMeasure(dichVu.MaDVT);
                dichVu.Gia = Double.Parse(dt.Rows[0]["gia"].ToString());
                dichVu.SoLuong = Int32.Parse(dt.Rows[0]["soLuong"].ToString());
                dichVu.MaTinhTrang = dt.Rows[0]["maTinhTrang"].ToString();
                            
            DataProvider.DongKetNoiDatabase(conn);
            return dichVu;
        }

        public static bool AddNewService(DichVu dichVu)
        {
            string command = $"insert into DichVu (maDV, tenDV, maLoaiDichVu, maDVT, gia, soLuong, maTinhTrang) values ('{dichVu.MaDV}','{dichVu.TenDV}','{dichVu.MaLoaiDV}', '{dichVu.MaDVT}', {dichVu.Gia}, {dichVu.SoLuong}, '{dichVu.MaTinhTrang}')";
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



        public static bool DeleteService(string id)
        {
            string command = $"delete from DichVu where maDV = '{id}'";
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
