﻿namespace Sushi_Restaurant.Admin
{
    partial class Load_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dataview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvAdjust = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.AddEmp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dataview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dataview.ColumnHeadersHeight = 45;
            this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvDateOfBirth,
            this.dgvOffice,
            this.dgvSalary,
            this.dgvBranch,
            this.dgvDateStart,
            this.dgvDateEnd,
            this.dgvUpdate,
            this.dgvDelete,
            this.dgvAdjust});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dataview.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.Location = new System.Drawing.Point(0, 129);
            this.Dataview.Name = "Dataview";
            this.Dataview.RowHeadersVisible = false;
            this.Dataview.RowHeadersWidth = 51;
            this.Dataview.RowTemplate.Height = 24;
            this.Dataview.Size = new System.Drawing.Size(1281, 376);
            this.Dataview.TabIndex = 10;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dataview.ThemeStyle.HeaderStyle.Height = 45;
            this.Dataview.ThemeStyle.ReadOnly = false;
            this.Dataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dataview.ThemeStyle.RowsStyle.Height = 24;
            this.Dataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dataview_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "Mã nhân viên";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Họ tên";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            // 
            // dgvDateOfBirth
            // 
            this.dgvDateOfBirth.HeaderText = "Ngày sinh";
            this.dgvDateOfBirth.MinimumWidth = 6;
            this.dgvDateOfBirth.Name = "dgvDateOfBirth";
            // 
            // dgvOffice
            // 
            this.dgvOffice.HeaderText = "Bộ phận";
            this.dgvOffice.MinimumWidth = 6;
            this.dgvOffice.Name = "dgvOffice";
            // 
            // dgvSalary
            // 
            this.dgvSalary.HeaderText = "Lương";
            this.dgvSalary.MinimumWidth = 6;
            this.dgvSalary.Name = "dgvSalary";
            // 
            // dgvBranch
            // 
            this.dgvBranch.HeaderText = "Chi nhánh";
            this.dgvBranch.MinimumWidth = 6;
            this.dgvBranch.Name = "dgvBranch";
            // 
            // dgvDateStart
            // 
            this.dgvDateStart.HeaderText = "Ngày vào làm";
            this.dgvDateStart.MinimumWidth = 6;
            this.dgvDateStart.Name = "dgvDateStart";
            // 
            // dgvDateEnd
            // 
            this.dgvDateEnd.HeaderText = "Ngày kết thúc";
            this.dgvDateEnd.MinimumWidth = 6;
            this.dgvDateEnd.Name = "dgvDateEnd";
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.HeaderText = "Chuyển";
            this.dgvUpdate.MinimumWidth = 6;
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "Xóa";
            this.dgvDelete.MinimumWidth = 6;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvAdjust
            // 
            this.dgvAdjust.HeaderText = "Cập nhật";
            this.dgvAdjust.MinimumWidth = 6;
            this.dgvAdjust.Name = "dgvAdjust";
            this.dgvAdjust.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdjust.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddEmp
            // 
            this.AddEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.AddEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmp.ForeColor = System.Drawing.Color.White;
            this.AddEmp.Location = new System.Drawing.Point(1071, 524);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(180, 45);
            this.AddEmp.TabIndex = 11;
            this.AddEmp.Text = "Thêm nhân viên";
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Sushi_Restaurant.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(104, 101);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(395, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Nhân Viên";
            // 
            // Load_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1289, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.Dataview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Load_Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView Dataview;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateEnd;
        private System.Windows.Forms.DataGridViewImageColumn dgvUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
        private System.Windows.Forms.DataGridViewImageColumn dgvAdjust;
        private Guna.UI2.WinForms.Guna2Button AddEmp;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}