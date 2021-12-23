using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class LoaiDichVu_BUS
    {
        public static List<LoaiDichVu> ServiceTypeList()
        {
            return LoaiDichVu_DAL.ServiceTypeList();
        }
        public static string GetServiceType(string maLoaiDichVu)
        {
            return LoaiDichVu_DAL.GetServiceType(maLoaiDichVu);
        }

        public static bool AddServiceType(LoaiDichVu ldv)
        {
            return LoaiDichVu_DAL.AddServiceType(ldv);
        }
    }
}
