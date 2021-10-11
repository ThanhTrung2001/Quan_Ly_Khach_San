using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonPhong
    {
        private string maHoaDon;
        private string checkin;
        private string checkout;
        private string maNV;
        private string maKH;
        private string maPhong;
        private int soNgayO;
        private double tongTien;
        private double tienNhan;
        private double tienThua;
        private string maRR;
        private double soTienHoan;
        private string maTinhTrang;
        private string ghiChu;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string Checkin { get => checkin; set => checkin = value; }
        public string Checkout { get => checkout; set => checkout = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int SoNgayO { get => soNgayO; set => soNgayO = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public double TienNhan { get => tienNhan; set => tienNhan = value; }
        public double TienThua { get => tienThua; set => tienThua = value; }
        public string MaRR { get => maRR; set => maRR = value; }
        public double SoTienHoan { get => soTienHoan; set => soTienHoan = value; }
        public string MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
