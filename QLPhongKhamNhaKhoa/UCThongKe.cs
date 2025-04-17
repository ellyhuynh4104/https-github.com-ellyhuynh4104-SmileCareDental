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
    public partial class UCThongKe : UserControl
    {
        public UCThongKe()
        {
            InitializeComponent();
        }

        private void thốngKêBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCThongKeBenhNhan userControl_ThongKeBN = new UCThongKeBenhNhan();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl_ThongKeBN);
            userControl_ThongKeBN.Dock = DockStyle.Fill;
            userControl_ThongKeBN.BringToFront();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCThongKeDoanhThu userControl_ThongKeDT = new UCThongKeDoanhThu();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl_ThongKeDT);
            userControl_ThongKeDT.Dock = DockStyle.Fill;
            userControl_ThongKeDT.BringToFront();
        }
    }
}
