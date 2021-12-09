using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BUS;
using DTO;
using Quan_Ly_Khach_San.GUI;

namespace AutomationTesting
{
    public class KhachHang_Testing
    {
        public bool Search_Customer(string text)
        {
            if(KhachHang_DAO.SearchedCustomer(text) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Add_Customer(string identity, string name, string SDT, string CMND, string DiaChi, string GhiChu )
        {
            if(identity == "" || name == "")
            {
                return false;
            }
            else if(Search_Customer(name) == true || Search_Customer(identity) == true)
            {
                return false;
            }    
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = identity;
            khachHang.TenKhachHang = name;
            khachHang.SDT = SDT;
            khachHang.CMND = CMND;
            khachHang.DiaChi = DiaChi;
            khachHang.GhiChu = GhiChu;
            if(KhachHang_DAO.AddNewCustomer(khachHang) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete_Customer(string id)
        {
            if(id == "")
            {
                return false;
            }
            else if(Search_Customer(id) == false)
            {
                return false;
            }    
            else if(KhachHang_DAO.DeleteCustomer(id) == true)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }

    }
}
