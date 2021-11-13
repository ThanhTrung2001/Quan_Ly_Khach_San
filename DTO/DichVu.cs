using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DichVu
    {
        //	maDV varchar(10) primary key,
        //	tenDV varchar(100),
        //maLoaiDichVu varchar(10),
        //maDVT varchar(10),
        //gia money,
        //soLuong int,
        //maTinhTrang varchar(10),
        private string maDV;
        private string tenDV;
        private string maLoaiDV;
        private string maDVT;
        private double gia;
        private int soLuong;
        private string maTinhTrang;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string MaLoaiDV { get => maLoaiDV; set => maLoaiDV = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public double Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
    }
}
