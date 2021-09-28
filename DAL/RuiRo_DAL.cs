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
    public class RuiRo_DAO
    {
        static SqlConnection conn;

        public static List<RuiRo> RiskList()
        {
            string command = "select * from RuiRo";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<RuiRo> danhSach = new List<RuiRo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RuiRo ruiro = new RuiRo();
                ruiro.MaRR = dt.Rows[i]["maRR"].ToString();
                ruiro.LoaiRR = dt.Rows[i]["loaiRR"].ToString();
                ruiro.PhanHoanTien = double.Parse(dt.Rows[i]["phanHoanTien"].ToString());
         
                danhSach.Add(ruiro);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static bool AddNewRisk(RuiRo ruiRo)
        {
            string command = $"insert into RUIRO values (N'{ruiRo.MaRR}',N'{ruiRo.LoaiRR}',N'{ruiRo.PhanHoanTien}')";
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

        public static bool DeleteRisk(string maRR)
        {
            string command = $"delete from RUIRO where maRR = '{maRR}'";
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

        public static bool UpdateRisk(RuiRo ruiRo)
        {
            string command = $"update RUIRO set loaiRR = N'{ruiRo.LoaiRR}',phanHoanTien = N'{ruiRo.PhanHoanTien}' where maRR = '{ruiRo.MaRR}'";
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

        public static List<RuiRo> SearchedRisk(string searchString)
        {
            string command = $"select * from RuiRo where maRR like '%{searchString}%' or loaiRR like N'%{searchString}%' or phanHoanTien like '{searchString}%'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<RuiRo> danhSach = new List<RuiRo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RuiRo ruiRo = new RuiRo();
                ruiRo.MaRR = dt.Rows[i]["maRR"].ToString();
                ruiRo.LoaiRR = dt.Rows[i]["loaiRR"].ToString();
                ruiRo.PhanHoanTien = double.Parse(dt.Rows[i]["phanHoanTien"].ToString());
                danhSach.Add(ruiRo);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }
    }
}
