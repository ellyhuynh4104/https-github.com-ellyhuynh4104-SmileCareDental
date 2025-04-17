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
    public partial class FormEditLichHen : Form
    {

        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
        public event EventHandler click_CloseForm = null;
        public string AppointmentId { get; set; }
        public string NameAppointment { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public string PatientId { get; set; }
        public string Note { get; set; }
        public FormEditLichHen()
        {
            InitializeComponent();
            ToolTipSuaLichHen();
            LoadComboBoxBenhNhan();
        }

        void ToolTipSuaLichHen()
        {
            ToolTip lichHen = new ToolTip();
            lichHen.SetToolTip(timeGioBD, "Nhập giờ, phút, giây bắt đầu lịch hẹn");
            lichHen.SetToolTip(timeGioKT, "Nhập giờ, phút, giây kết thúc lịch hẹn");
            lichHen.SetToolTip(dateTimePickerNgayHen, "Có thể nhập lịch hẹn bằng cách mở cửa sổ lịch ở bên phải ô");
        }
        void LoadComboBoxBenhNhan()
        {
            var BenhNhan = from Patient in db.Patients
                           select Patient;
            cbBenhNhan.DataSource = BenhNhan.ToList();
            cbBenhNhan.ValueMember = "PatientID";
            cbBenhNhan.DisplayMember = "fullName";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isOK = true;
            if (txtMaLichHen.Text.Length == 0)
            {
                isOK = false;
                MessageBox.Show("Vui lòng nhập mã số lịch hẹn", "Lỗi dữ liệu!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLichHen.Focus();

            }
            if (txtTenLichHen.Text == null)
            {
                isOK = false;
                MessageBox.Show("Vui lòng nhập nội dung lịch hẹn", "Lỗi dữ liệu!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLichHen.Focus();
            }
            if (dateTimePickerNgayHen == null || timeGioBD == null || timeGioKT == null)
            {
                MessageBox.Show("Vui lòng không bỏ trống ngày giờ hẹn", "Lỗi dữ liệu!!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (isOK)
            {

                Appointment appointment = db.Appointments.Find(txtMaLichHen.Text);
                if (appointment != null)
                {

                    appointment.AppointmentId = txtMaLichHen.Text;
                    appointment.nameAppointment = txtTenLichHen.Text;
                    appointment.scheduleDate = dateTimePickerNgayHen.Value;
                    appointment.timeBegin = new TimeSpan(timeGioBD.Value.Hour, timeGioBD.Value.Minute, timeGioBD.Value.Second);
                    appointment.timeEnd = new TimeSpan(timeGioBD.Value.Hour, timeGioBD.Value.Minute, timeGioKT.Value.Second);
                    appointment.note = richTextBoxGhiChu.Text;
                    appointment.PatientId = cbBenhNhan.SelectedValue.ToString();


                }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa lịch hẹn thành công!!", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    click_CloseForm?.Invoke(sender, e);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng lịch hẹn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally { this.Close(); }
            }
        }

        private void FormEditLichHen_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaLichHen.Text = AppointmentId;
                txtTenLichHen.Text = NameAppointment;
                dateTimePickerNgayHen.Value = ScheduleDate;
                timeGioBD.Value = TimeBegin;
                timeGioKT.Value = TimeEnd;
                cbBenhNhan.SelectedValue = PatientId;
                richTextBoxGhiChu.Text = Note;

                // Nếu không tìm thấy bệnh nhân, hiển thị tên bệnh nhân
                if (cbBenhNhan.SelectedIndex == -1)
                {
                    cbBenhNhan.Text = "Tên không xác định"; // Hoặc tên bệnh nhân phù hợp
                }


            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
