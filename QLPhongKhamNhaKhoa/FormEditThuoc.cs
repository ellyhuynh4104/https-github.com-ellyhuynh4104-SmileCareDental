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
    public partial class FormEditThuoc : Form
    {

        private string _selectedMedicineId;

        public FormEditThuoc()
        {
            InitializeComponent();
        }



        public void LoadThuoc()
        {
           
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    var query = from m in db.Medicines
                                select new
                                {
                                    MaThuoc = m.MedicineId,
                                    TenThuoc = m.nameMedicine,
                                    SoLuong = m.quantity,
                                    DonViTinh = m.unit,
                                    LoaiThuoc = m.TypeMedicine.nameTypeOfMedicine,
                                    HanSuDung = m.expirationDate,
                                    DonGia = m.price
                                };

                    DataGrid_EditThuoc.DataSource = query.ToList();
                }
           
        }

        private void FormEditThuoc_Load(object sender, EventArgs e)
        {
           
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Load danh sách loại thuốc lên ComboBox
                    var loaiThuoc = db.TypeMedicines.ToList();
                    cbLoaiThuoc.DataSource = loaiThuoc;
                    cbLoaiThuoc.DisplayMember = "nameTypeOfMedicine";
                    cbLoaiThuoc.ValueMember = "TypeMedicineId";
                }

                txtMaThuoc.Enabled = false; // Không cho phép chỉnh sửa mã thuốc
                LoadThuoc();
            
            
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
           
                string maThuoc = txtMaThuoc.Text.Trim();

                if (string.IsNullOrEmpty(maThuoc))
                {
                    MessageBox.Show("Hãy chọn thuốc cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Tìm thuốc cần chỉnh sửa
                    var medicine = db.Medicines.FirstOrDefault(m => m.MedicineId == maThuoc);
                    if (medicine != null)
                    {
                        // Cập nhật thông tin thuốc
                        medicine.nameMedicine = txtTenThuoc.Text.Trim();
                        medicine.quantity = string.IsNullOrEmpty(txtSoLuong.Text) ? 0 : Convert.ToInt32(txtSoLuong.Text);
                        medicine.unit = txtDonViTinh.Text.Trim();
                        medicine.TypeMedicineId = (string)cbLoaiThuoc.SelectedValue;
                        medicine.expirationDate = dtpkHanSuDung.Value;
                        medicine.price = string.IsNullOrEmpty(txtDonGia.Text) ? (decimal?)null : Convert.ToDecimal(txtDonGia.Text);

                        // Lưu thay đổi vào CSDL
                        db.SaveChanges();

                        MessageBox.Show("Đã lưu thông tin thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadThuoc(); // Làm mới danh sách thuốc
                    }
                    else
                    {
                        MessageBox.Show("Thuốc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
           

        }

        private void DataGrid_EditThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Kiểm tra xem người dùng có chọn một hàng hợp lệ không
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = DataGrid_EditThuoc.Rows[e.RowIndex];

                // Cập nhật thông tin vào các TextBox và các điều khiển liên quan
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString();
                txtTenThuoc.Text = row.Cells["TenThuoc"].Value?.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
                cbLoaiThuoc.Text = row.Cells["LoaiThuoc"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                dtpkHanSuDung.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
            }
            
            
        }
    }

      


    
}
