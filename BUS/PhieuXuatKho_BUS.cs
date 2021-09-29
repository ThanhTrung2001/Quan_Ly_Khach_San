using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuXuatKho_BUS
    {
        public static bool AddNewExport(PhieuXuatKho p)
        {
            return PhieuXuatKho_DAL.AddNewExport(p);
        }
    }
}
