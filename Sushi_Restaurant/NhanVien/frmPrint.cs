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
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            ThemDanhGia frm = new ThemDanhGia();
            MainClass.BlurBackground(frm);
        }
    }
}
