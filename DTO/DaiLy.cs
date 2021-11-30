using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DaiLy
    {
		//	maDL varchar(10) primary key,
		//tenDL varchar(100),
		//diaChi varchar(100),
		//SDT varchar(10),
		//email varchar(100),
		//ghiChu varchar(100),
		private string maDL;
		private string tenDL;
		private string diaChi;
		private string SDT;
		private string email;
		private string ghiChu;

        public string MaDL { get => maDL; set => maDL = value; }
        public string TenDL { get => tenDL; set => tenDL = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email { get => email; set => email = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
