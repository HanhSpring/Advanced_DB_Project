﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Sử dụng thông tin của người dùng
            string maNhanVien = MainClass.user.MaNhanVien;
            string maChiNhanh = MainClass.user.MaChiNhanh;
            // Hiển thị thông tin người dùng trên màn hình chính
            nvid.Text = maNhanVien;
            cnid.Text = maChiNhanh;
        }

        static frmMain _obj;
        public static frmMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmMain();
                }
                return _obj;
            }
        }
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //lbl.UserName.Text = MainClass.USER
            _obj=this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

       

        private void btnTheTV_Click(object sender, EventArgs e)
        {
            AddControls(new TheKhachHang());
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            frmPOS frm= new frmPOS();
            frm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new CapNhatTrangThai());
        }
    }
}
