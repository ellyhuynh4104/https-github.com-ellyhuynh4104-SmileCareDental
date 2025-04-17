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
    public partial class FormDeleteThuoc : Form
    {
        public FormDeleteThuoc()
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
                                DonGia = m.price,
                                DonViTinh = m.unit,
                                LoaiThuoc = m.TypeMedicine.nameTypeOfMedicine,
                                HanSuDung = m.expirationDate
                            };

                DataGrid_DeleteThuoc.DataSource = query.ToList();
            }

        }
        private void FormDeleteThuoc_Load(object sender, EventArgs e)
        {
            txtMaThuoc.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonViTinh.Enabled = false;
            cbLoaiThuoc.Enabled = false;
            dtpkHanSuDung.Enabled = false;

            LoadThuoc();
        }


        private void DataGrid_DeleteThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng có chọn một hàng hợp lệ không
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = DataGrid_DeleteThuoc.Rows[e.RowIndex];

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
        private void btnOK_Click(object sender, EventArgs e)
        {
           
                string maThuoc = txtMaThuoc.Text.Trim();

                if (string.IsNullOrEmpty(maThuoc))
                {
                    MessageBox.Show("Hãy chọn thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa thuốc với mã '{maThuoc}' không?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                    {
                        var medicine = db.Medicines.FirstOrDefault(m => m.MedicineId == maThuoc);
                        if (medicine != null)
                        {
                            db.Medicines.Remove(medicine);
                            db.SaveChanges();

                            MessageBox.Show("Thuốc đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadThuoc();
                        }
                        else
                        {
                            MessageBox.Show("Thuốc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
           
        }

       
    }
}
