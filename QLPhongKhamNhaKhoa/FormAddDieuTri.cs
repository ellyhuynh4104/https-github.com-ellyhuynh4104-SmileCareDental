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
    public partial class FormAddDieuTri : Form
    {
        private DataGridView dgvDSDieuTri; // Reference to the DataGridView in DieuTri form

        // TableAdapter của bảng Treatment
        public FormAddDieuTri(DataGridView dgvDSDieuTri, bool isEdit = false, int rowIndex = -1)
        {
            InitializeComponent();
            this.dgvDSDieuTri = dgvDSDieuTri;
        }

        private void LoadDataToGridView()
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                var treatments = (from t in context.Treatments
                                  join p in context.Patients on t.PatientId equals p.PatientId
                                  join s in context.Staffs on t.StaffId equals s.StaffId
                                  select new
                                  {
                                      t.TreatmentId,
                                      t.PatientId,
                                      PatientName = p.fullName,
                                      t.diagnose,
                                      t.method,
                                      t.StaffId,
                                      StaffName = s.fullName,
                                      t.dayOfTreatment
                                  }).ToList();

                dgvDSDieuTri.DataSource = treatments;
            }
        }

      

        private void FormAddDieuTri_Load(object sender, EventArgs e)
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                // Load danh sách bệnh nhân
                var patientList = context.Patients
                    .Select(p => new { p.PatientId, p.fullName })
                    .ToList();

                cmbMaBenhNhan.DataSource = patientList;
                cmbMaBenhNhan.DisplayMember = "PatientId";
                cmbMaBenhNhan.ValueMember = "PatientId";

                cmbMaBenhNhan.SelectedIndexChanged += (s, ev) =>
                {
                    var selectedPatient = patientList.FirstOrDefault(x => x.PatientId == cmbMaBenhNhan.SelectedValue?.ToString());
                    txtTenBenhNhan.Text = selectedPatient?.fullName ?? "";
                };

                // Load danh sách bác sĩ
                var staffList = context.Staffs
                    .Where(s => s.PositionId == 2)
                    .Select(s => new { s.StaffId, s.fullName })
                    .ToList();

                cmbMaBSDT.DataSource = staffList;
                cmbMaBSDT.DisplayMember = "StaffId";
                cmbMaBSDT.ValueMember = "StaffId";

                cmbMaBSDT.SelectedIndexChanged += (s, ev) =>
                {
                    var selectedStaff = staffList.FirstOrDefault(x => x.StaffId == cmbMaBSDT.SelectedValue?.ToString());
                    txtTenBSDT.Text = selectedStaff?.fullName ?? "";
                };

                // Load danh sách dịch vụ
                var serviceList = context.Services
                    .Select(s => new { s.ServiceId, s.nameService })
                    .ToList();

                cmbTênDịchVụ.DataSource = serviceList;
                cmbTênDịchVụ.DisplayMember = "nameService";
                cmbTênDịchVụ.ValueMember = "ServiceId";

                cmbTênDịchVụ.SelectedIndexChanged += (s, ev) =>
                {
                    var selectedService = serviceList.FirstOrDefault(x => x.nameService == cmbTênDịchVụ.Text);
                    txtMãDịchVụ.Text = selectedService?.ServiceId ?? "";
                };
            }
        }

        private void btnAddDT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDieuTri.Text) || cmbMaBenhNhan.SelectedValue == null ||
                string.IsNullOrEmpty(txtChuanDoan.Text) || string.IsNullOrEmpty(txtPPDieuTri.Text) ||
                cmbMaBSDT.SelectedValue == null || string.IsNullOrEmpty(txtMãDịchVụ.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpkNgayDieuTri.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày điều trị không được nhỏ hơn ngày hôm nay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DentalClinic_DatabaseEntities())
            {
                try
                {
                    // Thêm dữ liệu vào bảng Treatment
                    var treatment = new Treatment
                    {
                        TreatmentId = txtMaDieuTri.Text,
                        PatientId = cmbMaBenhNhan.SelectedValue.ToString(),
                        diagnose = txtChuanDoan.Text,
                        method = txtPPDieuTri.Text,
                        StaffId = cmbMaBSDT.SelectedValue.ToString(),
                        dayOfTreatment = dtpkNgayDieuTri.Value
                    };
                    context.Treatments.Add(treatment);

                    // Thêm dữ liệu vào bảng ServiceTreatment
                    var serviceTreatment = new ServiceTreatment
                    {
                        ServiceId = txtMãDịchVụ.Text,
                        TreatmentId = treatment.TreatmentId
                    };
                    context.ServiceTreatments.Add(serviceTreatment);

                    context.SaveChanges();

                    MessageBox.Show("Đã thêm điều trị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                 
                    // Hoặc cập nhật trực tiếp dgvDSDieuTri nếu cần
                    LoadDataToGridView();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
