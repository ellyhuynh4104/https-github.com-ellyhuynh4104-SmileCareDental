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
    public partial class FormDonThuocDieuTri : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormDonThuocDieuTri()
        {
            InitializeComponent();
        }
        public void SetMaDieuTri(string maDieuTri)
        {
            txtMaDieuTri.Text = maDieuTri;
        }
        private void FormDonThuocDieuTri_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            LoadMedicinesToComboBox();
        }

        private void LoadDataToGridView()
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                var query1 = from t in context.Treatments
                             join p in context.Prescriptions on t.PatientId equals p.PatientId
                             join pt in context.Patients on t.PatientId equals pt.PatientId
                             select new
                             {
                                 MãĐiềuTrị = t.TreatmentId,
                                 MãBệnhNhân = p.PatientId,
                                 TênBệnhNhân = pt.fullName,
                                 MãĐơnThuốc = p.PrescriptionId,
                                 TênĐơnThuốc = p.namePrescription
                             };

                var query2 = from pm in context.PrescriptionMedicines
                             join m in context.Medicines on pm.MedicineId equals m.MedicineId
                             select new
                             {
                                 MãĐơnThuốc = pm.PrescriptionId,
                                 MãThuốc = pm.MedicineId,
                                 TênThuốc = m.nameMedicine,
                                 SốLượng = pm.quantity
                             };

                var data1 = query1.ToList();
                var data2 = query2.ToList();

                dgv_DS_DonThuoc.DataSource = data1;
                dgvChiTietDonThuoc.DataSource = data2;
            }
        }

        private void LoadMedicinesToComboBox()
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                var medicinesId = context.Medicines.Select(m => m.MedicineId).ToList();
                cmbMaThuocDieuTri.DataSource = medicinesId;

                var medicinesNames = context.Medicines.Select(m => m.nameMedicine).ToList();
                cmbTenThuoc.DataSource = medicinesNames;

            }
        }

        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {

            if (cmbMaThuocDieuTri.SelectedItem == null || cmbTenThuoc.SelectedItem == null || string.IsNullOrEmpty(txtSoLuongThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maThuoc = cmbMaThuocDieuTri.SelectedItem.ToString();
            string tenThuoc = cmbTenThuoc.SelectedItem.ToString();
            int soLuong = Convert.ToInt32(txtSoLuongThuoc.Text);
            string maDonThuoc = txtMCTDT.Text;
            using (var context = new DentalClinic_DatabaseEntities())
            {
                var medicine = context.Medicines.FirstOrDefault(m => m.nameMedicine == tenThuoc);
                if (medicine == null)
                {
                    MessageBox.Show("Không tìm thấy thuốc với tên đã chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string medicineId = maThuoc;

                var newPrescription = new PrescriptionMedicine
                {
                    MedicineId = medicineId,
                    quantity = soLuong,
                    PrescriptionId = maDonThuoc
                };

                context.PrescriptionMedicines.Add(newPrescription);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Thêm đơn thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataToGridView();

                    cmbMaThuocDieuTri.SelectedItem = null;
                    cmbTenThuoc.SelectedItem = null;
                    txtSoLuongThuoc.Clear();
                    txtMCTDT.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu vào cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {

            if (dgvChiTietDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvChiTietDonThuoc.SelectedRows[0];

                string maDonThuoc = selectedRow.Cells["MãĐơnThuốc"].Value?.ToString();
                string maThuoc = selectedRow.Cells["MãThuốc"].Value?.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SốLượng"].Value?.ToString());
                if (string.IsNullOrEmpty(maDonThuoc) || string.IsNullOrEmpty(maThuoc))
                {
                    MessageBox.Show("Không thể xóa vì dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn thuốc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var context = new DentalClinic_DatabaseEntities())
                    {
                        try
                        {
                            var prescriptionMedicine = context.PrescriptionMedicines
                                .FirstOrDefault(pm => pm.PrescriptionId == maDonThuoc && pm.MedicineId == maThuoc && pm.quantity == soLuong);

                            if (prescriptionMedicine != null)
                            {
                                context.PrescriptionMedicines.Remove(prescriptionMedicine);
                                context.SaveChanges();

                                LoadDataToGridView();

                                MessageBox.Show("Đơn thuốc đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy đơn thuốc để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa đơn thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvChiTietDonThuoc.SelectedRows[0];

                string maDonThuoc = selectedRow.Cells["MãĐơnThuốc"].Value.ToString();
                string maThuoc = selectedRow.Cells["MãThuốc"].Value?.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SốLượng"].Value?.ToString());

                if (cmbMaThuocDieuTri.SelectedItem == null || cmbTenThuoc.SelectedItem == null || string.IsNullOrEmpty(txtSoLuongThuoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maThuocMoi = cmbMaThuocDieuTri.SelectedItem.ToString();
                string tenThuocMoi = cmbTenThuoc.SelectedItem.ToString();
                int soLuongMoi = Convert.ToInt32(txtSoLuongThuoc.Text);

                using (var context = new DentalClinic_DatabaseEntities())
                {
                    try
                    {
                        var prescriptionMedicine = context.PrescriptionMedicines.FirstOrDefault(pm => pm.PrescriptionId == maDonThuoc && pm.MedicineId == maThuoc && pm.quantity == soLuong);

                        if (prescriptionMedicine != null)
                        {
                            prescriptionMedicine.MedicineId = maThuocMoi;
                            prescriptionMedicine.quantity = soLuongMoi;

                            context.SaveChanges();

                            selectedRow.Cells["MãThuốc"].Value = maThuocMoi;
                            selectedRow.Cells["TênThuốc"].Value = tenThuocMoi;
                            selectedRow.Cells["SốLượng"].Value = soLuongMoi;

                            LoadDataToGridView();

                            MessageBox.Show("Đơn thuốc đã được sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đơn thuốc để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi sửa đơn thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTimKiemDThuoc_Click(object sender, EventArgs e)
        {

            string maDieuTri = txtMaDieuTri.Text.Trim();

            using (var context = new DentalClinic_DatabaseEntities())
            {
                var query = from t in context.Treatments
                            join p in context.Prescriptions on t.PatientId equals p.PatientId
                            where (string.IsNullOrEmpty(maDieuTri) || t.TreatmentId.Contains(maDieuTri))
                            select new
                            {
                                MãĐiềuTrị = t.TreatmentId,
                                MãBệnhNhân = p.PatientId,
                                TênBệnhNhân = p.Patient.fullName,
                                MãĐơnThuốc = p.PrescriptionId,
                                TênĐơnThuốc = p.namePrescription
                            };

                var data = query.ToList();

                dgv_DS_DonThuoc.DataSource = data;

                if (data.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn thuốc với tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dgv_DS_DonThuoc.Rows.Count > 0)
                    {
                        dgv_DS_DonThuoc.Rows[0].Selected = true;

                        string maDonThuoc = dgv_DS_DonThuoc.SelectedRows[0].Cells["MãĐơnThuốc"].Value.ToString();

                        txtMaDonThuoc.Text = maDonThuoc;
                    }
                }
            }
        }

        private void btnChiTietDT_Click(object sender, EventArgs e)
        {
            string maDonThuoc = txtMaDonThuoc.Text.Trim();

            using (var context = new DentalClinic_DatabaseEntities())
            {
                var query = from pm in context.PrescriptionMedicines
                            join m in context.Medicines on pm.MedicineId equals m.MedicineId
                            where pm.PrescriptionId == maDonThuoc
                            select new
                            {
                                MãĐơnThuốc = pm.PrescriptionId,
                                MãThuốc = pm.MedicineId,
                                TênThuốc = m.nameMedicine,
                                SốLượng = pm.quantity
                            };

                var data = query.ToList();

                if (data.Count > 0)
                {
                    dgvChiTietDonThuoc.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn thuốc với Mã Đơn Thuốc đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvChiTietDonThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietDonThuoc.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvChiTietDonThuoc.CurrentRow;

                txtMCTDT.Text = selectedRow.Cells["MãĐơnThuốc"].Value?.ToString();
                cmbMaThuocDieuTri.SelectedItem = selectedRow.Cells["MãThuốc"].Value?.ToString();
                cmbTenThuoc.SelectedItem = selectedRow.Cells["TênThuốc"].Value?.ToString();
                txtSoLuongThuoc.Text = selectedRow.Cells["SốLượng"].Value?.ToString();
            }
        }



    }
}
