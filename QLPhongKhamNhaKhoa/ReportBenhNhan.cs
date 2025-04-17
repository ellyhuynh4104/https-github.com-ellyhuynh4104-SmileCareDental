using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKhamNhaKhoa
{
    public partial class ReportBenhNhan : Form
    {
        public ReportBenhNhan()
        {
            InitializeComponent();
        }

        private void ReportBenhNhan_Load(object sender, EventArgs e)
        {

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy thông tin bệnh nhân từ cơ sở dữ liệu và sắp xếp theo PatientId
                var benhNhanList = db.Patients.Select(bn => new
                {
                    bn.PatientId,
                    bn.fullName,
                    bn.dateOfBirth,
                    GioiTinh = bn.gender ? "Nam" : "Nữ", // Chuyển đổi giới tính
                    bn.phone,
                    bn.address,
                    bn.email,
                    bn.note
                });
                var resultList = benhNhanList.ToList();

                // Sắp xếp danh sách bệnh nhân theo mã bệnh nhân
                var sortedList = resultList.OrderBy(bn => int.Parse(bn.PatientId.Substring(2))).ToList();

                // Tạo DataTable và định nghĩa các cột
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(string));
                dt.Columns.Add("fullName", typeof(string));
                dt.Columns.Add("dateOfBirth", typeof(string));
                dt.Columns.Add("gender", typeof(string));
                dt.Columns.Add("phone", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("note", typeof(string));
                // Thêm dữ liệu vào DataTable
                foreach (var bn in sortedList)
                {
                    dt.Rows.Add(bn.PatientId, bn.fullName, bn.dateOfBirth.ToString("dd/MM/yyyy"), bn.GioiTinh, bn.phone, bn.address, bn.email, bn.note);
                }

                // Liên kết DataTable với ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // Thiết lập Report Path
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPhongKhamNhaKhoa.ReportBN.rdlc";
                this.reportViewer1.RefreshReport();
                // Chuyển chế độ hiển thị sang Print Layout
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

                // Tùy chọn: Zoom vừa chiều rộng trang
                reportViewer1.ZoomMode = ZoomMode.PageWidth;

                // Cấu hình khổ giấy Tabloid ngang (11x17 inches)
                var pageSettings = new System.Drawing.Printing.PageSettings
                {
                    Landscape = true, // Chế độ ngang
                    PaperSize = new System.Drawing.Printing.PaperSize("Tabloid", 1100, 1700), // Tabloid: 11x17 inches (1100x1700 pixels at 96 DPI)
                    Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10) // Lề nhỏ: 0.1 inch
                };
                reportViewer1.SetPageSettings(pageSettings);

                // Refresh lại Report Viewer
                reportViewer1.RefreshReport();
            }
        }


    }
}
