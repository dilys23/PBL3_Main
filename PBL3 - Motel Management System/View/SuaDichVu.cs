﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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
    public partial class SuaDichVu : Form
    {
        private string IdDv;
        private Loader Loader;
        public SuaDichVu(string idDv,Loader loader)
        {
            InitializeComponent();
            this.IdDv=idDv;
            this.Loader = loader;
            QLBLL qLBLL = new QLBLL();
            DichVu dv = qLBLL.GetDVByIdDV(idDv);
            txtGiaDichVu.Text = dv.GiaDichVu.ToString();
            txtTenDichVu.Text = dv.TenDichVu;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtTenDichVu, "");
            errorProvider1.SetError(txtGiaDichVu, "");
            if(txtTenDichVu.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenDichVu, "Vui lòng điền tên dịch vụ");
            }
            if (txtGiaDichVu.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGiaDichVu, "Vui lòng điền giá dịch vụ");
            }
            if(txtGiaDichVu.Text != "")
            {
                if(!double.TryParse(txtGiaDichVu.Text,out double d))
                {
                    i++;
                    errorProvider1.SetError(txtGiaDichVu, "Giá dịch vụ phải bằng số");

                }
            }

            if (i==0) return true;
            return false;


        }
        private void SuaDichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                DichVu dv = new DichVu();
                dv.MaDichVu = IdDv;
                dv.TenDichVu = txtTenDichVu.Text;
                dv.GiaDichVu = Convert.ToDouble(txtGiaDichVu.Text);
                qLBLL.SuaDVBll(dv);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                Loader(null);
                this.Close();

            }
        }
    }
}
