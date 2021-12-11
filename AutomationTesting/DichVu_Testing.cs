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
    public class DichVu_Testing
    {
        public bool Search_Id(string id)
        {
            if(DichVu_DAL.ServiceWithID(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Search_Name(string name)
        {
            if (DichVu_DAL.ServiceListWithSearch(name) != null)
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
