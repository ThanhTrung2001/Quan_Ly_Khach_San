using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DTO
{
    public class KhachHang
    {
        private string maKH;
        private string tenKhachHang;
        private string cmnd;
        private string sdt;
        private string diaChi;
        private string ghiChu;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
