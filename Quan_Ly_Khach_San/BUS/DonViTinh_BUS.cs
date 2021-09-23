using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
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
