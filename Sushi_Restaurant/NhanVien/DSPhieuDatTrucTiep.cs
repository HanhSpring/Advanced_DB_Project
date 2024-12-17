﻿using System;
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
    public partial class DSPhieuDatTrucTiep : Form
    {
        public DSPhieuDatTrucTiep()
        {
            InitializeComponent();
        }

        public string MainId = "";
        private void DSPhieuDatTrucTiep_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string qry = @"SELECT PD.MaPhieu,PD.SoBan 
                           FROM PHIEU_DAT_TRUC_TIEP PD ";

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
                    guna2DataGridView1.Columns["dgvId"].DataPropertyName = "MaPhieu";
                    guna2DataGridView1.Columns["dgvTable"].DataPropertyName = "SoBan";
           
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }


        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                MainId = guna2DataGridView1.CurrentRow.Cells["dgvId"].Value.ToString();
                this.Close();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvprint")
            {
                this.Close();


            }

        }
    }
}
