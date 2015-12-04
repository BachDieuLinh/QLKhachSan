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
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (treeView1.SelectedNode.Name == "root_GT_GTN")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhom thuc hien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_GT_GTSP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Gioi thieu san pham.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_Chinh")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Dang Nhap.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_DA")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Chinh.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_P")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Phong.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_KH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Khach Hang.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_TB")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Thiet Bi.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_TP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form QL Thue Phong.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_CTHD")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form CTHD.mht";
                webBrowser1.Navigate(str);
            }
        }
    }
}
