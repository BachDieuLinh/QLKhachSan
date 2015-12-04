using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSanTTN
{
    public partial class FormQLThuePhong : Form
    {
        objHoaDon hoadon = new objHoaDon();
        objNhanVien nhanvien = new objNhanVien();
        objKhachThuePhong khachhang = new objKhachThuePhong();
        public FormQLThuePhong()
        {
            InitializeComponent();
            HienThiDGVHoaDon();
            HienThiDGVKhachHang();
            HienThiDGVNhanVien();
        }
        public void HienThiDGVHoaDon()
        {
            dgvHoaDon.DataSource = hoadon.HienThiHoaDon();
        }

        public void HienThiDGVKhachHang()
        {
            dgvKhachHang.DataSource = khachhang.HienThiKhach();
        }

        public void HienThiDGVNhanVien()
        {
            dgvNhanVien.DataSource = nhanvien.HienThiNhanVien();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btGhiHD_Click(object sender, EventArgs e)
        {
           
            try
            {
                hoadon.GhiHD(txtMaHD.Text, txtMaCTHD.Text, txtMaKH.Text, txtMaNV.Text, DateTime.Now.ToString());
                HienThiDGVHoaDon();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

    }
}
