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
    public partial class UCQuanLyLichHen : UserControl
    {
        public UCQuanLyLichHen()
        {
            InitializeComponent();
            dataGridViewLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();

        public void LoadDSDatLichHen()
        {
            var LichHen = from Appointment in db.Appointments
                          join Patient in db.Patients
                          on Appointment.PatientId equals Patient.PatientId
                          select new
                          {
                              MaLichHen = Appointment.AppointmentId,
                              TenLichHen = Appointment.nameAppointment,
                              NgayHen = Appointment.scheduleDate,
                              GioBatDau = Appointment.timeBegin,
                              GioKetThuc = Appointment.timeEnd,
                              GhiChu = Appointment.note,
                              MaBenhNhan = Patient.PatientId,
                              TenBenhNhan = Patient.fullName
                          };
            dataGridViewLichHen.DataSource = LichHen.ToList();
        }
        void LoadComboBoxBenhNhan()
        {
            var BenhNhan = from Patient in db.Patients
                           select Patient;
            cbBenhNhan.DataSource = BenhNhan.ToList();
            cbBenhNhan.ValueMember = "PatientID";
            cbBenhNhan.DisplayMember = "fullName";
        }
        void Settings()
        {
            txtMaLichHen.Enabled = false;
            txtTenLichHen.Enabled = false;
            dateTimePickerNgayHen.Enabled = false;
            timeGioBD.Enabled = false;
            timeGioKT.Enabled = false;
            cbBenhNhan.Enabled = false;
            richTextBoxGhiChu.Enabled = false;
        }

        private void UCQuanLyLichHen_Load(object sender, EventArgs e)
        {
            LoadDSDatLichHen();
            LoadComboBoxBenhNhan();
            Settings();
        }


        private void click_closeForm(object sender, EventArgs e)
        {
            UCQuanLyLichHen_Load(sender, e);
        }

        private void dataGridViewLichHen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int i = dataGridViewLichHen.CurrentRow.Index;
                txtMaLichHen.Text = dataGridViewLichHen.Rows[i].Cells[0].Value.ToString();
                txtTenLichHen.Text = dataGridViewLichHen.Rows[i].Cells[1].Value.ToString();
                dateTimePickerNgayHen.Value = DateTime.Parse(dataGridViewLichHen.Rows[i].Cells[2].Value.ToString());
                timeGioBD.Value = DateTime.Parse(dataGridViewLichHen.Rows[i].Cells[3].Value.ToString());
                timeGioKT.Value = DateTime.Parse(dataGridViewLichHen.Rows[i].Cells[4].Value.ToString());
                richTextBoxGhiChu.Text = dataGridViewLichHen.Rows[i].Cells["note"].Value.ToString();
                cbBenhNhan.SelectedValue = dataGridViewLichHen.Rows[i].Cells[6].Value.ToString();

            }
        }
       

        private void thêmLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAddLichHen frm = new FormAddLichHen();
            frm.click_CloseForm += click_closeForm;
            frm.ShowDialog();
        }

        private void xóaLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtMaLichHen.Text != null)
            {
                FormDeleteLichHen frm = new FormDeleteLichHen(txtMaLichHen.Text);
                frm.click_CloseForm += click_closeForm;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã dịch vụ trước khi xóa", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void sửaLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaLichHen.Text))
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo form sửa
            FormEditLichHen frm = new FormEditLichHen();

            // Truyền dữ liệu qua thuộc tính public
            frm.AppointmentId = txtMaLichHen.Text;
            frm.NameAppointment = txtTenLichHen.Text;
            frm.ScheduleDate = dateTimePickerNgayHen.Value;
            frm.TimeBegin = timeGioBD.Value;
            frm.TimeEnd = timeGioKT.Value;
            frm.PatientId = cbBenhNhan.SelectedValue?.ToString();
            frm.Note = richTextBoxGhiChu.Text;

            // Đăng ký sự kiện close form để refresh lại danh sách
            frm.click_CloseForm += click_closeForm;

            // Hiển thị form sửa
            frm.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDSDatLichHen();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                var LichHen = from Appointment in db.Appointments
                              join Patient in db.Patients
                              on Appointment.PatientId equals Patient.PatientId
                              where Appointment.AppointmentId.Contains(keyword) ||
                                    Appointment.nameAppointment.Contains(keyword) ||
                                    Appointment.note.Contains(keyword) ||
                                    Appointment.PatientId.Contains(keyword) ||
                                    Patient.fullName.Contains(keyword)
                              select new
                              {
                                  AppointmentId = Appointment.AppointmentId,
                                  nameAppointment = Appointment.nameAppointment,
                                  scheduleDate = Appointment.scheduleDate,
                                  timeBegin = Appointment.timeBegin,
                                  timeEnd = Appointment.timeEnd,
                                  note = Appointment.note,
                                  PatientID = Patient.PatientId,
                                  PatientName = Patient.fullName
                              };
                var result = LichHen.ToList();
                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridViewLichHen.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
