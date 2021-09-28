using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        private string maMonAn;
        private string tenMonAn;
        private string maLoaiMonAn;
        private string loaiMonAn;
        private string maDVT;
        private string donViTinh;
        private double gia;
        private string ghiChu;

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string MaLoaiMonAn { get => maLoaiMonAn; set => maLoaiMonAn = value; }
        public string LoaiMonAn { get => loaiMonAn; set => loaiMonAn = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double Gia { get => gia; set => gia = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
