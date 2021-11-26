using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVu_BUS
    {
        public static List<DichVu> ServiceList()
        {
            return DichVu_DAL.ServiceList();
        }
        public static List<DichVu> ServiceListWithSearch(string tenDV)
        {
            return DichVu_DAL.ServiceListWithSearch(tenDV);
        }
        public static DichVu ServiceWithID(string id)
        {
            return DichVu_DAL.ServiceWithID(id);
        }
        public static bool AddNewService(DichVu dichVu)
        {
            return DichVu_DAL.AddNewService(dichVu);
        }
        public static bool DeleteService(string id)
        {
            return DichVu_DAL.DeleteService(id);
        }
    }
}
