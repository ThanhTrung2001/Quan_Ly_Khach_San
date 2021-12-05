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
    public class DaiLy_DAL
    {
        static SqlConnection conn;

        public static List<DaiLy> SupplierList()
        {
            string command = $"select * from DaiLy";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DaiLy> danhSach = new List<DaiLy>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DaiLy daiLy = new DaiLy();
                daiLy.MaDL = dt.Rows[i]["maDL"].ToString();
                daiLy.TenDL = dt.Rows[i]["tenDL"].ToString();
                daiLy.DiaChi = dt.Rows[i]["diaChi"].ToString();
                daiLy.SDT1 = dt.Rows[i]["SDT"].ToString();
                daiLy.Email = dt.Rows[i]["email"].ToString();
                daiLy.GhiChu = dt.Rows[i]["ghiChu"].ToString();
                danhSach.Add(daiLy);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool AddNewSupplier(DaiLy daiLy)
        {
            string command = $"insert into DaiLy (maDL, tenDL, diaChi, SDT, email, ghiChu) values ('{daiLy.MaDL}','{daiLy.TenDL}','{daiLy.DiaChi}', '{daiLy.SDT1}', '{daiLy.Email}', '{daiLy.GhiChu}')";
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

        public static bool DeleteSupplier(string name)
        {
            string command = $"delete from DaiLy where tenDV = '{name}'";
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
