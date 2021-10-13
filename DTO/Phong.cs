using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private string maPhong;
        private string loaiPhong;
        private double gia;
        private string tinhTrang;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public double Gia { get => gia; set => gia = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
