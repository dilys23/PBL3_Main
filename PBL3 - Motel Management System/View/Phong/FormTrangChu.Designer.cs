﻿namespace PBL3___Motel_Management_System.View
{
    partial class FormTrangChu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.ChartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSoLuong = new System.Windows.Forms.DataGridView();
            this.TinhTrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTinhTrang = new System.Windows.Forms.DataGridView();
            this.Maphongtro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDesktop.Controls.Add(this.btnTim);
            this.panelDesktop.Controls.Add(this.dtpThang);
            this.panelDesktop.Controls.Add(this.ChartCot);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.dgvSoLuong);
            this.panelDesktop.Controls.Add(this.TinhTrang);
            this.panelDesktop.Controls.Add(this.dgvTinhTrang);
            this.panelDesktop.Location = new System.Drawing.Point(5, 4);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1150, 631);
            this.panelDesktop.TabIndex = 6;
            this.panelDesktop.SizeChanged += new System.EventHandler(this.panelDesktop_SizeChanged);
            // 
            // ChartCot
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartCot.Legends.Add(legend1);
            this.ChartCot.Location = new System.Drawing.Point(28, 413);
            this.ChartCot.Name = "ChartCot";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Dãy trọ";
            this.ChartCot.Series.Add(series1);
            this.ChartCot.Size = new System.Drawing.Size(427, 191);
            this.ChartCot.TabIndex = 40;
            this.ChartCot.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "TÌNH TRẠNG PHÒNG";
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvSoLuong.AllowUserToAddRows = false;
            this.dgvSoLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoLuong.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TinhTrang1,
            this.SoLuongPhong});
            this.dgvSoLuong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSoLuong.Location = new System.Drawing.Point(505, 387);
            this.dgvSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.RowHeadersWidth = 51;
            this.dgvSoLuong.RowTemplate.Height = 24;
            this.dgvSoLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoLuong.Size = new System.Drawing.Size(573, 217);
            this.dgvSoLuong.TabIndex = 2;
            // 
            // TinhTrang1
            // 
            this.TinhTrang1.HeaderText = "Tình trạng";
            this.TinhTrang1.MinimumWidth = 6;
            this.TinhTrang1.Name = "TinhTrang1";
            // 
            // SoLuongPhong
            // 
            this.SoLuongPhong.HeaderText = "Số lượng phòng";
            this.SoLuongPhong.MinimumWidth = 6;
            this.SoLuongPhong.Name = "SoLuongPhong";
            // 
            // TinhTrang
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.TinhTrang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TinhTrang.Legends.Add(legend2);
            this.TinhTrang.Location = new System.Drawing.Point(25, 52);
            this.TinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.TinhTrang.Name = "TinhTrang";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "TinhTrang";
            this.TinhTrang.Series.Add(series2);
            this.TinhTrang.Size = new System.Drawing.Size(433, 311);
            this.TinhTrang.TabIndex = 1;
            this.TinhTrang.Text = "Tinhtrang";
            title1.Name = "ConTrong";
            title2.Name = "ChoThue";
            title3.Name = "DangCoc";
            this.TinhTrang.Titles.Add(title1);
            this.TinhTrang.Titles.Add(title2);
            this.TinhTrang.Titles.Add(title3);
            // 
            // dgvTinhTrang
            // 
            this.dgvTinhTrang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTinhTrang.AllowUserToAddRows = false;
            this.dgvTinhTrang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrang.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphongtro,
            this.Stt,
            this.TenDayTro,
            this.TenPhongTro,
            this.TinhTrang2});
            this.dgvTinhTrang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTinhTrang.Location = new System.Drawing.Point(505, 52);
            this.dgvTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTinhTrang.Name = "dgvTinhTrang";
            this.dgvTinhTrang.RowHeadersWidth = 51;
            this.dgvTinhTrang.RowTemplate.Height = 24;
            this.dgvTinhTrang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTinhTrang.Size = new System.Drawing.Size(573, 311);
            this.dgvTinhTrang.TabIndex = 2;
            // 
            // Maphongtro
            // 
            this.Maphongtro.HeaderText = "Maphongtro";
            this.Maphongtro.MinimumWidth = 6;
            this.Maphongtro.Name = "Maphongtro";
            this.Maphongtro.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // TenDayTro
            // 
            this.TenDayTro.HeaderText = "Tên dãy trọ";
            this.TenDayTro.MinimumWidth = 6;
            this.TenDayTro.Name = "TenDayTro";
            // 
            // TenPhongTro
            // 
            this.TenPhongTro.HeaderText = "Tên phòng trọ";
            this.TenPhongTro.MinimumWidth = 6;
            this.TenPhongTro.Name = "TenPhongTro";
            // 
            // TinhTrang2
            // 
            this.TinhTrang2.HeaderText = "Tình trạng";
            this.TinhTrang2.MinimumWidth = 6;
            this.TinhTrang2.Name = "TinhTrang2";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTim.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 25;
            this.btnTim.Location = new System.Drawing.Point(29, 369);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(35, 34);
            this.btnTim.TabIndex = 42;
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(70, 373);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(124, 22);
            this.dtpThang.TabIndex = 41;
            // 
            // FormTrangChu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 660);
            this.Controls.Add(this.panelDesktop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart TinhTrang;
        private System.Windows.Forms.DataGridView dgvTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphongtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCot;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.DateTimePicker dtpThang;
    }
}