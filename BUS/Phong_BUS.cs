using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class Phong_BUS
    {
        public static Phong RoomList(string maPhong)
        {
            return Phong_DAL.RoomList(maPhong);
        }

        public static bool CheckEmpty(string maPhong)
        {
            return Phong_DAL.CheckEmpty(maPhong);
        }

        public static bool GetRoom(string maPhong)
        {
            return Phong_DAL.GetRoom(maPhong);
        }
        public static bool AddNewRoom(Phong phong)
        {
            return Phong_DAL.AddNewRoom(phong);
        }
    }
}
