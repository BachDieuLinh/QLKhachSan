using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKhachSanTTN
{
    class objHoaDon
    {
        public DataTable HienThiHoaDon()
        {
            string sql = "SELECT * FROM tblHoaDon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void GhiHD(string MaHD,string MaCTHD, string MaKH, string MaNV, string NgayLapHD)
        {
            string sql = "Ins_HD";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            cmd.Parameters.AddWithValue("@MaCTHD", MaCTHD);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@NgayLapHD", NgayLapHD);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
