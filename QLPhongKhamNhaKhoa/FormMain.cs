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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel anh = new Panel();
            anh.BackgroundImage = Properties.Resources.anhnen;
            anh.BackgroundImageLayout = ImageLayout.Stretch;
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(anh);
            anh.Dock = DockStyle.Fill;

        }

        
        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyBenhNhan UC_QlyBN = new UCQuanLyBenhNhan();
            panel_HienThi.Controls.Add(UC_QlyBN);
            UC_QlyBN.Dock = DockStyle.Fill;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyLichHen UC_QlyLichHen = new UCQuanLyLichHen();
            panel_HienThi.Controls.Add(UC_QlyLichHen);
            UC_QlyLichHen.Dock = DockStyle.Fill;
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyThuoc UC_QlyThuoc = new UCQuanLyThuoc();
            panel_HienThi.Controls.Add(UC_QlyThuoc);
            UC_QlyThuoc.Dock = DockStyle.Fill;
        }

        private void quảnLýNhânViênBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyNVBS UC_QlyNVBS = new UCQuanLyNVBS();
            panel_HienThi.Controls.Add(UC_QlyNVBS);
            UC_QlyNVBS.Dock = DockStyle.Fill;

        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyDichVu UC_QlyDichVu = new UCQuanLyDichVu();
            panel_HienThi.Controls.Add(UC_QlyDichVu);
            UC_QlyDichVu.Dock = DockStyle.Fill;
        }

        private void điềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyDieuTri UC_QlyDieuTri = new UCQuanLyDieuTri();
            panel_HienThi.Controls.Add(UC_QlyDieuTri);
            UC_QlyDieuTri.Dock = DockStyle.Fill;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCThongKe UC_ThongKe = new UCThongKe();
            panel_HienThi.Controls.Add(UC_ThongKe);
            UC_ThongKe.Dock = DockStyle.Fill;
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_HienThi.Controls.Clear();
            UCQuanLyThanhToan UC_QlyThanhToan = new UCQuanLyThanhToan();
            panel_HienThi.Controls.Add(UC_QlyThanhToan);
            UC_QlyThanhToan.Dock = DockStyle.Fill;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
