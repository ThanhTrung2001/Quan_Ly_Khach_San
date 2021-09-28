using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RuiRo_BUS
    {
        public static bool AddNewRisk(RuiRo ruiRo)
        {
            return RuiRo_DAO.AddNewRisk(ruiRo);
        }

        public static bool UpdateRisk(RuiRo ruiRo)
        {
            return RuiRo_DAO.UpdateRisk(ruiRo);
        }

        public static bool DeleteRisk(string maRR)
        {
            return RuiRo_DAO.DeleteRisk(maRR);
        }
        public static List<RuiRo> RiskList()
        {
            return RuiRo_DAO.RiskList();
        }

        public static List<RuiRo> SearchedRisk(string searchString)
        {
            return RuiRo_DAO.SearchedRisk(searchString);
        }
    }
}
