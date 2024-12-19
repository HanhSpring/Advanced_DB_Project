﻿using System.Windows.Forms;

namespace Sushi_Restaurant
{
    partial class branch_revenue
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeSelection = new System.Windows.Forms.Label();
            this.cboTimeSelection = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.btnViewRevenue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboQuarter = new System.Windows.Forms.ComboBox();
            this.cboBranchId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labQuater = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.labBranch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xem Doanh Thu";
            // 
            // lblTimeSelection
            // 
            this.lblTimeSelection.AutoSize = true;
            this.lblTimeSelection.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSelection.Location = new System.Drawing.Point(150, 56);
            this.lblTimeSelection.Name = "lblTimeSelection";
            this.lblTimeSelection.Size = new System.Drawing.Size(96, 17);
            this.lblTimeSelection.TabIndex = 1;
            this.lblTimeSelection.Text = "Chọn thời gian:";
            // 
            // cboTimeSelection
            // 
            this.cboTimeSelection.FormattingEnabled = true;
            this.cboTimeSelection.Location = new System.Drawing.Point(13, 76);
            this.cboTimeSelection.Name = "cboTimeSelection";
            this.cboTimeSelection.Size = new System.Drawing.Size(121, 24);
            this.cboTimeSelection.TabIndex = 2;
            this.cboTimeSelection.SelectedIndexChanged += new System.EventHandler(this.cboTimeSelection_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(153, 76);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(432, 25);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(200, 22);
            this.txtRevenue.TabIndex = 4;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenue.Location = new System.Drawing.Point(275, 23);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(96, 23);
            this.lblRevenue.TabIndex = 5;
            this.lblRevenue.Text = "Doanh thu:";
            // 
            // btnViewRevenue
            // 
            this.btnViewRevenue.Location = new System.Drawing.Point(12, 487);
            this.btnViewRevenue.Name = "btnViewRevenue";
            this.btnViewRevenue.Size = new System.Drawing.Size(120, 30);
            this.btnViewRevenue.TabIndex = 6;
            this.btnViewRevenue.Text = "Xem Doanh Thu";
            this.btnViewRevenue.UseVisualStyleBackColor = true;
            this.btnViewRevenue.Click += new System.EventHandler(this.btnViewRevenue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(578, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(13, 193);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.Size = new System.Drawing.Size(693, 288);
            this.dgvRevenue.TabIndex = 1;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(558, 78);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(120, 24);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.Visible = false;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboQuarter
            // 
            this.cboQuarter.FormattingEnabled = true;
            this.cboQuarter.Location = new System.Drawing.Point(401, 78);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Size = new System.Drawing.Size(120, 24);
            this.cboQuarter.TabIndex = 3;
            this.cboQuarter.Visible = false;
            this.cboQuarter.SelectedIndexChanged += new System.EventHandler(this.cboQuarter_SelectedIndexChanged);
            // 
            // cboBranchId
            // 
            this.cboBranchId.Location = new System.Drawing.Point(153, 139);
            this.cboBranchId.Name = "cboBranchId";
            this.cboBranchId.Size = new System.Drawing.Size(121, 24);
            this.cboBranchId.TabIndex = 3;
            this.cboBranchId.SelectedIndexChanged += new System.EventHandler(this.cboBranchId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thống kê theo:";
            // 
            // labQuater
            // 
            this.labQuater.AutoSize = true;
            this.labQuater.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuater.Location = new System.Drawing.Point(398, 58);
            this.labQuater.Name = "labQuater";
            this.labQuater.Size = new System.Drawing.Size(31, 17);
            this.labQuater.TabIndex = 9;
            this.labQuater.Text = "Quý";
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth.Location = new System.Drawing.Point(555, 58);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(44, 17);
            this.labMonth.TabIndex = 10;
            this.labMonth.Text = "Tháng";
            // 
            // labBranch
            // 
            this.labBranch.AutoSize = true;
            this.labBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labBranch.Location = new System.Drawing.Point(27, 140);
            this.labBranch.Name = "labBranch";
            this.labBranch.Size = new System.Drawing.Size(89, 23);
            this.labBranch.TabIndex = 11;
            this.labBranch.Text = "Chi nhánh";
            // 
            // branch_revenue
            // 
            this.ClientSize = new System.Drawing.Size(710, 541);
            this.Controls.Add(this.labBranch);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labQuater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBranchId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewRevenue);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboTimeSelection);
            this.Controls.Add(this.lblTimeSelection);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboQuarter);
            this.Name = "branch_revenue";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.branch_revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeSelection;
        private System.Windows.Forms.ComboBox cboTimeSelection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Button btnViewRevenue;
        private System.Windows.Forms.Button btnClose;
        // Khai báo DataGridView
        private DataGridView dgvRevenue;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboQuarter;
        private System.Windows.Forms.ComboBox cboBranchId;
        private Label label1;
        private Label labQuater;
        private Label labMonth;
        private Label labBranch;
    }
}