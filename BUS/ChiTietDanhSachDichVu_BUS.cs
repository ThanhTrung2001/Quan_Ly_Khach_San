using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ChiTietDanhSachDichVu_BUS
    {

        public static bool AddNewListServiceDetail(ChiTietDanhSachDichVu chiTiet)
        {
            return ChiTietDanhSachDichVu_DAL.AddNewListServiceDetail(chiTiet);
        }
        //load data service list
        public static List<ChiTietDanhSachDichVu> ServiceList()
        {
            return ChiTietDanhSachDichVu_DAL.ServiceList();
        }
        //load data service list chosen
        public static List<DichVu> ServiceLists(string id)
        {
            return ChiTietDanhSachDichVu_DAL.ServiceLists(id);
        }
    }
}
