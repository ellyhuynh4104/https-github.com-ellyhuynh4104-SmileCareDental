using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class UCThongKeBenhNhan : UserControl
    {
        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
        public UCThongKeBenhNhan()
        {
            InitializeComponent();
            dgv_TKBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void ClearChart()
        {
            // xóa biểu đồ.
            cartesianChart_BenhNhan.Controls.Clear();
            cartesianChart_BenhNhan.Series.Clear();
            cartesianChart_BenhNhan.AxisX.Clear();
        }

        public DateTime? dayOfTreatment { get; set; }
        private void btnNam_Click(object sender, EventArgs e)
        {

            ClearChart();


            var treatmentData = db.Treatments
                                  .Where(p => p.dayOfTreatment != null)
                                  .GroupBy(p => p.dayOfTreatment.Year)
                                  .Select(g => new
                                  {
                                      Year = g.Key,
                                      TotalPatients = g.Count()
                                  })
                                  .ToList();

            dgv_TKBN.DataSource = treatmentData;


            if (!treatmentData.Any())
            {
                MessageBox.Show("No data available for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Axis xAxis = new Axis
            {
                Title = "Year",
                FontSize = 15,
                Labels = treatmentData.Select(d => d.Year.ToString()).ToList(),
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };
            cartesianChart_BenhNhan.AxisX.Add(xAxis);


            LineSeries lineSeries = new LineSeries
            {
                Title = "TONG SO BENH NHAN",
                Values = new ChartValues<double>(treatmentData.Select(d => (double)d.TotalPatients)),
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null
            };


            cartesianChart_BenhNhan.Series.Add(lineSeries);

        }

        private void UCThongKeBenhNhan_Load(object sender, EventArgs e)
        {

            for (int i = 2016; i <= DateTime.Now.Year; i++)
            {
                cbNam.Items.Add(i.ToString());
            }
        }

        private void btnThang_Click(object sender, EventArgs e)
        {

            if (cbNam.SelectedItem == null)
            {
                MessageBox.Show("Please select a year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int selectedYear = int.Parse(cbNam.SelectedItem.ToString());


            ClearChart();


            var treatmentData = db.Treatments
                      .Where(p => p.dayOfTreatment.Year == selectedYear)
                      .GroupBy(p => p.dayOfTreatment.Month)
                      .Select(g => new
                      {
                          Month = g.Key,
                          TotalPatients = g.Count()
                      })
                      .OrderBy(g => g.Month)
                      .ToList();


            dgv_TKBN.DataSource = treatmentData.Select(data => new
            {
                Month = new DateTime(selectedYear, data.Month, 1).ToString("MMMM"),
                TotalPatients = data.TotalPatients
            }).ToList();


            if (!treatmentData.Any())
            {
                MessageBox.Show($"No data available for the year {selectedYear}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Axis xAxis = new Axis
            {
                Title = "Month",
                FontSize = 15,
                Labels = treatmentData.Select(d => new DateTime(selectedYear, d.Month, 1).ToString("MMMM")).ToList(), // Set month names as labels
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };
            cartesianChart_BenhNhan.AxisX.Add(xAxis);


            LineSeries lineSeries = new LineSeries
            {
                Title = $"Total Patients in {selectedYear}",
                Values = new ChartValues<double>(treatmentData.Select(d => (double)d.TotalPatients)),
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(12, 93, 123)),
                LineSmoothness = 0,
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10
            };


            cartesianChart_BenhNhan.Series.Add(lineSeries);
        }
    }
}
