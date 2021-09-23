using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class LoaiMonAn
    {
        private string maLoaiMonAn;
        private string loaiMonAn;

        public string MaLoaiMonAn { get => maLoaiMonAn; set => maLoaiMonAn = value; }
        public string TLoaiMonAn { get => loaiMonAn; set => loaiMonAn = value; }
    }
}
