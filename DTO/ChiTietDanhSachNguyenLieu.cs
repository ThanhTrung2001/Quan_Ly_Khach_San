using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDanhSachNguyenLieu
    {
        private string maChiTiet;
        private string maDSNL;
        private string maNL;
        private string tenNL;
        private int soLuong;
        private string maDVT;
        private double gia;
        private double thanhTien;

        public string MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public string MaDSNL { get => maDSNL; set => maDSNL = value; }
        public string MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public double Gia { get => gia; set => gia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
