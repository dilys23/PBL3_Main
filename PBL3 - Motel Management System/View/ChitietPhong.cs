﻿using System;
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
    public partial class ChitietPhong : Form
    {
        public ChitietPhong()
        {
            InitializeComponent();
        }
        TrangChu tc = new TrangChu();
        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemKhach(), panelChiTiet);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemKhach(), panelChiTiet);
        }

        private void panPhong1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
