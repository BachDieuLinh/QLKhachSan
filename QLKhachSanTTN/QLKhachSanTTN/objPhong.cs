using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKhachSanTTN
{
    class objPhong
    {
        public DataTable HienThiPhong()
        {
            string sql = "SELECT * FROM tblPhong";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemPhong(string TenPhong, string LoaiPhong)
        {
            string sql = "ADDPhong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaPhong(string MaPhong, string TenPhong, string LoaiPhong)
        {
            string sql = "SuaPhong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaPhong(string MaPhong)
        {
            string sql = "Xoa_Phong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        // Tìm kiếm Phòng theo mã
        public DataTable TKPhong_MaPhong(string MaPhong)
        {
            string sql = "SELECT * FROM tblPhong WHERE MaPhong LIKE N'%' + @MaPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm phòng theo tên
        public DataTable TKPhong_TenPhong(string TenPhong)
        {
            string sql = "SELECT * FROM tblPhong WHERE TenPhong LIKE N'%' + @TenPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm phòng theo loại
        public DataTable TKPhong_LoaiPhong(string LoaiPhong)
        {
            string sql = "SELECT * FROM tblPhong WHERE LoaiPhong LIKE N'%' + @LoaiPhong + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //Show đồ dùng trong phòng theo mã
        public DataTable ShowDoDung_Ma(string MaPhong)
        {
            string sql = "SELECT * FROM tblPhong WHERE MaPhong=@MaPhong";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
