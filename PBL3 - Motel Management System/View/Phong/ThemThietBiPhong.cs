﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemThietBiPhong : Form
    {
        private ThuePhong tp;
        private Loader loader;

        public ThemThietBiPhong(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
            this.loader  = loader;

        }
        public void LoadForm()
        {   
            dgvTBThem.RowCount = 0;
            dgvThietBi.RowCount = 0;
            foreach (ThietBi viewThietBi in QLBLL.Instance.DgvThietBi(null))
            {
                dgvThietBi.Rows.Add(viewThietBi.MaThietBi, 1, viewThietBi.TenThietBi, viewThietBi.GiaThietBi);
            }
            if (tp.hopDong.MaHopDong == null)
            {
                foreach(ChiTietThietBi ct in QLBLL.Instance.GetChiTietThietBiByIdPhong(tp.hopDong.MaPhongTro))
                {
                    ThietBi tb = QLBLL.Instance.GetTBByIdTB(ct.MaThietBi);
                    dgvTBThem.Rows.Add(tb.MaThietBi,1,tb.TenThietBi,tb.GiaThietBi,ct.SoLuong);
                }
            }
            else
            {    
                int i = 0;
                foreach (string idCttb in QLBLL.Instance.GetAllIdCHiTietThietBiByIdPhong(tp.hopDong.MaPhongTro))
                {
                    ChiTietThietBi cttb = QLBLL.Instance.GetChiTietThietBiById(idCttb);
                    ThietBi tb = QLBLL.Instance.GetTBByIdTB(cttb.MaThietBi);
                    dgvTBThem.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi, cttb.SoLuong);
                }
            }
            for (int i = 0; i < dgvTBThem.Rows.Count; i++)
            {
                dgvTBThem.Rows[i].Cells[1].Value = i + 1;

            }
            for (int i = 0; i < dgvThietBi.Rows.Count; i++)
            {
                dgvThietBi.Rows[i].Cells[1].Value = i + 1;
            }
        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();

        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThietBi.CurrentRow;
            ThietBi v = new ThietBi();
            if (row.Cells[0].Value != null)
            {
                bool Status = false;
                v.MaThietBi = row.Cells[0].Value.ToString();
                v.TenThietBi = row.Cells[2].Value.ToString();
                v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                for(int i=0;i<dgvTBThem.Rows.Count;i++)
                {
                    if(dgvTBThem.Rows[i].Cells[0].Value != null)
                    {

                        if(dgvTBThem.Rows[i].Cells[0].Value.ToString() == v.MaThietBi)
                        {
                            int k = Convert.ToInt32(dgvTBThem.Rows[i].Cells[4].Value);
                            dgvTBThem.Rows[i].Cells[4].Value = k+1;
                            Status = true;
                        }    
                        
                    }
                }
                if(!Status)
                {
                        dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi, 1);
                }
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;
                }
                
            }
             
                
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if(dgvTBThem.RowCount > 0)
            {
                DataGridViewRow row = dgvTBThem.CurrentRow;
                ThietBi v = new ThietBi();
                if (row.Cells[0].Value != null)
                {
                    v.MaThietBi = row.Cells[0].Value.ToString();
                    v.TenThietBi = row.Cells[2].Value.ToString();
                    v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                    if(dgvTBThem.CurrentRow.Cells[4].Value != null)
                    {

                    if (Convert.ToInt32(dgvTBThem.CurrentRow.Cells[4].Value.ToString()) == 1)
                        { 
                             dgvTBThem.Rows.RemoveAt(dgvTBThem.CurrentRow.Index);
                    }
                        else
                        {
                            int k = Convert.ToInt32(dgvTBThem.CurrentRow.Cells[4].Value.ToString());
                            dgvTBThem.CurrentRow.Cells[4].Value = k-1;
                        }
                    }
                
                    for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                    {
                        dgvTBThem.Rows[i].Cells[1].Value = i + 1;

                    }
                }

            }
            else
            {
                MessageBox.Show("Danh sách Thiết Bị đã trống ", "Thông báo");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            foreach (DataGridViewRow dr in dgvTBThem.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    list.Add(new ChiTietThietBi()
                    {
                        MaThietBi = dr.Cells[0].Value.ToString(),
                        SoLuong = Convert.ToInt32(dr.Cells[4].Value.ToString()),
                        MaPhongTro = tp.hopDong.MaPhongTro
                    });
                }
            }
            QLBLL.Instance.ThayDoiThietBiPhong(list, tp.hopDong.MaPhongTro);
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
            this.Close();
            this.loader(null);

        }
    }
}