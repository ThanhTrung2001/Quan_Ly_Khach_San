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
    public class LoaiDichVu_DAL
    {
        static SqlConnection conn;

        public static List<LoaiDichVu> ServiceTypeList()
        {
            string command = $"select * from LoaiDichVu";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<LoaiDichVu> danhsach = new List<LoaiDichVu>();
            for(int i= 0; i<dt.Rows.Count; i++)
            {
                LoaiDichVu loaiDichVu = new LoaiDichVu();
                loaiDichVu.MaLoaiDichVu = dt.Rows[i]["maLoaiDichVu"].ToString();
                loaiDichVu.TLoaiDichVu = dt.Rows[i]["loaiDichVu"].ToString();
                danhsach.Add(loaiDichVu);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhsach;
        }
        public static string GetServiceType(string maLoaiDichVu)
        {
            string command =   $"select loaiDichVu from LoaiDichVu where maLoaiDichVu = '{maLoaiDichVu}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            string loaiDichVu;
            loaiDichVu = dt.Rows[0]["loaiDichVu"].ToString();
            return loaiDichVu;
        }
    }
}
