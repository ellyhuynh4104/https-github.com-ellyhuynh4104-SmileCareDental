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
    public partial class FormAddDichVuDieuTri : Form
    {
        public FormAddDichVuDieuTri()
        {
            InitializeComponent();
            LoadDichVu();
            dgv_DichVuDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void SetMaDieuTri(string maDieuTri)
        {
            txtMaDieuTri.Text = maDieuTri;


        }

        private void LoadDichVu()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                var query = db.Services.Select(s => new { s.ServiceId, s.nameService }).ToList();
                comboBox_DichVu.DataSource = query;
                comboBox_DichVu.DisplayMember = "nameService";
                comboBox_DichVu.ValueMember = "ServiceId";
            }
        }

        private void LoadDichVuDT()
        {
            string maDieuTri = txtMaDieuTri.Text;

            using (var db = new DentalClinic_DatabaseEntities())
            {
                var query = db.ServiceTreatments
                    .Where(st => st.TreatmentId == maDieuTri)
                    .Select(st => new
                    {
                        MãĐiềuTrị = st.TreatmentId,
                        MãBệnhNhân = st.Treatment.Patient.PatientId,
                        TênBệnhNhân = st.Treatment.Patient.fullName,
                        MãDịchVụ = st.ServiceId,
                        TênDịchVụ = st.Service.nameService
                    })
                    .ToList();

                dgv_DichVuDT.DataSource = query;
            }
        }

        private void FormAddDichVuDieuTri_Load(object sender, EventArgs e)
        {
           
            LoadDichVu();
            LoadDichVuDT();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                ServiceTreatment serviceTreatment = new ServiceTreatment
                {
                    TreatmentId = txtMaDieuTri.Text,
                    ServiceId = comboBox_DichVu.SelectedValue.ToString()
                };

                db.ServiceTreatments.Add(serviceTreatment);
                db.SaveChanges();

                LoadDichVuDT();

                listBox1.Items.Add(comboBox_DichVu.Text);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maDieuTri = txtMaDieuTri.Text;

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                if (dgv_DichVuDT.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgv_DichVuDT.SelectedRows[0];

                    string selectedServiceId = selectedRow.Cells["MãDịchVụ"].Value.ToString();

                    var serviceTreatment = db.ServiceTreatments
                        .FirstOrDefault(st => st.TreatmentId == maDieuTri && st.ServiceId == selectedServiceId);

                    if (serviceTreatment != null)
                    {
                        db.ServiceTreatments.Remove(serviceTreatment);
                        db.SaveChanges();

                        LoadDichVuDT();

                        listBox1.Items.Remove(comboBox_DichVu.Text);

                        MessageBox.Show($"Đã xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ để xóa trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng trong DataGridView để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
