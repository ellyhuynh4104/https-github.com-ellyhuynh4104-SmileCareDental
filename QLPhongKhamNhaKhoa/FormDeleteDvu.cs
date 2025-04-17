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
    public partial class FormDeleteDvu : Form
    {
        public event Action DataUpdated;
        public FormDeleteDvu()
        {
            InitializeComponent();
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

        private void FormDeleteDvu_Load(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = false;
            cbTenDichVu.Enabled = false;
            txtGiaTien.Enabled = false;
            txtMoTa.Enabled = false;
            LoadDichVu();
        }
        private void DataGrid_QuanLyDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDichVu.Text = DataGrid_QuanLyDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbTenDichVu.Text = DataGrid_QuanLyDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGiaTien.Text = DataGrid_QuanLyDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMoTa.Text = DataGrid_QuanLyDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();

                if (string.IsNullOrEmpty(maDichVu))
                {
                    MessageBox.Show("Hãy chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa dịch vụ với mã '{maDichVu}' không?", "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                    {
                        var service = db.Services.FirstOrDefault(s => s.ServiceId == maDichVu);
                        if (service != null)
                        {
                            db.Services.Remove(service);
                            db.SaveChanges();

                            MessageBox.Show("Dịch vụ đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDichVu();
                            DataUpdated?.Invoke();

                        }
                        else
                        {
                            MessageBox.Show("Dịch vụ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
