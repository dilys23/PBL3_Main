﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemHoaDon : Form
    {
        private Loader loader;
        private string IdHd;

        public ThemHoaDon(Loader loader,string idHd)
        {
            InitializeComponent();
            SetCBB();
            QLBLL.Instance.customDGV(dgvDichVu);
            this.loader=loader;
            this.IdHd=idHd;
            if(this.IdHd != null )
            {
                lbl.Text = "Sửa hóa đơn";
                cbbDayTro.Enabled = false;
                cbbPhongTro.Enabled = false;
                HoaDon hd = QLBLL.Instance.GetHoaDonById(idHd);
                int index = -1;
                for(int i=0;i<cbbPhongTro.Items.Count;i++)
                {
                    if (((ViewCbb)cbbPhongTro.Items[i]).key == hd.MaPhongTro) index = i;
                }
                cbbPhongTro.SelectedIndex = index;
                DateTime dt = DateTime.ParseExact(hd.ThangChiTra, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dt1 = DateTime.ParseExact(hd.NgayTao, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                dtpThangThanhToan.Value = dt;
                dtpNgayLap.Value = dt1;
            }
        }
       
        private void SetCBB()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLL.Instance.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
        }
        
        private void LoadDgv(string idPhong, string thang)
        {
            if(idPhong != null)
            {
                dgvDichVu.Rows.Clear();
                txtGiamGia.Text = "0";
                HopDong hd = QLBLL.Instance.GetHopDongByIdPhong(idPhong);
                DateTime dt1 = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dt2 = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dtStart = new DateTime(dt1.Year, dt1.Month, 1);
                DateTime dtEnd = new DateTime(dt2.Year, dt2.Month, 1);
                dtpThangThanhToan.MinDate = dtStart;
                dtpThangThanhToan.MaxDate = dtEnd;
                PhongTro pt = QLBLL.Instance.GetPhongTroByIdPhong(idPhong);
                txtTienPhong.Text = pt.GiaTien.ToString();
                int i = 0;
                bool status = false;
                foreach(ChiTietDichVu ctdv in QLBLL.Instance.GetChiTietDichVuByIdPhong(idPhong))
                {
                    if(ctdv.MaDichVu != "001" && ctdv.MaDichVu != "000")
                    {
                        DichVu dv = QLBLL.Instance.GetDichVuByIdDichVu(ctdv.MaDichVu);
                        dgvDichVu.Rows.Add(++i, dv.TenDichVu, dv.GiaDichVu, 0, 0, dv.GiaDichVu, "Chọn");
                    }
                    else if(!status)
                    {
                        status = true;
                        List<ChiTietSuDungDichVu> list = QLBLL.Instance.GetChiTietSuDungDichVuTimKiem(thang, "-1", idPhong, "1");
                        foreach(ChiTietSuDungDichVu dv in list)
                        {
                            ChiTietDichVu ct = QLBLL.Instance.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                            DichVu dv1 = QLBLL.Instance.GetDichVuByIdDichVu(ct.MaDichVu);
                            dgvDichVu.Rows.Add(++i, dv1.TenDichVu, dv1.GiaDichVu, dv.ChiSoCu, dv.ChiSoMoi, (dv.ChiSoMoi-dv.ChiSoCu)*dv1.GiaDichVu, "Chọn");
                        }
                    }
                }
                SetTxtTienDichVu();

            }
            else
            {
                txtTienDichVu.Text = "";
                dgvDichVu.RowCount = 0;
                txtTienPhong.Text = "";
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm được chọn
            int month = dtpThangThanhToan.Value.Month;
            int year = dtpThangThanhToan.Value.Year;

            // Tạo ngày đầu tiên của tháng và năm được chọn
            DateTime date = new DateTime(year, month, 1);

            // Gán ngày đó cho DateTimePicker
            dtpThangThanhToan.Value = date;
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {

            string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
            string thang = dtpThangThanhToan.Value.ToString("MM-yyyy");
            LoadDgv(idPhong, thang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dãy hiện tại chưa có phòng để cho thuê");
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            cbbPhongTro.Text = "";
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(QLBLL.Instance.GetViewCbbPhongByDayForThemHoaDon(id).ToArray());
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
            else
            {
                LoadDgv(null, null);
            }
        }
        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPhongTro.SelectedItem != null)
            {
                string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string thang = dtpThangThanhToan.Value.ToString("MM-yyyy");
                LoadDgv(idPhong, thang);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(dgvDichVu.CurrentRow != null)
            {
                dgvDichVu.CurrentRow.Cells[6].Value = "Chọn";
                SetTxtTienDichVu();

            }
        }
        private void SetTxtTienDichVu()
        {
            double TienDichVu = 0;
            foreach (DataGridViewRow dr in dgvDichVu.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (dr.Cells[6].Value.ToString()=="Chọn")
                    {
                        double tien = Convert.ToDouble(dr.Cells[5].Value.ToString());
                        TienDichVu += tien;
                    }
                }
            }
            txtTienDichVu.Text = TienDichVu.ToString();    
        }
        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if(dgvDichVu.CurrentRow != null)
            {
                dgvDichVu.CurrentRow.Cells[6].Value = "Hủy";
                SetTxtTienDichVu();

            }
        }
        private bool CheckHopLe()
        {
            errorProvider1.SetError(txtGiamGia, "");
            if(!double.TryParse(txtGiamGia.Text, out double tien) )
            {
                errorProvider1.SetError(txtGiamGia, "Vui lòng điền một số!");
                return false;
            }
            return true;
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(CheckHopLe())
            {
                if(cbbPhongTro.SelectedItem != null)
                {

                    double tienPhong = Convert.ToDouble(txtTienPhong.Text);
                    double tienDv = Convert.ToDouble(txtTienDichVu.Text);
                    double giamGia = Convert.ToDouble(txtGiamGia.Text);
                    double tienGiamGia = tienPhong*giamGia/100;
                    double conLai = tienPhong - tienGiamGia;
                    double tongCong = conLai + tienDv;
                    string tt = "Tiền phòng: " + tienPhong + "\nGiảm giá: " + tienGiamGia + "\nCòn lại: " + conLai + "\nTiền dịch vu: " + tienDv + "\nTổng cộng: " + tongCong;
                    DialogResult xacNhan  = MessageBox.Show(tt,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(xacNhan  == System.Windows.Forms.DialogResult.No)
                    {
                    
                    }
                    else
                    {
                        if (this.IdHd == null)
                        {
                        HoaDon hd = new HoaDon
                        { MaHoaDon = QLBLL.Instance.TaoIdHoaDon(),
                            MaPhongTro = ((ViewCbb)cbbPhongTro.SelectedItem).key,
                            NgayTao = dtpNgayLap.Value.ToString("dd-MM-yyyy"),
                            ThangChiTra = dtpThangThanhToan.Value.ToString("MM-yyyy"),
                            TinhTrang = false,
                            TongTien = tongCong,
                            TonTai = true,
                            DaThanhToan = 0
                        };
                        QLBLL.Instance.AddHoaDonBll(hd);
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                        this.Close();
                        this.loader(null);
                        }
                        else
                        {
                            HoaDon hd = QLBLL.Instance.GetHoaDonById(this.IdHd);
                            hd.NgayTao = dtpNgayLap.Value.ToString("dd-MM-yyyy");
                            hd.ThangChiTra = dtpThangThanhToan.Value.ToString("MM-yyyy");
                            hd.TinhTrang = false;
                            hd.TongTien = tongCong;
                            hd.DaThanhToan = 0;
                            QLBLL.Instance.UpdateHoaDonBLL(hd);
                            MessageBox.Show("Thay đổi hóa đơn thành công", "Thông báo");
                            this.Close();
                            this.loader(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dãy hiện tại không phòng hoặc chưa có phòng nào được cho thuê");
                }
            }
        }
    }
}