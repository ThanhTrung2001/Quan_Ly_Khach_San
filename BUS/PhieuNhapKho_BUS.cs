using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapKho_BUS
    {
        public static bool AddNewImport(PhieuNhapKho p)
        {
            return PhieuNhapKho_DAL.AddNewImport(p);
        }
    }
}
