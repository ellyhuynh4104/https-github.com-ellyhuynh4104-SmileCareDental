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
    public partial class FormAddThuoc : Form
    {
        public FormAddThuoc()
        {
            InitializeComponent();
        }

         private void FormAddThuoc_Load(object sender, EventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy danh sách loại thuốc từ database
                var loaiThuoc = db.TypeMedicines.ToList();

                // Gán dữ liệu vào ComboBox
                cbLoaiThuoc.DataSource = loaiThuoc;
                cbLoaiThuoc.DisplayMember = "nameTypeOfMedicine"; // Tên cột hiển thị
                cbLoaiThuoc.ValueMember = "TypeMedicineId";      // Giá trị cột
                cbLoaiThuoc.SelectedIndex = -1;                  // Không chọn mặc định
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                string maThuoc = txtMaThuoc.Text.Trim();
                string tenThuoc = txtTenThuoc.Text.Trim();
                int soLuong;
                DateTime hanSuDung = dtpkHanSuDung.Value;
                string donViTinh = txtDonViTinh.Text.Trim();
                decimal donGia;
                string loaiThuocId = cbLoaiThuoc.SelectedValue?.ToString();

                // Kiểm tra các trường nhập liệu
                if (string.IsNullOrEmpty(maThuoc))
                {
                    MessageBox.Show("Mã thuốc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(tenThuoc))
                {
                    MessageBox.Show("Tên thuốc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(loaiThuocId))
                {
                    MessageBox.Show("Bạn phải chọn loại thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Kiểm tra mã thuốc đã tồn tại chưa
                    if (db.Medicines.Any(m => m.MedicineId == maThuoc))
                    {
                        MessageBox.Show("Mã thuốc đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo đối tượng thuốc mới
                    var newMedicine = new Medicine
                    {
                        MedicineId = maThuoc,
                        nameMedicine = tenThuoc,
                        quantity = soLuong,
                        expirationDate = hanSuDung,
                        unit = donViTinh,
                        price = donGia,
                        TypeMedicineId = loaiThuocId
                    };

                    db.Medicines.Add(newMedicine);
                    db.SaveChanges();

                    MessageBox.Show("Thuốc mới đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong form
                    txtMaThuoc.Clear();
                    txtTenThuoc.Clear();
                    txtSoLuong.Clear();
                    txtDonViTinh.Clear();
                    txtDonGia.Clear();
                    cbLoaiThuoc.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       
    }
}
