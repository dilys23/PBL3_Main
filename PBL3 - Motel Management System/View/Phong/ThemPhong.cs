﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class ThemPhong : Form
    {
        public _SuKien sukien;
        private Loader loader;
        private string IdPhong;
        private string IdDay;
        public ThemPhong(string IdDay,string IdPhong, Loader loader,_SuKien sukien)
        {
            InitializeComponent();
            this.sukien = sukien;
            this.IdPhong = IdPhong;
            this.IdDay = IdDay;
            this.loader= loader;
            if(IdPhong!=null)
            {
                SetGUI();
            }
        }

        public void SetGUI()
        {
            PhongTro phongTro = QLBLL.Instance.GetPhongTroByIdPhong(IdPhong);
            if (IdPhong != null)
            {
                txtTenPhong.Text = phongTro.TenPhongTro.ToString();
                txtDienTich.Text = phongTro.DienTich.ToString();
                txtGiaTien.Text = phongTro.GiaTien.ToString();
                txtToiDa.Text = phongTro.ToiDa.ToString();
                if (phongTro.HinhAnh != null)
                {
                    pictutePhong.Image = ChuyenDoiAnh.Base64ToImage(phongTro.HinhAnh);
                }

            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtDienTich, "");
            errorProvider1.SetError(txtGiaTien, "");
            errorProvider1.SetError(txtTenPhong, "");
            errorProvider1.SetError(txtToiDa, "");
            if(txtDienTich.Text == "")
            {
                i++;
                errorProvider1.SetError(txtDienTich, "Vui lòng nhập diện tích");
            }
            if (txtGiaTien.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập giá tiền");
            }
            if (txtTenPhong.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenPhong, "Vui lòng nhập tên phòng");
            }
            if (txtToiDa.Text == "")
            {
                i++;
                errorProvider1.SetError(txtToiDa, "Vui lòng nhập số người tối đa");
            }
            if(txtGiaTien.Text != "")
            {
                if(!Int32.TryParse(txtGiaTien.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtGiaTien, "Vui lòng nhập giá tiền bằng số");
                }
            }
            if (txtDienTich.Text != "")
            {
                if (!Int32.TryParse(txtDienTich.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtDienTich, "Vui lòng nhập diện tích bằng số");
                }
            }
            if (txtToiDa.Text != "")
            {
                if (!Int32.TryParse(txtToiDa.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtToiDa, "Vui lòng nhập bằng số");
                }
            }


            if (i==0) return true;
            else return false;




        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(checkHopLe())
            {
                if (IdPhong!=null)
                {
                    PhongTro pt = new PhongTro();
                    PhongTro pt1  = QLBLL.Instance.GetPhongTroByIdPhong(IdPhong);
                    pt.MaPhongTro = IdPhong;
                    pt.TenPhongTro = txtTenPhong.Text;
                    pt.TinhTrang = pt1.TinhTrang;
                    pt.DienTich = Convert.ToDouble(txtDienTich.Text);
                    pt.GiaTien = Convert.ToDouble(txtGiaTien.Text);
                    pt.ToiDa = Convert.ToInt32(txtToiDa.Text);
                    pt.TonTai = true;
                    if (pictutePhong.Image != null)
                    { pt.HinhAnh = ChuyenDoiAnh.ImageToBase64(pictutePhong.Image, pictutePhong.Image.RawFormat); }
                    QLBLL.Instance.UpdatePTBLL(pt);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                    loader(null);
                    this.Close();
                }
                else
                {
                    PhongTro pt = new PhongTro();
                    pt.MaPhongTro = QLBLL.Instance.TaoIdPhongTro();
                    pt.TenPhongTro = txtTenPhong.Text;
                    pt.GiaTien = Convert.ToDouble(txtGiaTien.Text);
                    pt.DienTich = Convert.ToDouble(txtDienTich.Text);
                    pt.TinhTrang = false;
                    pt.ToiDa = Convert.ToInt32(txtToiDa.Text);
                    pt.MaDayTro = this.IdDay;
                    pt.TonTai = true;
                    if (pictutePhong.Image != null)
                    {
                        pt.HinhAnh = ChuyenDoiAnh.ImageToBase64(pictutePhong.Image, pictutePhong.Image.RawFormat);
                    }
                    QLBLL.Instance.AddPhongTroBll(pt);
                    MessageBox.Show("Thêm phòng trọ vào dãy thành công", "Thông báo");
                    Button btn = new Button();
                    btn.Name = QLBLL.Instance.GetIdDayByIdPhong(pt.MaPhongTro);
                    sukien(btn, EventArgs.Empty);
                    this.Close();
                }
               
              
            }

        }
        string imgLocation = "";
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " ipg files(*.jpg)|*.jpg|jpg files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictutePhong.ImageLocation = imgLocation;
            }

        }
    }
}