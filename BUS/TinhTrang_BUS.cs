using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TinhTrang_BUS
    {
        public static List<TinhTrang> StatusList()
        {
            return TinhTrang_DAO.StatusList();
        }

        public static string GetStatus(string id)
        {
            return TinhTrang_DAO.GetStatus(id);
        }
    }
}
