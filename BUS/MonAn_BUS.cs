using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
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

        public static bool AddFood(MonAn ma)
        {
            return MonAn_DAO.AddFood(ma);
        }

    }
}
