﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Buoi07_3
{
    class NhanVienDao
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public NhanVienDao()
        {
            conn = kn.getConnect();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable getList()
        {
            string sql = "SELECT * FROM NhanVien";

            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
    }
}
