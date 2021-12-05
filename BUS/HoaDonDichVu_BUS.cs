using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HoaDonDichVu_BUS
    {
        public static List<HoaDonDichVu> ServiceBillList()
        {
            return HoaDonDichVu_DAL.ServiceBillList();
        }
        public static bool AddNewServiceBill(HoaDonDichVu hoaDon)
        {
            return HoaDonDichVu_DAL.AddNewServiceBill(hoaDon);
        }
        public static List<HoaDonDichVu> ServiceBillPendingList()
        {
            return HoaDonDichVu_DAL.ServiceBillPendingList();
        }
        public static List<HoaDonDichVu> ServiceBillCompletedList()
        {
            return HoaDonDichVu_DAL.ServiceBillCompletedList();
        }
        public static bool UpdateServiceBill(HoaDonDichVu hoaDon)
        {
            return HoaDonDichVu_DAL.UpdateServiceBill(hoaDon);
        }

        public static List<HoaDonDichVu> ServiceListWithDate(DateTime date, string customerID)
        {
            return HoaDonDichVu_DAL.ServiceListWithDate(date, customerID);
        }

        public static List<HoaDonDichVu> ServiceListWithMonth(DateTime date, string customerID)
        {
            return HoaDonDichVu_DAL.ServiceListWithDate(date, customerID);
        }
    }
}
