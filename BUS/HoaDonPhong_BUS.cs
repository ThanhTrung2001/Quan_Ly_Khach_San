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
    }
}
