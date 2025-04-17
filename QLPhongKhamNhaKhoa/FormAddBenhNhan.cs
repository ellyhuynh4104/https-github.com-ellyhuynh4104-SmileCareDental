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
    public partial class FormAddBenhNhan : Form
    {
        public FormAddBenhNhan()
        {
            InitializeComponent();
        }

      
        private void FormAddBenhNhan_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Kiểm tra thông tin bắt buộc
                if (string.IsNullOrWhiteSpace(txtMaBN.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTenBN.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    (!rbtnNam.Checked && !rbtnNu.Checked)) // Kiểm tra giới tính
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc (không để trống các trường)!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức
                }

                // Kiểm tra mã bệnh nhân đã tồn tại
                string patientId = txtMaBN.Text;
                var existingPatient = db.Patients.FirstOrDefault(p => p.PatientId == patientId);

                if (existingPatient != null)
                {
                    // Hiển thị thông báo nếu trùng mã bệnh nhân
                    MessageBox.Show("Mã bệnh nhân đã tồn tại! Vui lòng nhập mã khác.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức
                }

                // Tạo đối tượng bệnh nhân mới
                Patient newPatient = new Patient
                {
                    PatientId = patientId, // Mã bệnh nhân
                    fullName = txtHoTenBN.Text, // Họ tên bệnh nhân
                    gender = rbtnNam.Checked, // Giới tính
                    dateOfBirth = dateTimePickerNgaySinh.Value, // Ngày sinh
                    phone = txtSDT.Text, // Số điện thoại
                    address = txtDiaChi.Text, // Địa chỉ
                    email = txtEmail.Text, // Email
                    note = txtGhiChu.Text // Ghi chú
                };

                // Thêm bệnh nhân mới vào cơ sở dữ liệu
                db.Patients.Add(newPatient);
                db.SaveChanges();

                // Hiển thị thông báo thêm thành công
                MessageBox.Show("Đã thêm bệnh nhân thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
