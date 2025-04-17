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
    public partial class FormEditDieuTri : Form
    {
        private DataGridViewRow selectedRow;
        private DataGridView dgvDSDieuTri;
        private bool isEdit;
        private Action reloadData;

        public FormEditDieuTri(DataGridView dgvDSDieuTri, bool isEdit, Action reloadData)
        {
            InitializeComponent();
            this.dgvDSDieuTri = dgvDSDieuTri;
            this.isEdit = isEdit;
            this.reloadData = reloadData;

            if (isEdit && dgvDSDieuTri.SelectedRows.Count > 0)
            {
                selectedRow = dgvDSDieuTri.SelectedRows[0];
            }
            else
            {
                selectedRow = null;
            }
        }

        private void FormEditDieuTri_Load(object sender, EventArgs e)
        {

            using (var context = new DentalClinic_DatabaseEntities())
            {
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

                if (selectedRow != null)
                {
                    txtMaDieuTri.Text = selectedRow.Cells["MãĐiềuTrị"].Value?.ToString();
                    cmbMaBenhNhan.SelectedValue = selectedRow.Cells["MãBệnhNhân"].Value?.ToString();
                    txtChuanDoan.Text = selectedRow.Cells["ChuẩnĐoán"].Value?.ToString();
                    txtPPDieuTri.Text = selectedRow.Cells["PhươngPháp"].Value?.ToString();
                    cmbMaBSDT.SelectedValue = selectedRow.Cells["MãBácSĩ"].Value?.ToString();
                    txtMãDịchVụ.Text = selectedRow.Cells["MãDịchVụ"].Value?.ToString();
                    cmbTênDịchVụ.SelectedValue = selectedRow.Cells["MãDịchVụ"].Value?.ToString();
                    dtpkNgayDieuTri.Value = Convert.ToDateTime(selectedRow.Cells["NgàyĐiềuTrị"].Value);

                    string selectedPatientId = cmbMaBenhNhan.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedPatientId))
                    {
                        var patient = context.Patients.FirstOrDefault(p => p.PatientId == selectedPatientId);
                        txtTenBenhNhan.Text = patient?.fullName ?? "";
                    }

                    string selectedStaffId = cmbMaBSDT.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedStaffId))
                    {
                        var doctor = context.Staffs.FirstOrDefault(s => s.StaffId == selectedStaffId);
                        txtTenBSDT.Text = doctor?.fullName ?? "";
                    }
                }
            }
        }

        private void btnSuaDT_Click(object sender, EventArgs e)
        {
            using (var context = new DentalClinic_DatabaseEntities())
            {
                if (selectedRow != null)
                {
                    var treatmentId = selectedRow.Cells["MãĐiềuTrị"].Value.ToString();
                    var treatment = context.Treatments.FirstOrDefault(t => t.TreatmentId == treatmentId);

                    if (treatment != null)
                    {
                        treatment.PatientId = cmbMaBenhNhan.SelectedValue.ToString();
                        treatment.diagnose = txtChuanDoan.Text;
                        treatment.method = txtPPDieuTri.Text;
                        treatment.StaffId = cmbMaBSDT.SelectedValue.ToString();
                        treatment.dayOfTreatment = dtpkNgayDieuTri.Value;

                        var serviceTreatment = context.ServiceTreatments
                            .FirstOrDefault(st => st.TreatmentId == treatmentId);

                        if (serviceTreatment != null)
                        {
                            serviceTreatment.ServiceId = txtMãDịchVụ.Text;
                        }
                        else
                        {
                            context.ServiceTreatments.Add(new ServiceTreatment
                            {
                                TreatmentId = treatmentId,
                                ServiceId = txtMãDịchVụ.Text
                            });
                        }

                        context.SaveChanges();

                        MessageBox.Show("Cập nhật điều trị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        reloadData?.Invoke();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy điều trị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
