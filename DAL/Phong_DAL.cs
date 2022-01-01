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
    public class Phong_DAL
    {
        static SqlConnection conn;

        //public static List<Phong> RoomList()
        //{
        //    string command = $"select * from Phong";
        //    conn = DataProvider.MoKetNoiDatabase();
        //    DataTable dt = DataProvider.LayDataTable(command, conn);
        //    if (dt.Rows.Count == 0)
        //        return null;

        //    List<Phong> danhSach = new List<Phong>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Phong phong = new Phong();
        //        phong.MaPhong = dt.Rows[i]["maPhong"].ToString();
        //        phong.LoaiPhong = dt.Rows[i]["loaiPhong"].ToString();
        //        phong.Gia = Double.Parse(dt.Rows[i]["gia"].ToString());
        //        phong.TinhTrang = dt.Rows[i]["tinhTrang"].ToString();
        //        danhSach.Add(phong);
        //    }
        //    DataProvider.DongKetNoiDatabase(conn);
        //    return danhSach;
        //}

        public static Phong RoomList(string maPhong)
        {
            string command = $"select maPhong, loaiPhong, gia, tinhTrang from Phong where maPhong = '{maPhong}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            Phong phong = new Phong();
            phong.MaPhong = dt.Rows[0]["maPhong"].ToString();
            phong.LoaiPhong = dt.Rows[0]["loaiPhong"].ToString();
            phong.Gia = Double.Parse(dt.Rows[0]["gia"].ToString());
            phong.TinhTrang = dt.Rows[0]["tinhTrang"].ToString();

            DataProvider.DongKetNoiDatabase(conn);
            return phong;
        }

        public static bool CheckEmpty(string maPhong)
        {
            string command = $"select tinhTrang from Phong where maPhong = '{maPhong}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);

            Phong phong = new Phong();
            phong.TinhTrang = dt.Rows[0]["tinhTrang"].ToString();

            if(phong.TinhTrang == "Empty")
            {
                return true;
            }

            DataProvider.DongKetNoiDatabase(conn);
            return false;
        }

        public static bool GetRoom(string maPhong)
        {
            string command = $"select maPhong from Phong where maPhong = '{maPhong}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong phong = new Phong();
                phong.MaPhong = dt.Rows[0]["maPhong"].ToString();
                
                if (phong.MaPhong == maPhong)
                {
                    return true;
                }
            }

            

            DataProvider.DongKetNoiDatabase(conn);
            return false;
        }

        public static bool AddNewRoom(Phong phong)
        {
            string command = $"insert into PHONG values ('{phong.MaPhong}','{phong.LoaiPhong}','{phong.Gia}', '{phong.TinhTrang}')";
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

        public static bool UpdateRoom(Phong phong)
        {
            string command = $"update PHONG set loaiPhong = N'{phong.LoaiPhong}',gia = N'{phong.Gia}' where maPhong = '{phong.MaPhong}'";
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

        public static List<Phong> SearchedRoom(string searchString)
        {
            string command = $"select * from PHONG where maPhong like '%{searchString}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<Phong> danhSach = new List<Phong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong phong = new Phong();
                phong.MaPhong = dt.Rows[0]["maPhong"].ToString();
                phong.LoaiPhong = dt.Rows[0]["loaiPhong"].ToString();
                phong.Gia = Double.Parse(dt.Rows[0]["gia"].ToString());
                danhSach.Add(phong);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
