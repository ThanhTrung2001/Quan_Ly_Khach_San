﻿using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
{
    public class ChiTietDanhSachMonAn_BUS
    {
        public static bool AddNewFoodListDetail(ChiTietDanhSachMonAn detail)
        {
            return ChiTietDanhSachMonAn_DAO.AddNewListFoodDetail(detail);
        }

        public static List<MonAn> FoodList(string listFoodID)
        {
            return ChiTietDanhSachMonAn_DAO.FoodList(listFoodID);
        }
    }
}
