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
    public class Login_Testing
    {
        public bool Login_Valid( string username, string password)
        {
            if (username == "" || password == "")
            {
                return false;
            }
            else if (username == "thukho")
            {
                if (password == "123456")
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else if (username == "daubep")
            {
                if (password == "123456")
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            else if (username == "letan")
            {
                if (password == "123456")
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            else if (username == "ketoan")
            {
                if (password == "123456")
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            else if (username == "giamdoc")
            {
                if (password == "admin")
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            //else if (username == "")
            //{
            //    if (password != "")
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            else
            {
                return false;
            }
        }
    }
}
