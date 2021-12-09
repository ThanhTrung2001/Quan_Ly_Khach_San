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
    public class MonAn_Testing
    {
       
        public bool Search_Name(string name, string type)
        {
            if (MonAn_DAO.FoodListWithSearch(name,type) != null)
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
