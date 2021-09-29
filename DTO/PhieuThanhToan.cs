using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThanhToan
    {
        private string maPhieu;
        private string ngayLap;
        private string maDL;
        private string maNV;
        private string maDSNL;
        private double tongTien;
        private string maTrangThai;
        private string tinhTrang;
        private string ghiChu;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaDL { get => maDL; set => maDL = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaDSNL { get => maDSNL; set => maDSNL = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string MaTrangThai { get => maTrangThai; set => maTrangThai = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
