﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.View
{
    public partial class xemLaiGiaoHangView : Form
    {
        public xemLaiGiaoHangView(string maDonHang, string trangThai)
        {
            InitializeComponent();

        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
