using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKhamNhaKhoa
{
    public partial class UCQuanLyDieuTri : UserControl
    {
        public UCQuanLyDieuTri()
        {
            InitializeComponent();
            dgvDSDieuTri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToGridView();
        }

        private void LoadDataToGridView(string searchTerm = "")
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                var query = context.Treatments
                    .Include(t => t.Staff)
                    .Include(t => t.Staff.Position)
                    .Include(t => t.Patient)
                    .Include(t => t.ServiceTreatments.Select(st => st.Service))
                    .Where(t => t.Staff.Position.namePosition == "Bác sĩ")
                    .Select(t => new
                    {
                        MaDieuTri = t.TreatmentId,
                        ChuanDoan = t.diagnose,
                        PhuongPhap = t.method,
                        NgayDieuTri = t.dayOfTreatment,
                        MaBenhNhan = t.PatientId,
                        TenBenhNhan = t.Patient.fullName,
                        MaBacSi = t.Staff.StaffId,
                        TenBacSi = t.Staff.fullName,
                        MaDichVu = t.ServiceTreatments.FirstOrDefault() != null ? t.ServiceTreatments.FirstOrDefault().ServiceId : "Không có",
                        TenDichVu = t.ServiceTreatments.FirstOrDefault() != null ? t.ServiceTreatments.FirstOrDefault().Service.nameService : "Không có"

                    });

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(x => x.MaDieuTri.ToString().Contains(searchTerm) ||
                                              x.ChuanDoan.Contains(searchTerm) ||
                                              x.PhuongPhap.Contains(searchTerm) ||
                                              x.TenBenhNhan.Contains(searchTerm) ||
                                              x.TenBacSi.Contains(searchTerm) ||
                                              x.MaBenhNhan.ToString().Contains(searchTerm) ||
                                              x.MaBacSi.ToString().Contains(searchTerm) ||
                                              x.TenDichVu.Contains(searchTerm) ||
                                              x.NgayDieuTri.ToString().Contains(searchTerm));

                }

                var data = query.ToList();
                dgvDSDieuTri.DataSource = data;
            }
        }
        private void btnLoadDT_Click(object sender, EventArgs e)
        {

            LoadDataToGridView();
        }

        private void btnTìm_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTìm.Text.Trim();
            LoadDataToGridView(searchTerm);
        }
        private void xemĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (donThuocForm == null || donThuocForm.IsDisposed)
            {
                donThuocForm = new FormDonThuocDieuTri();
            }

            if (dgvDSDieuTri.SelectedRows.Count > 0)
            {
                string maDieuTri = dgvDSDieuTri.SelectedRows[0].Cells["MãĐiềuTrị"].Value.ToString();

                donThuocForm.SetMaDieuTri(maDieuTri);
            }

            donThuocForm.Show();
        }

        private void thêmDịchVụĐiềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDSDieuTri.SelectedRows.Count > 0)
            {
                string maDieuTri = dgvDSDieuTri.SelectedRows[0].Cells["MãĐiềuTrị"].Value.ToString();

                using (var fnD = new FormAddDichVuDieuTri())
                {
                    fnD.SetMaDieuTri(maDieuTri);

                    fnD.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để thêm dịch vụ điều trị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXóaDSDT_Click(object sender, EventArgs e)
        {
            if (dgvDSDieuTri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSDieuTri.SelectedRows[0];

                string treatmentId = selectedRow.Cells["MãĐiềuTrị"].Value.ToString();

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa điều trị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DentalClinic_DatabaseEntities())
                    {
                        try
                        {
                            var treatment = context.Treatments.Include(t => t.ServiceTreatments)
                                                              .FirstOrDefault(t => t.TreatmentId == treatmentId);

                            if (treatment != null)
                            {
                                context.ServiceTreatments.RemoveRange(treatment.ServiceTreatments);

                                context.Treatments.Remove(treatment);
                                context.SaveChanges();

                                MessageBox.Show("Điều trị đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadDataToGridView();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy điều trị để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThêmDT_Click(object sender, EventArgs e)
        {

            FormAddDieuTri fnD = new FormAddDieuTri(dgvDSDieuTri, false);
            fnD.ShowDialog();
            LoadDataToGridView();
        }

        private void btnSửaDT_Click(object sender, EventArgs e)
        {
            if (dgvDSDieuTri.SelectedRows.Count > 0)
            {
                FormEditDieuTri fnD = new FormEditDieuTri(dgvDSDieuTri, true, () => LoadDataToGridView());
                fnD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private FormDonThuocDieuTri donThuocForm;

        private void dgvDSDieuTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSDieuTri.Rows[e.RowIndex];
                string maDieuTri = row.Cells["MãĐiềuTrị"].Value.ToString();
                if (!string.IsNullOrEmpty(maDieuTri))
                {
                    // Kiểm tra nếu form chưa được khởi tạo hoặc đã bị dispose
                    if (donThuocForm == null || donThuocForm.IsDisposed)
                    {
                        donThuocForm = new FormDonThuocDieuTri();
                    }

                    donThuocForm.SetMaDieuTri(maDieuTri);
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã điều trị. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        
        }
    }
}
