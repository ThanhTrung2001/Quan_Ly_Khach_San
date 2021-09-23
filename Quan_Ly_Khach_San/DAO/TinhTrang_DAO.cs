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
    public class TinhTrang_DAO
    {
        static SqlConnection conn;
        public static List<TinhTrang> StatusList()
        {
            string command = $"select * from TinhTrang";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<TinhTrang> danhSach = new List<TinhTrang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TinhTrang tt = new TinhTrang();
                tt.MaTinhTrang = dt.Rows[i]["maTinhTrang"].ToString();
                tt.TenTinhTrang = dt.Rows[i]["tinhTrang"].ToString();
                danhSach.Add(tt);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static string GetStatus(string maTinhTrang)
        {
            string command = $"select tinhTrang from TinhTrang where maTinhTrang = '{maTinhTrang}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            string tt;
            tt = dt.Rows[0]["tinhTrang"].ToString();

            return tt;
        }
    }
}
