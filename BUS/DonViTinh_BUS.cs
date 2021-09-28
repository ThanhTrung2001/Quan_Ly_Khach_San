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
            return DonViTinh_DAO.MeasureList();
        }

        public static string GetMeasure(string id)
        {
            return DonViTinh_DAO.GetMeasure(id);
        }
    }
}
