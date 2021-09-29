using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiNguyenLieu_BUS
    {
        public static List<LoaiNguyenLieu> IngredientTypeList()
        {
            return LoaiNguyenLieu_DAL.IngredientType();
        }

        public static string GetIngredientType(string id)
        {
            return LoaiNguyenLieu_DAL.GetIngredientType(id);
        }
    }
}
