using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BUS;

namespace AutomationTesting
{
    public class RuiRo_Testing
    {
        public bool Search_Risk(string text)
        {
            if(RuiRo_DAO.SearchedRisk(text) !=null)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public bool Add_Risk(string id, string type, double refund)
        {
            if(id == ""|| type == "" || refund <0)
            {
                return false;
            }
            RuiRo ruiro = new RuiRo();
            ruiro.MaRR = id;
            ruiro.LoaiRR = type;
            ruiro.PhanHoanTien = refund;
            if(RuiRo_DAO.AddNewRisk(ruiro) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete_Risk(string id)
        {
            if(id == "")
            {
                return false;
            }    
            else if(RuiRo_DAO.DeleteRisk(id) == true)
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
