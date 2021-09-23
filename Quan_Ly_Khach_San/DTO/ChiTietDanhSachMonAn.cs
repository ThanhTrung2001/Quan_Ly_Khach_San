using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class ChiTietDanhSachMonAn
    {
        private string maChiTiet;
        private string maDSMA;
        private string maMonAn;
        private string tenMonAn;
        private int soLuong;
        private string maDVT;
        private string donViTinh;
        private double gia;
        private double thanhTien;
        private string ghiChu;

        public string MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public string MaDSMA { get => maDSMA; set => maDSMA = value; }
        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public double Gia { get => gia; set => gia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
