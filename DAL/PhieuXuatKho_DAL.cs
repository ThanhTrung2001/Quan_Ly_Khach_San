using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuXuatKho_DAL
    {
        private static SqlConnection conn;
        public static bool AddNewExport(PhieuXuatKho p)
        {
            string command = $"insert into PhieuXuatKho values ( '{p.MaPhieu}', '{p.NgayLap}', '{p.MaNV}', '{p.MaDSNL}', N'{p.LyDo}', N'{p.GhiChu}')";
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
