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
    public partial class FormDeleteBenhNhan : Form
    {
        public FormDeleteBenhNhan()
        {
            InitializeComponent();
        }

        private void FormDeleteBenhNhan_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();
        }
        void LoadBenhNhan()
        {
            dataGridViewBN.AutoGenerateColumns = true;
            // Khởi tạo đối tượng DbContext để kết nối với cơ sở dữ liệu
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Truy vấn dữ liệu bệnh nhân từ cơ sở dữ liệu bằng LINQ method syntax
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu mã bệnh nhân không trống
            if (!string.IsNullOrEmpty(txtMaBN.Text))
            {
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Tìm bệnh nhân dựa trên PatientId
                    var patient = db.Patients.FirstOrDefault(p => p.PatientId == txtMaBN.Text);

                    if (patient != null)
                    {
                        // Hiện hộp thoại xác nhận
                        DialogResult dialogResult = MessageBox.Show(
                            $"Bạn có chắc chắn muốn xóa bệnh nhân: {patient.fullName}?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            // Xóa bệnh nhân
                            db.Patients.Remove(patient);
                            db.SaveChanges();
                            MessageBox.Show("Đã xóa bệnh nhân thành công.");

                            // Tải lại danh sách bệnh nhân
                            LoadBenhNhan();

                            // Xóa thông tin trong các TextBox
                            ClearTextBoxes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với mã này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để xóa.");
            }
        }


        private void ClearTextBoxes()
        {
            txtMaBN.Text = string.Empty;
            txtHoTenBN.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dateTimePickerNgaySinh.Value = DateTime.Now; // Hoặc đặt giá trị mặc định
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }
    }
}
