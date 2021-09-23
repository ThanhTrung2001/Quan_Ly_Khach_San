using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class HoaDonMonAn
    {
        private string maHoaDon;
        private string ngayLap;
        private string maNV;
        private string maKH;
        private string maDSMA;
        private double tongTien;
        private double tienNhan;
        private double tienThua;
        private string maRR;
        private double soTienHoan;
        private string maTinhTrang;
        private string ghiChu;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaDSMA { get => maDSMA; set => maDSMA = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public double TienNhan { get => tienNhan; set => tienNhan = value; }
        public double TienThua { get => tienThua; set => tienThua = value; }
        public string MaRR { get => maRR; set => maRR = value; }
        public double SoTienHoan { get => soTienHoan; set => soTienHoan = value; }
        public string MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
