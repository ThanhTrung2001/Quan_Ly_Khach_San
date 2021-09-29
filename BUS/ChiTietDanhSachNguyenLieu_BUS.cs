using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietDanhSachNguyenLieu_BUS
    {
        public static bool AddNewIngredientListDetail(ChiTietDanhSachNguyenLieu detail)
        {
            return ChiTietDanhSachNguyenLieu_DAL.AddNewListIngredientDetail(detail);
        }

        public static List<ChiTietDanhSachNguyenLieu> IngredientList(string listFoodID)
        {
            return ChiTietDanhSachNguyenLieu_DAL.IngredientList(listFoodID);
        }

        public static List<ChiTietDanhSachNguyenLieu> IngredientLists()
        {
            return ChiTietDanhSachNguyenLieu_DAL.IngredientLists();
        }
    }
}
