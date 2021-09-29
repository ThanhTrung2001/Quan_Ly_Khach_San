using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNguyenLieu
    {
        private string maLoaiNL;
        private string loaiNguyenLieu;

        public string MaLoaiNL { get => maLoaiNL; set => maLoaiNL = value; }
        public string TLoaiNguyenLieu { get => loaiNguyenLieu; set => loaiNguyenLieu = value; }
    }
}
