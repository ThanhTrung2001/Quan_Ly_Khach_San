using Quan_Ly_Khach_San.DAO;
using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.BUS
{
    public class KhachHang_BUS
    {
        public static  bool AddNewCustomer(KhachHang khachHang)
        {
            return KhachHang_DAO.AddNewCustomer(khachHang);
        }

        public static bool UpdateCustomer(KhachHang khachHang)
        {
            return KhachHang_DAO.UpdateCustomer(khachHang);
        }

        public static  bool DeleteCustomer(string maKH)
        {
            return KhachHang_DAO.DeleteCustomer(maKH);
        }

        public static  List<KhachHang> CustomerList()
        {
            return KhachHang_DAO.CustomerList();
        } 

        public static  List<KhachHang> SearchedCustomer(string searchString)
        {
            return KhachHang_DAO.SearchedCustomer(searchString);
        }
    }
}
