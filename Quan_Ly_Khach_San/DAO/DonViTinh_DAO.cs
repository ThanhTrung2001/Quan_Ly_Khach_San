﻿using Quan_Ly_Khach_San.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DAO
{
    public class DonViTinh_DAO
    {
        static SqlConnection conn;
        public static List<DonViTinh> MeasureList()
        {
            string command = $"select * from DonViTinh";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DonViTinh> danhSach = new List<DonViTinh>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonViTinh donViTinh = new DonViTinh();
                donViTinh.MaDVT = dt.Rows[i]["maDVT"].ToString();
                donViTinh.DVT = dt.Rows[i]["donViTinh"].ToString();
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        public static string GetMeasure(string maDVT)
        {
            string command = $"select donViTinh from DonViTinh where maDVT = '{maDVT}'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(command, conn);
            if (dt.Rows.Count == 0)
                return null;

            string donViTinh;
            donViTinh = dt.Rows[0]["donViTinh"].ToString();

            return donViTinh;
        }
    }
}
