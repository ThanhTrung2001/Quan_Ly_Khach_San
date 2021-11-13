using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietDanhSachDichVu
    {
        private string maChiTietDV;
        private string maDSDV;
        private string maDV;
        private string maLoaiDV;
        private int soLuong;
        private string maDVT;
        private double gia;
        private double thanhTien;
        private string ghiChu;

        public string MaChiTietDV { get => maChiTietDV; set => maChiTietDV = value; }
        public string MaDSDV { get => maDSDV; set => maDSDV = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string MaLoaiDV { get => maLoaiDV; set => maLoaiDV = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public double Gia { get => gia; set => gia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
