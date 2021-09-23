using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
{
    public class TinhTrang_BUS
    {
        public List<TinhTrang> StatusList()
        {
            return TinhTrang_DAO.StatusList();
        }

        public string GetStatus(string id)
        {
            return TinhTrang_DAO.GetStatus(id);
        }
    }
}
