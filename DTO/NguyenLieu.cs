using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu
    {
        private string maNL;
        private string tenNL;
        private string maLoaiNL;
        private string loaiNL;
        private string maDVT;
        private string DVT;
        private int soLuong;

        public string MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public string MaLoaiNL { get => maLoaiNL; set => maLoaiNL = value; }
        public string LoaiNL { get => loaiNL; set => loaiNL = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public string DVT1 { get => DVT; set => DVT = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
