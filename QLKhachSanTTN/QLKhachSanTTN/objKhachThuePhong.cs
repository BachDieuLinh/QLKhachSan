using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKhachSanTTN
{
    class objKhachThuePhong
    {
        public DataTable HienThiKhach()
        {
            string sql = "SELECT * FROM tblKhachThuePhong";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemKhach(string TenKH, string GT, string NgaySinh, string CMND)
        {
            string sql = "ADDKhachThuePhong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@CMND", CMND);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaKhach(string MaKH, string TenKH, string GT, string NgaySinh, string CMND)
        {
            string sql = "SuaKhachThuePhong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@CMND", CMND);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaKhach(string MaKH)
        {
            string sql = "Xoa_KhachThuePhong";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
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

        // tìm kiếm khách theo mã khách
        public DataTable TKKhach_MaKhach(string MaKhach)
        {
            string sql = "SELECT * FROM tblKhachThuePhong WHERE MaKH LIKE N'%' + @MaKH + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaKH", MaKhach);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // tìm kiếm khách theo họ tên
        public DataTable TKKhach_TenKhach(string HoTen)
        {
            string sql = "SELECT * FROM tblKhachThuePhong WHERE TenKH LIKE N'%' + @TenKH + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenKH", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // tìm kiếm khách theo CMND
        public DataTable TKKhach_CMND(string CMND)
        {
            string sql = "SELECT * FROM tblKhachThuePhong WHERE CMND LIKE N'%' + @CMND + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@CMND", CMND);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
