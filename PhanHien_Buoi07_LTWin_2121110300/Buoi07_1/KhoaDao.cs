using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Buoi07_1
{
    class KhoaDao
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM KHOA";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = null;
            if(makhoa == null)
            {
                sql = "SELECT Khoa.MaKhoa, Khoa.TenKhoa, Khoa.GhiChu FROM Khoa INNER JOIN Khoa ON Khoa.MaKhoa = Khoa.MaKhoa";
            }
            else
            {
                sql = "SELECT Khoa.MaKhoa, khoa.TenKhoa, Khoa.GhiChu FROM Khoa INNER JOIN Khoa ON Khoa.MaKhoa = SinhVien.MaKhoa WHERE Khoa.MaKhoa='" + makhoa + "'";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(Khoa.MaKhoa) FROM Khoa INNER JOIN Khoa ON Khoa.MaKhoa=Khoa.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(string makhoa)
        {
            string sql = "SELECT Khoa.MaSV, Khoa.TenKhoa, Khoa.GhiChu";
            sql += "FROM Khoa INNER JOIN Khoa ON Khoa.MaKhoa = Khoa.MaKhoa WHERE Khoa.MaKhoa='" + makhoa + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }

        public void InsertOne(Khoa kh)
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,MaKhoa,DiemTB)";
            sql += "VALUES('" + kh.MaKhoa + "',N'" + kh.TenKhoa + "','" + kh.GhiChu + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOne(Khoa kh)
        {
            string sql = "UPDATE Khoa SET HoTen=N'" + kh.TenKhoa + "','" + kh.MaKhoa + "','" + kh.GhiChu + "'";
            sql += "WHERE MaKhoa='" + kh.MaKhoa + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(string makhoa)
        {
            string sql = "DETELE FROM Khoa WHERE MaSV='" + makhoa + "' ";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
