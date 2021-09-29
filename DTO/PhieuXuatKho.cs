using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatKho
    {
        private string maPhieu;
        private string ngayLap;
        private string maNV;
        private string maDSNL;
        private string lyDo;
        private string ghiChu;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaDSNL { get => maDSNL; set => maDSNL = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
