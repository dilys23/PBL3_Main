﻿using PBL3___Motel_Management_System.BLL;
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
    public partial class SuaHopDong : Form
    {
        public SuaHopDong()
        {
            InitializeComponent();
        }
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            qLBLL.openChildForm1(new ThemKhach(null, null), panelThemHD);
        }
    }
}
