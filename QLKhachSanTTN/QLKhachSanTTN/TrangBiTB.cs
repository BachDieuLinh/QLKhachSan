using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKhachSanTTN
{
    public class TrangBiTB
    {
        KetNoiDB kn = new KetNoiDB();
        public DataTable ShowTrangbi()
        {
            string str = @"select MaPhong as [Mã Phòng],MaDoDung as [Mã Đồ Dùng],Soluong as [Số Lượng]
                from tblDoDung";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowMaTB()
        {
            string str = @"select MaDoDung as [Ma Đồ Dùng] from tblDoDung";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowMaLPhong()
        {
            string str = @"select MaPhong as [Mã Phòng] from tblPhong";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public string ThemTrangBi(string MaPhong, string MaDoDung, string SoLuong)
        {
            string str = "ThemTBTB";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@MaDoDung", MaDoDung);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public string SuaTrangBi(string MaPhong, string MaDoDung, string SoLuong)
        {
            string str = "SuaTBTB";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@MaDoDung", MaDoDung);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public string XoaTrangBi(string MaPhong, string MaDoDung)
        {
            string str = "XoaTBTB";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@MaDoDung", MaDoDung);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public DataTable TimKiemTBTB(string MaPhong, string MaDoDung, int chose)
        {
            string str = "TimKiemTBTB";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@MaDoDung", MaDoDung);
            cmd.Parameters.AddWithValue("@chose", chose);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            return dt;
        }
        public DataTable ShowPhong()
        {
            string str = @"select MaPhong as [MaPhong] from tblPhong";
            SqlConnection con = new SqlConnection(kn.KetNoi());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
