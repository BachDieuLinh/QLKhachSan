﻿namespace QLKhachSanTTN
{
    partial class frmHuongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhóm Thực Hiện");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giới Thiệu Sản Phẩm");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GIỚI THIỆU CHUNG", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Form Đăng Nhập");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Form Chính");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Form Phòng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Form QL Khách Hàng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Form QL Thiết Bị");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Form QL Thuê Phòng");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Form Ghi CT HĐ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("HƯỚNG DẪN SỬ DỤNG", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "root_GT_GTN";
            treeNode1.Text = "Nhóm Thực Hiện";
            treeNode2.Name = "root_GT_GTSP";
            treeNode2.Text = "Giới Thiệu Sản Phẩm";
            treeNode3.Name = "root_GT";
            treeNode3.Text = "GIỚI THIỆU CHUNG";
            treeNode4.Name = "root_HD_Chinh";
            treeNode4.Text = "Form Đăng Nhập";
            treeNode5.Name = "root_HD_DA";
            treeNode5.Text = "Form Chính";
            treeNode6.Name = "root_HD_P";
            treeNode6.Text = "Form Phòng";
            treeNode7.Name = "root_HD_KH";
            treeNode7.Text = "Form QL Khách Hàng";
            treeNode8.Name = "root_HD_TB";
            treeNode8.Text = "Form QL Thiết Bị";
            treeNode9.Name = "root_HD_TP";
            treeNode9.Text = "Form QL Thuê Phòng";
            treeNode10.Name = "root_HD_CTHD";
            treeNode10.Text = "Form Ghi CT HĐ";
            treeNode11.Name = "root_HD";
            treeNode11.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(228, 379);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(255, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(662, 379);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 403);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}