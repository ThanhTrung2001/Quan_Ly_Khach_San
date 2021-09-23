using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
{
    public class MonAn_BUS
    {
        public static List<MonAn> FoodList()
        {
            return MonAn_DAO.FoodList();
        }

        public static List<MonAn> FoodListWithSearch(string name, string type)
        {
            return MonAn_DAO.FoodListWithSearch(name, type);
        }

    }
}
