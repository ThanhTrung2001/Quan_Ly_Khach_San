using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class RuiRo
    {
        private string maRR;
        private string loaiRR;
        private double phanHoanTien;

        public string MaRR { get => maRR; set => maRR = value; }
        public string LoaiRR { get => loaiRR; set => loaiRR = value; }
        public double PhanHoanTien { get => phanHoanTien; set => phanHoanTien = value; }
    }
}
