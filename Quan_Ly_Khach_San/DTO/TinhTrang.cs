using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class TinhTrang
    {
        private string maTinhTrang;
        private string tinhTrang;

        public string MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
        public string TenTinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
