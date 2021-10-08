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
    }
}
