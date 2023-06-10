﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3___Motel_Management_System.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            LoadForm();
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            string nam = date.Year.ToString();
            ThongKe(nam);
        }
        private void LoadForm()
        {
            dgvTinhTrang.RowCount = 0;
            dgvSoLuong.RowCount = 0;
            QLBLLChung.Instance.customDGV(dgvTinhTrang);
            QLBLLChung.Instance.customDGV(dgvSoLuong);
            int i = 0;
            foreach (string idp in QLBLLPhongTro.Instance.DgvPhongTro(null))
            {
                PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(idp);
                string TinhTrang;
                HopDong hd = QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro);
                if (hd == null) TinhTrang = "Còn trống";
                else if (hd.TinhTrang == true) TinhTrang = "Đã cho thuê";
                else TinhTrang = "Đã cọc";
                dgvTinhTrang.Rows.Add(pt.MaPhongTro, ++i, QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro, pt.TenPhongTro, TinhTrang);
            }
            List<string> phongTroList = QLBLLPhongTro.Instance.DgvPhongTro(null);
            Dictionary<string, int> tinhTrangCounts = new Dictionary<string, int>();
            foreach (string idp in phongTroList)
            {
                PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(idp);
                string tinhTrang;
                HopDong hd = QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro);
                if (hd == null) tinhTrang = "Còn trống";
                else if (hd.TinhTrang == true) tinhTrang = "Đã cho thuê";
                else tinhTrang = "Đang cọc";

                // Kiểm tra nếu tình trạng đã có trong Dictionary, tăng số lượng phòng lên 1
                if (tinhTrangCounts.ContainsKey(tinhTrang))
                {
                    tinhTrangCounts[tinhTrang]++;
                }
                else
                {
                    // Nếu tình trạng chưa có trong Dictionary, thêm mới và đặt số lượng phòng là 1
                    tinhTrangCounts.Add(tinhTrang, 1);
                }

            }
            foreach (var kvp in tinhTrangCounts)
            {
                dgvSoLuong.Rows.Add(kvp.Key, kvp.Value);
            }
            DrawPieChart();

        }
        public void LoadForm1(string thang)
        {
            int i = 0;
            foreach (string hd in QLBLLHoadon.Instance.GetHoaDonByThangChiTra(thang))
            {
                HoaDon hoadon = QLBLLHoadon.Instance.GetHoaDonById(hd);
                if (hoadon.TinhTrang == true)
                {
                    PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByMaHoaDon(hoadon.MaHoaDon);
                    DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro);

                }

            }
        }
        private void DrawPieChart()
        {
            List<string> tinhTrangList = new List<string>();
            List<int> soLuongList = new List<int>();

            foreach (DataGridViewRow row in dgvSoLuong.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string tinhTrang = row.Cells[0].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells[1].Value.ToString());
                    tinhTrangList.Add(tinhTrang);
                    soLuongList.Add(soLuong);
                }
            }
            // Xóa các series hiện có trong biểu đồ
            TinhTrang.Series.Clear();

            // Tạo series mới và thêm data points
            var series = new Series("Tình trạng");
            series.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < tinhTrangList.Count; i++)
            {
                series.Points.Add(soLuongList[i]);
                series.Points[i].LegendText = string.Format("{0} ({1})", tinhTrangList[i], soLuongList[i]);
            }
            foreach (DataPoint dataPoint in series.Points)
            {
                dataPoint.Label = string.Format("{0} ({1})", dataPoint.AxisLabel, dataPoint.YValues[0]);
            }
            // Thêm series vào biểu đồ
            TinhTrang.Series.Add(series);
        }

        private void panelDesktop_SizeChanged(object sender, EventArgs e)
        {
            int panelWidth = panelDesktop.Width;
            int panelHeight = panelDesktop.Height;

            int dgvWidth = (panelWidth - 40) / 2;
            int dgvHeight = (panelHeight - 30) / 2;

            int chartWidth = dgvWidth;
            int chartHeight = dgvHeight;
            int chartX = 10;
            int chartY = 10;

            int dgvTinhTrangWidth = dgvWidth - 4;
            int dgvTinhTrangHeight = dgvHeight - 3;
            int dgvTinhTrangX = dgvWidth + 15;
            int dgvTinhTrangY = 5;

            int dgvSoLuongWidth = dgvWidth;
            int dgvSoLuongHeight = dgvHeight - 25;
            int dgvSoLuongX = dgvWidth + 15;
            int dgvSoLuongY = dgvHeight + 5;

            int chartWidth1 = (int)(panelWidth * 0.48);
            int chartHeight1 = (int)(panelHeight * 0.48);
            int chartX1 = 1;
            int chartY1 = panelHeight - chartHeight1;

            ChartCot.Size = new Size(chartWidth1, chartHeight1);
            ChartCot.Location = new Point(chartX1, chartY1);


            TinhTrang.Size = new Size(Math.Max(0, chartWidth), Math.Max(0, chartHeight));
            TinhTrang.Location = new Point(chartX, chartY);

            dgvTinhTrang.Size = new Size(dgvTinhTrangWidth, dgvTinhTrangHeight);
            dgvTinhTrang.Location = new Point(dgvTinhTrangX, dgvTinhTrangY);

            dgvSoLuong.Size = new Size(dgvSoLuongWidth, dgvSoLuongHeight);
            dgvSoLuong.Location = new Point(dgvSoLuongX, dgvSoLuongY);
        }
        public void ThongKe(string nam)
        {
            var thongke = QLBLLChung.Instance.ThongKeTongTienTheoThang(nam);
            ChartCot.Series[0].XValueMember = "Key";
            ChartCot.Series[0].YValueMembers = "Value";
            ChartCot.DataSource = thongke;
            ChartCot.Series[0].Name = "Tháng";
            ChartCot.ChartAreas[0].AxisX.Title = "Tháng";
            ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            ChartCot.DataBind();
        }


    }
}
