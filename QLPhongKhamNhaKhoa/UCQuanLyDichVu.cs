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
    public partial class UCQuanLyDichVu : UserControl
    {
        public UCQuanLyDichVu()
        {
            InitializeComponent();
            DataGrid_QuanLyDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void LoadDichVu()
        {
            DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
            var query = from s in db.Services
                        select new
                        {
                            MaDichVu = s.ServiceId,
                            TenDichVu = s.nameService,
                            GiaTien = s.price,
                            MoTa = s.note
                        };

            DataGrid_QuanLyDichVu.DataSource = query.ToList();
        }

        private void UCQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        private void thêmDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddDvu frm = new FormAddDvu();
            frm.DataUpdated += () =>
            {
                LoadDichVu();
            };

            frm.ShowDialog();
        }

        private void xóaDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormDeleteDvu frm = new FormDeleteDvu();
            frm.DataUpdated += () =>
            {
                LoadDichVu();
            };
            frm.ShowDialog();
        }

        private void sửaDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditDvu frm = new FormEditDvu();
            frm.DataUpdated += () =>
            {
                LoadDichVu();
            };
            frm.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDichVu();
        }
    }
}
