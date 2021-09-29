using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapKho_DAL
    {
        private static SqlConnection conn;
        public static bool AddNewImport(PhieuNhapKho p)
        {
            //string command = $"insert into PhieuNhapKho(maPhieu, ngayLap, maNV, maDSNL, ghiChu) values ( '{p.MaPhieu}', '{p.NgayLap}', '{p.MaNV}', '{p.MaDSNL}', N'{p.GhiChu}')";
            string command = $"insert into PhieuNhapKho(maPhieu, ngayLap, maDSNL, ghiChu) values ( '{p.MaPhieu}', '{p.NgayLap}', '{p.MaDSNL}', N'{p.GhiChu}')";
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
