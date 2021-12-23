using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonViTinh_BUS
    {
        public static List<DonViTinh> MeasureList()
        {
            return DonViTinh_DAL.MeasureList();
        }

        public static string GetMeasure(string id)
        {
            return DonViTinh_DAL.GetMeasure(id);
        }

        public static bool AddUnit(DonViTinh dvt)
        {
            return DonViTinh_DAL.AddNewUnit(dvt);
        }
    }
}
