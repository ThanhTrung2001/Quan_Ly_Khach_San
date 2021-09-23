using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
{
    public class HoaDonMonAn_BUS
    {
        public static bool AddNewBill(HoaDonMonAn bill)
        {
            return HoaDonMonAn_DAO.AddNewBill(bill);
        }
    }
}
