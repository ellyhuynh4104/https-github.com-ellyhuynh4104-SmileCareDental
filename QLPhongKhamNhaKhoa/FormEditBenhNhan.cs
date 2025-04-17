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
    public partial class FormEditBenhNhan : Form
    {
        public FormEditBenhNhan()
        {
            InitializeComponent();
        }

        void LoadBenhNhan()
        {
            dataGridViewBN.AutoGenerateColumns = true;
            // Khởi tạo đối tượng DbContext để kết nối với cơ sở dữ liệu
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {

                var listBenhNhan = from bn in db.Patients
                                   select new
                                   {
                                       Ma = bn.PatientId,         // Mã bệnh nhân
                                       Ten = bn.fullName,         // Tên bệnh nhân
                                       GioiTinh = bn.gender ? "Nam" : "Nữ",  // Giới tính (True là Nam, False là Nữ)
                                       NgaySinh = bn.dateOfBirth, // Ngày sinh
                                       SoDienThoai = bn.phone,   // Số điện thoại
                                       DiaChi = bn.address,      // Địa chỉ
                                       Email = bn.email,         // Email
                                       GhiChu = bn.note          // Ghi chú
                                   };

                // Chuyển dữ liệu thành danh sách và gán vào DataGridView
                var resultList = listBenhNhan.ToList();

                // Sắp xếp danh sách bệnh nhân theo mã bệnh nhân
                var sortedList = resultList.OrderBy(bn => int.Parse(bn.Ma.Substring(2))) // Chuyển đổi mã bệnh nhân thành số
                                           .ToList();

                // Gán dữ liệu đã sắp xếp vào DataGridView
                dataGridViewBN.DataSource = sortedList;
            }
        }

        private void FormEditBenhNhan_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBN.Text))
            {
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Tìm bệnh nhân trong CSDL dựa trên PatientId
                    var patient = db.Patients.FirstOrDefault(p => p.PatientId == txtMaBN.Text);
                    if (patient != null)
                    {
                        // Cập nhật thông tin bệnh nhân từ các TextBox
                        patient.fullName = txtHoTenBN.Text;
                        patient.gender = rbtnNam.Checked; // true = Nam, false = Nữ
                        patient.dateOfBirth = dateTimePickerNgaySinh.Value;
                        patient.phone = txtSDT.Text;
                        patient.address = txtDiaChi.Text;
                        patient.email = txtEmail.Text;
                        patient.note = txtGhiChu.Text;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SaveChanges();
                        MessageBox.Show("Thông tin bệnh nhân đã được cập nhật.");

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với mã này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để chỉnh sửa.");
            }
        }

        private void dataGridViewBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Kiểm tra xem người dùng có thực sự chọn một hàng không
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = dataGridViewBN.Rows[e.RowIndex];

                // Cập nhật thông tin vào các TextBox
                txtMaBN.Text = row.Cells["Ma"].Value.ToString();
                txtHoTenBN.Text = row.Cells["Ten"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}
