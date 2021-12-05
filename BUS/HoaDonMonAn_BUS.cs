using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonMonAn_BUS
    {
        public static bool AddNewBill(HoaDonMonAn bill)
        {
            return HoaDonMonAn_DAO.AddNewBill(bill);
        }

        public static List<HoaDonMonAn> BillList()
        {
            return HoaDonMonAn_DAO.BillList();
        }

        public static List<HoaDonMonAn> BillPendingList()
        {
            return HoaDonMonAn_DAO.BillPendingList();
        }

        public static bool UpdateBillPaid(HoaDonMonAn bill)
        {
            return HoaDonMonAn_DAO.UpdateBillPaid(bill);
        }

        public static List<HoaDonMonAn> BillListWithCustomerID(string id)
        {
            return HoaDonMonAn_DAO.BillListWithCustomerID(id);
        }

        public static List<HoaDonMonAn> BillPendingListWithCustomerID(string id)
        {
            return HoaDonMonAn_DAO.BillPendingListWithCustomerID(id);
        }

        public static List<HoaDonMonAn> FoodListWithDate(DateTime date, string customerid)
        {
            return HoaDonMonAn_DAO.FoodListWithDate(date, customerid);
        }

        public static List<HoaDonMonAn> FoodListWithMonth(DateTime date, string customerid)
        {
            return HoaDonMonAn_DAO.FoodListWithDate(date, customerid);
        }
    }
}
