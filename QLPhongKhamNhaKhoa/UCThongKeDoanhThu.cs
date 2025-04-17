using LiveCharts;
using LiveCharts.Wpf;
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

    public partial class UCThongKeDoanhThu : UserControl
    {
        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();

        public UCThongKeDoanhThu()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void ClearChart()
        {
            // xóa biểu đồ.
            cartesianChart_DoanhThu.Controls.Clear();
            cartesianChart_DoanhThu.Series.Clear();
            cartesianChart_DoanhThu.AxisX.Clear();
        }

        private void UCThongKeDoanhThu_Load(object sender, EventArgs e)
        {

            for (int i = 2016; i <= DateTime.Now.Year; i++)
            {
                cbNam.Items.Add(i.ToString());
            }
        }

       
        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG DOANH THU THÁNG",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };
            int selectedYear = int.Parse(cbNam.SelectedItem.ToString());

            List<string> temp = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                temp.Add("Tháng " + i.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            List<double> l = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                l.Add(0);
            }
            var list = db.Receipts
             .Where(p => p.receiptdate.HasValue && p.receiptdate.Value.Year == selectedYear)
             .Select(p => new
             {
                 p.receiptdate,
                 p.total
             });


            dataGridView1.DataSource = list.ToList();

            foreach (var item in list.ToList())
            {
                l[item.receiptdate.Value.Month - 1] += double.Parse(item.total.ToString());
            }


            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            for (int i = 0; i < 12; i++)
            {
                ts.Add(l[i]);
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {

            lblNam.Visible = false;
            cbNam.Visible = false;

            ClearChart();

            var list = from p in db.Receipts
                       group p by p.receiptdate.Value.Year into g
                       select new
                       {
                           Nam = g.FirstOrDefault().receiptdate.Value.Year,
                           toTal = g.Sum(x => x.total)
                       };
            dataGridView1.DataSource = list.ToList();
            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG NĂM",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };
            //dataGridView1.Visible = false;
            List<string> temp = new List<string>();
            foreach (var item in list.ToList())
            {
                temp.Add(item.Nam.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            // vẽ biểu đồ.
            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            foreach (var item in list.ToList())
            {
                ts.Add(double.Parse(item.toTal.ToString()));
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            //hiển thị năm 
            lblNam.Visible = true;
            cbNam.Visible = true;

            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG DOANH THU THÁNG",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };



            List<string> temp = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                temp.Add("Tháng " + i.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            List<double> l = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                l.Add(0);
            }
            var list = db.Receipts
             .Where(p => p.receiptdate.HasValue && p.receiptdate.Value.Year == 2024)
             .Select(p => new
             {
                 p.receiptdate,
                 p.total
             });


            dataGridView1.DataSource = list.ToList();

            foreach (var item in list.ToList())
            {
                l[item.receiptdate.Value.Month - 1] += double.Parse(item.total.ToString());
            }


            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            for (int i = 0; i < 12; i++)
            {
                ts.Add(l[i]);
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

    }
}
