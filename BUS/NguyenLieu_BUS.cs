using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu> IngredientList()
        {
            return NguyenLieu_DAL.IngredientList();
        }

        public static List<NguyenLieu> IngredientListWithSearch(string name, string type)
        {
            return NguyenLieu_DAL.IngredientListWithSearch(name, type);
        }

        public static bool AddNewIngredient(NguyenLieu ingredient)
        {
            return NguyenLieu_DAL.AddNewIngredient(ingredient);
        }

        public static NguyenLieu IngredientWithID(string id)
        {
            return NguyenLieu_DAL.IngredientWithID(id);
        }

        public static bool UpdateAmount(string id, int amount)
        {
            return NguyenLieu_DAL.UpdateAmount(id, amount);
        }
    }
}
