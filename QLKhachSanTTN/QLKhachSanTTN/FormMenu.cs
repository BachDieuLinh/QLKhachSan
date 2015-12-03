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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLKhachHang frmQLKH = new FormQLKhachHang();
            frmQLKH.Show();
        }

        private void mượnTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLThuePhong frmThuePhong = new FormQLThuePhong();
            frmThuePhong.Show();
        }
    }
}
