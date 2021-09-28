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
    }
}
