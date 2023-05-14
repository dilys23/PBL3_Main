﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
     public delegate void Loader1(String s);
     public delegate void _SuKien(object sender, EventArgs e);

    public partial class DemoPhong : Form
    {
#pragma warning disable CS0414 // The field 'DemoPhong.defaultBtn' is assigned but its value is never used
        private Button defaultBtn = null;
#pragma warning restore CS0414 // The field 'DemoPhong.defaultBtn' is assigned but its value is never used
        private Button ClickBtn = null;
        public DemoPhong()
        {
            InitializeComponent();
            LoadForm(null);
            SetCbb();
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbTinhTrang.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLL.Instance.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(QLBLL.Instance.GetCbbTinhTrangPhong().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        public void LoadForm(string txt)
        {      
            panelBtnDay.Controls.Clear();
            panelPhong.AutoScroll = false;
            panelPhong.HorizontalScroll.Visible = false;
            panelPhong.HorizontalScroll.Maximum = 0;
            panelPhong.AutoScroll = true;
            Button defaultBtn = null;
            foreach(DayTro dt in QLBLL.Instance.GetAllDayTroBll())
            {
                ToolTip tp = new ToolTip();
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.DarkOrange;
                this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
                this.btnThemPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
                this.btnThemPhong.IconSize = 25;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Size = new System.Drawing.Size(80, 50);
                btn.TabIndex = 21;
                btn.Text = dt.TenDayTro;
                btn.Name = dt.MaDayTro;
                tp.SetToolTip(btn, btn.Text);
                btn.Click += new EventHandler(SuKien);
                panelBtnDay.Controls.Add(btn);
                if(defaultBtn == null)
                {
                    defaultBtn = btn;
                    ClickBtn = btn;
                }
                
            }
            if(defaultBtn != null)
            {
                 SuKien(defaultBtn, EventArgs.Empty);
            }

        }
        public System.Drawing.Image Image { get; set; }

        private void SuKien(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ClickBtn = btn;
            panelPhong.Controls.Clear();
            DayTro dt = QLBLL.Instance.GetDayByIdDay(btn.Name);
            string DiaChi = "    " + dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            lblDiaChi.Text = DiaChi;
            foreach(PhongTro pt in QLBLL.Instance.GetPhongTroByIdDay(btn.Name))
            {
                Demo p = new Demo(SuKien,pt.MaPhongTro,panelChinh); 
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (QLBLL.Instance.TinhTrangPhongById(pt.MaPhongTro)) //54, 179, 205
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(205))))));
                }
                if(QLBLL.Instance.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234))))));
                }
                foreach (Nguoi nguoi in QLBLL.Instance.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    Label lbl = new Label();
                    lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
                    lbl.AutoSize = true;
                    lbl.Name = nguoi.MaNguoi;
                    lbl.Text = "   " + nguoi.Ten;
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Image image1 = Image.FromFile("D:\\PBL3\\PBL3_Main\\PBL3 - Motel Management System\\Icons\\icons8-customer-20.png" + "    ");
                    lbl.Image = image1;
                    lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lbl.TabIndex = 0;
                    lbl.Size = new System.Drawing.Size(50, 80);
                    lbl.Visible = true;
                    p.SetPanelKhach(lbl);
                }
                p.SetBtnName(pt.MaPhongTro);
                 panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();
        }
        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
            if(ClickBtn != null)
            {
                QLBLL.Instance.openChildForm1(new ThemPhong(ClickBtn.Name,null,LoadForm, SuKien), panelChinh);
            }         
        }
        private void btnThemday_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ThemDay(null,LoadForm,SuKien), panelChinh);
        }

        private void btnSuaDay_Click(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            {
                QLBLL.Instance.openChildForm1(new ThemDay(ClickBtn.Name, LoadForm, SuKien), panelChinh);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string idDay = ((ViewCbb)(cbbDayTro.SelectedItem)).key;
            string idTinhTrang = ((ViewCbb)(cbbTinhTrang.SelectedItem)).key;
            panelPhong.Controls.Clear();
            if(idDay != "-1")
            {
                lblDiaChi.Text = QLBLL.Instance.GetDiaChiByIdDay(idDay);
            }
            else
            {
                lblDiaChi.Text = "";
            }
            foreach (PhongTro pt in QLBLL.Instance.PhongTroTimKiem(idDay,idTinhTrang,txtTimKiem.Text))
            {
                Demo p = new Demo(SuKien, pt.MaPhongTro, panelChinh);
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (QLBLL.Instance.TinhTrangPhongById(pt.MaPhongTro)) //54, 179, 205
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(205))))));
                }
                if (QLBLL.Instance.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234))))));
                }
                foreach (Nguoi nguoi in QLBLL.Instance.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    Label lbl = new Label();
                    lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
                    lbl.AutoSize = true;
                    lbl.Name = nguoi.MaNguoi;
                    lbl.Text = "   " + nguoi.Ten;
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Image image1 = Image.FromFile("D:\\PBLproject\\PBL3_Main\\PBL3 - Motel Management System\\Icons\\icons8-customer-20.png" + "    ");
                    lbl.Image = image1;
                    lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lbl.TabIndex = 0;
                    lbl.Size = new System.Drawing.Size(50, 80);
                    lbl.Visible = true;
                    p.SetPanelKhach(lbl);
                }
                p.SetBtnName(pt.MaPhongTro);
                panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();

        }
        private void btnXoaDay_Click_1(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            { 
                if(QLBLL.Instance.CheckDay(ClickBtn.Name)==false)
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        QLBLL.Instance.DelDayTroBll(ClickBtn.Name);
                        LoadForm(null);
                    }              
                }
                else
                {
                    MessageBox.Show("Dãy có phòng đang thuê không được xóa ");
                } 
            }
        }
    }
}