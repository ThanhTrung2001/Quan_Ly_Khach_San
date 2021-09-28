using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiMonAn_BUS
    {
        public static List<LoaiMonAn> FoodTypeList()
        {
            return LoaiMonAn_DAO.FoodTypeList();
        }

        public static string GetFoodType(string id)
        {
            return LoaiMonAn_DAO.GetFoodType(id);
        }
    }
}
