using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuThanhToan_BUS
    {
        public static bool AddNewAgent(PhieuThanhToan p)
        {
            return PhieuThanhToan_DAL.AddNewBillAgent(p);
        }

        public static List<PhieuThanhToan> AgentList(string id)
        {
            return PhieuThanhToan_DAL.BillAgentList(id);
        }

        public static bool UpdateTotal(double total, string maDSNL)
        {
            return PhieuThanhToan_DAL.UpdateTotal(total, maDSNL);
        }

        public static bool UpdateConfirm(string maDL, string note, string maDSNL)
        {
            return PhieuThanhToan_DAL.UpdateConfirm(maDL, note, maDSNL);
        }
    }
}
