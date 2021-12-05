using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonPhong_BUS
    {
        public static bool AddNewBill(HoaDonPhong bill)
        {
            return HoaDonPhong_DAL.AddNewBill(bill);
        }

        public static List<HoaDonPhong> RoomBillList()
        {
            return HoaDonPhong_DAL.RoomBillList();
        }

        public static List<HoaDonPhong> RoomBillPendingList()
        {
            return HoaDonPhong_DAL.RoomBillPendingList();
        }

        public static List<HoaDonPhong> RoomBillCompletedList()
        {
            return HoaDonPhong_DAL.RoomBillCompletedList();
        }

        public static bool UpdateRoom(String idPhong)
        {
            return HoaDonPhong_DAL.UpdateRoom(idPhong);
        }

        public static bool UpdateRoomBill(HoaDonPhong hoaDonPhong)
        {
            return HoaDonPhong_DAL.UpdateRoomBill(hoaDonPhong);
        }

        public static bool UpdateRoomAfter(String idPhong)
        {
            return HoaDonPhong_DAL.UpdateRoomAfter(idPhong);
        }

        public static List<HoaDonPhong> RoomListWithDate(DateTime date, string CustomerID)
        {
            return HoaDonPhong_DAL.RoomListWithDate(date, CustomerID);
        }

        public static List<HoaDonPhong> RoomListWithMonth(string thang, string nam, string CustomerID)
        {
            return HoaDonPhong_DAL.RoomListWithMonth(thang, nam, CustomerID);
        }

        public static List<HoaDonPhong> SearchedHoaDonPhong(string searchString)
        {
            return HoaDonPhong_DAL.SearchedHoaDonPhong(searchString);
        }
    }
}
