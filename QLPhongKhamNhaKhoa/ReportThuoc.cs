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
    public partial class ReportThuoc : Form
    {
        public ReportThuoc()
        {
            InitializeComponent();
        }

        private void ReportThuoc_Load(object sender, EventArgs e)
        {

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy dữ liệu từ bảng Medicines
                var medicines = db.Medicines.Select(m => new
                {
                    m.nameMedicine,
                    m.price,
                    m.unit,
                    m.quantity
                }).ToList();

                // Đổ dữ liệu vào DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("nameMedicine", typeof(string));
                dt.Columns.Add("price", typeof(decimal));
                dt.Columns.Add("unit", typeof(string));
                dt.Columns.Add("quantity", typeof(int));

                foreach (var med in medicines)
                {
                    dt.Rows.Add(med.nameMedicine, med.price, med.unit, med.quantity);
                }

                // Liên kết dữ liệu với ReportViewer
                ReportDataSource rds = new ReportDataSource("MedicineDataset", dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // Load report vào ReportViewer
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPhongKhamNhaKhoa.ReportThuoc.rdlc";
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);


                reportViewer1.ZoomMode = ZoomMode.PageWidth;


                var pageSettings = new System.Drawing.Printing.PageSettings
                {
                    Landscape = false,
                    PaperSize = new System.Drawing.Printing.PaperSize("A3", 1123, 1587), // A3: 11.69x16.54 inches (1123x1587 pixels at 96 DPI)
                    Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10) // Lề nhỏ: 0.1 inch

                };
                reportViewer1.SetPageSettings(pageSettings);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
