using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDichVu
    {
        private string maLoaiDichVu;
        private string loaiDichVu;

        public string MaLoaiDichVu { get => maLoaiDichVu; set => maLoaiDichVu = value; }
        public string TLoaiDichVu { get => loaiDichVu; set => loaiDichVu = value; }
    }
}
