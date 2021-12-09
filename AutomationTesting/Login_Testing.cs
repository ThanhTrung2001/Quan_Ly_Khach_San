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
        public int Login_Valid( string username, string password)
        {
            if (username == "" || password == "")
            {
                return -1;
            }
            else if (username == "thukho")
            {
                if (password == "123456")
                {
                    return 4;
                }
                else
                {
                    return -1;

                }
            }
            else if (username == "daubep")
            {
                if (password == "123456")
                {
                    return 3;
                }
                else
                {
                    return -1;

                }

            }
            else if (username == "letan")
            {
                if (password == "123456")
                {
                    return 2;
                }
                else
                {
                    return -1;

                }

            }
            else if (username == "ketoan")
            {
                if (password == "123456")
                {
                    return 1;
                }
                else
                {
                    return -1;

                }

            }
            else if (username == "giamdoc")
            {
                if (password == "admin")
                {
                    return 0;
                }
                else
                {
                    return -1;

                }
            }
            else
            {
                return -1;
            }
        }
    }
}
