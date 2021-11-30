using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DaiLy_BUS
    {
        public static List<DaiLy> SupplierList()
        {
            return DaiLy_DAL.SupplierList();
        }
        public static bool AddNewSupplier(DaiLy daiLy)
        {
            return DaiLy_DAL.AddNewSupplier(daiLy);
        }
        public static bool DeleteSupplier(string name)
        {
            return DaiLy_DAL.DeleteSupplier(name);
        }
    }
}
