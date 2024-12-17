﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class TheKhachHang : SampleView
    {
        public TheKhachHang()
        {
            InitializeComponent();
        }


        public override void btnThem_Click(object sender, EventArgs e)
        {
            ThemTheKhachHang frm = new ThemTheKhachHang();
            MainClass.BlurBackground(frm);
        }

        private void TheKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"SELECT * 
                           FROM THE_THANH_VIEN TV
                           JOIN KHACH_HANG KH ON TV.MaKhachHang = KH.MaKhachHang";
            guna2DataGridView1.AutoGenerateColumns = false;

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataTable vào DataGridView
                    guna2DataGridView1.DataSource = dt;

                    // Đặt DataPropertyName cho các cột
                    guna2DataGridView1.Columns["dgvId"].DataPropertyName = "MaSoThe";
                    guna2DataGridView1.Columns["dgvName"].DataPropertyName = "HoTen";
                    guna2DataGridView1.Columns["dgvhang"].DataPropertyName = "LoaiThe";
                    guna2DataGridView1.Columns["dgvDate"].DataPropertyName = "NgayLap";
                    guna2DataGridView1.Columns["dgvStaff"].DataPropertyName = "MaNhanVien";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView dgv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[0].Value = ++count;
            }
        }

        
    }
}
