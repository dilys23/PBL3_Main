﻿namespace PBL3___Motel_Management_System.View
{
    partial class ChiTietPT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTroVe = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPhong = new System.Windows.Forms.Panel();
            this.panelChitietPT = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHopDong = new FontAwesome.Sharp.IconButton();
            this.btnCocPhong = new FontAwesome.Sharp.IconButton();
            this.btnThanhVien = new FontAwesome.Sharp.IconButton();
            this.btnDichVu = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelPhong.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btnTroVe);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 60);
            this.panel1.TabIndex = 45;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTroVe.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTroVe.IconColor = System.Drawing.Color.White;
            this.btnTroVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroVe.IconSize = 30;
            this.btnTroVe.Location = new System.Drawing.Point(1237, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(43, 37);
            this.btnTroVe.TabIndex = 62;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "CHI TIẾT PHÒNG";
            // 
            // panelPhong
            // 
            this.panelPhong.Controls.Add(this.panelChitietPT);
            this.panelPhong.Controls.Add(this.flowLayoutPanel1);
            this.panelPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhong.Location = new System.Drawing.Point(0, 60);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(1292, 559);
            this.panelPhong.TabIndex = 47;
            // 
            // panelChitietPT
            // 
            this.panelChitietPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChitietPT.Location = new System.Drawing.Point(0, 47);
            this.panelChitietPT.Name = "panelChitietPT";
            this.panelChitietPT.Size = new System.Drawing.Size(1292, 512);
            this.panelChitietPT.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.flowLayoutPanel1.Controls.Add(this.btnHopDong);
            this.flowLayoutPanel1.Controls.Add(this.btnCocPhong);
            this.flowLayoutPanel1.Controls.Add(this.btnThanhVien);
            this.flowLayoutPanel1.Controls.Add(this.btnDichVu);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.btnTaiKhoan);
            this.flowLayoutPanel1.Controls.Add(this.iconButton2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1292, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.LightCyan;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnHopDong.IconColor = System.Drawing.Color.DarkCyan;
            this.btnHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHopDong.IconSize = 35;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(3, 3);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(145, 41);
            this.btnHopDong.TabIndex = 49;
            this.btnHopDong.Tag = "Hợp đồng";
            this.btnHopDong.Text = "   Hợp đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click_1);
            // 
            // btnCocPhong
            // 
            this.btnCocPhong.BackColor = System.Drawing.Color.LightCyan;
            this.btnCocPhong.FlatAppearance.BorderSize = 0;
            this.btnCocPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocPhong.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCocPhong.IconColor = System.Drawing.Color.DarkCyan;
            this.btnCocPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCocPhong.IconSize = 35;
            this.btnCocPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCocPhong.Location = new System.Drawing.Point(154, 3);
            this.btnCocPhong.Name = "btnCocPhong";
            this.btnCocPhong.Size = new System.Drawing.Size(146, 41);
            this.btnCocPhong.TabIndex = 54;
            this.btnCocPhong.Tag = "Cọc Phòng";
            this.btnCocPhong.Text = "   Cọc Phòng";
            this.btnCocPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCocPhong.UseVisualStyleBackColor = false;
            this.btnCocPhong.Click += new System.EventHandler(this.btnCocPhong_Click);
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.LightCyan;
            this.btnThanhVien.FlatAppearance.BorderSize = 0;
            this.btnThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhVien.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnThanhVien.IconColor = System.Drawing.Color.DarkCyan;
            this.btnThanhVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhVien.IconSize = 35;
            this.btnThanhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhVien.Location = new System.Drawing.Point(306, 3);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(142, 41);
            this.btnThanhVien.TabIndex = 51;
            this.btnThanhVien.Tag = "Thành Viên";
            this.btnThanhVien.Text = "Thành Viên";
            this.btnThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.LightCyan;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.IconChar = FontAwesome.Sharp.IconChar.Blog;
            this.btnDichVu.IconColor = System.Drawing.Color.DarkCyan;
            this.btnDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDichVu.IconSize = 35;
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(454, 3);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(134, 41);
            this.btnDichVu.TabIndex = 50;
            this.btnDichVu.Tag = "Dịch Vụ ";
            this.btnDichVu.Text = "Dịch Vụ ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.iconButton1.IconColor = System.Drawing.Color.DarkCyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(594, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(134, 41);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Tag = "Thiết bị";
            this.iconButton1.Text = "Thiết bị";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.LightCyan;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.DarkCyan;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.IconSize = 35;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(734, 3);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(143, 41);
            this.btnTaiKhoan.TabIndex = 53;
            this.btnTaiKhoan.Tag = "Tài khoản";
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightCyan;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PhotoFilm;
            this.iconButton2.IconColor = System.Drawing.Color.DarkCyan;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(883, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(129, 41);
            this.iconButton2.TabIndex = 55;
            this.iconButton2.Tag = "Ảnh";
            this.iconButton2.Text = "Ảnh ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ChiTietPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 619);
            this.Controls.Add(this.panelPhong);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietPT";
            this.Text = "Chitiet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPhong.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnTroVe;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnHopDong;
        private FontAwesome.Sharp.IconButton btnThanhVien;
        private FontAwesome.Sharp.IconButton btnDichVu;
        private System.Windows.Forms.Panel panelChitietPT;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnCocPhong;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}