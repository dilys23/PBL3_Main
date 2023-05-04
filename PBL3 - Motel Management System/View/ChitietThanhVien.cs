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
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietThanhVien : Form
    {
        private string idPhong;
        public ChitietThanhVien(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
            SetFontAndColors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetFontAndColors()
        {
            this.dgvThanhVien.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvThanhVien.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvThanhVien.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvThanhVien.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvThanhVien.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvThanhVien.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        public void LoadForm(string txt)
        {

            dgvThanhVien.Rows.Clear();
       
                dgvThanhVien.Columns[8].ValueType = typeof(Image);
                dgvThanhVien.RowCount = 1;
               

                QLBLL qLBLL = new QLBLL();
                int i = 1;
                //dgvThanhVien.Columns[6].ValueType = typeof(Boolean);
                foreach (string idNguoi in qLBLL.GetIdNguoiByIdPhong(this.idPhong))
                {
                    Nguoi nguoi = new Nguoi();
                    nguoi = qLBLL.GetNguoiByIdNguoi(idNguoi);
                    Image image = null;
                    if (nguoi.HinhAnh != null)
                    {
                        image = ChuyenDoiAnh.Base64ToImage(nguoi.HinhAnh);
                    }
                    dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh) ? "Nam" : "Nữ", image);
                }
            i = 1;
        }
        TrangChu tc= new TrangChu();
        private void dgvThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvThanhVien.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                   
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaNguoi = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
                    tc.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);


                }
                else if (columnName == "btnXoa")
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvThanhVien.Rows[e.RowIndex].Cells["MaNguoi"].Value.ToString();
                        if (id != "000" && id != "001")
                        {
                            QLBLL qLBLL = new QLBLL();
                            string idThanhVien =qLBLL.GetIdThanhVienByIdNguoi(id); 
                            qLBLL.DelThanhVienBLL(idThanhVien);
                            qLBLL.DelNguoiBll(id);
                            MessageBox.Show("Xóa thành viên thành công", "Thông báo");
                            LoadForm(null);
                        }
                        else
                        {
                           // MessageBox.Show("Đây là dịch vụ cố định!! Không thể xóa");
                        }
                    }
                }
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {

            QLBLL qLBLL = new QLBLL();
            if (qLBLL.GetPhongTroByIdPhong(idPhong).TinhTrang == true)
            {

                if (qLBLL.GetIdNguoiByIdPhong(idPhong).Count() < qLBLL.GetPhongTroByIdPhong(idPhong).ToiDa)
                {
                    string IdThanhVien = dgvThanhVien.Rows[0].Cells[0].Value.ToString();
                    string IdPhong = qLBLL.GetIdPhongByIdNguoi(IdThanhVien);
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaPhongTro = idPhong;
                    tc.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);
                }
                else
                {
                    MessageBox.Show("Số lượng người đã tối đa");
                }
            }
            else
            {
                MessageBox.Show("Phòng chưa được cho thuê, không được thêm khách hàng", "Thông báo", MessageBoxButtons.OK); ;
            }
        }

        private void dgvThanhVien_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow.Cells[0].Value != null)
            {

                string id = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
                QLBLL qLBLL = new QLBLL();
                Nguoi nguoi = qLBLL.GetNguoiByIdNguoi(id);
                if (nguoi.HinhAnh != null)
                {
                    Image image = ChuyenDoiAnh.Base64ToImage(nguoi.HinhAnh);
                    Anh anh = new Anh(image);
                    anh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu ảnh");
                }
            }
        }
    }
}
