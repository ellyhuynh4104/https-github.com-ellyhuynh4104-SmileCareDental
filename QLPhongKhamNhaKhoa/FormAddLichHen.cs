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
    public partial class FormAddLichHen : Form
    {
        void ToolTipThemLichHen()
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
        public FormAddLichHen()
        {
            InitializeComponent();
            ToolTipThemLichHen();
            LoadComboBoxBenhNhan();
        }
        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
        public event EventHandler click_CloseForm = null;
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
                try
                {

                    Appointment appointment = new Appointment();
                    appointment.AppointmentId = txtMaLichHen.Text;
                    appointment.nameAppointment = txtTenLichHen.Text;
                    appointment.scheduleDate = dateTimePickerNgayHen.Value;
                    appointment.timeBegin = new TimeSpan(timeGioBD.Value.Hour, timeGioBD.Value.Minute, timeGioBD.Value.Second);
                    appointment.timeEnd = new TimeSpan(timeGioBD.Value.Hour, timeGioBD.Value.Minute, timeGioKT.Value.Second);
                    appointment.note = richTextBoxGhiChu.Text;
                    appointment.PatientId = cbBenhNhan.SelectedValue.ToString();
                    db.Appointments.Add(appointment);
                    db.SaveChanges();
                    MessageBox.Show("Lưu lịch hẹn thành công!!", "Thông báo",
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
    }
}
