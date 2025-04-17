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
    public partial class UCQuanLyThuoc : UserControl
    {
        public UCQuanLyThuoc()
        {
            InitializeComponent();

        }

        private void LoadMedicines()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                var query = from m in db.Medicines
                            select new
                            {
                                MaThuoc = m.MedicineId,
                                TenThuoc = m.nameMedicine,
                                SoLuong = m.quantity,
                                HanSuDung = m.expirationDate,
                                DonViTinh = m.unit,
                                GiaTien = m.price,
                                LoaiThuoc = m.TypeMedicine.nameTypeOfMedicine
                            };

                DataGrid_QuanLyThuoc.DataSource = query.ToList();
            }
        }
        private void UCQuanLyThuoc_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }
        private void thêmThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddThuoc frm = new FormAddThuoc();
            frm.ShowDialog();
            LoadMedicines();

        }

        private void sửaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditThuoc frm = new FormEditThuoc();
            frm.ShowDialog();
            LoadMedicines();

        }

        private void xóaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteThuoc frm = new FormDeleteThuoc();
            frm.ShowDialog();
            LoadMedicines();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox
            string searchKeyword = txtSearch.Text.Trim();

            // Kiểm tra xem người dùng có nhập từ khóa hay không
            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Truy vấn danh sách thuốc khớp với từ khóa tìm kiếm
                    var filteredList = from m in db.Medicines
                                       where m.MedicineId.Contains(searchKeyword) ||   // Mã thuốc
                                             m.nameMedicine.Contains(searchKeyword) || // Tên thuốc
                                             m.unit.Contains(searchKeyword) ||         // Đơn vị tính
                                             m.TypeMedicine.nameTypeOfMedicine.Contains(searchKeyword) || // Loại thuốc
                                             m.price.ToString().Contains(searchKeyword) // Giá tiền
                                       select new
                                       {
                                           MaThuoc = m.MedicineId,
                                           TenThuoc = m.nameMedicine,
                                           SoLuong = m.quantity,
                                           HanSuDung = m.expirationDate,
                                           DonViTinh = m.unit,
                                           GiaTien = m.price,
                                           LoaiThuoc = m.TypeMedicine.nameTypeOfMedicine
                                       };

                    // Chuyển kết quả truy vấn thành danh sách
                    var resultList = filteredList.ToList();

                    // Kiểm tra kết quả tìm kiếm
                    if (resultList.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Hiển thị kết quả lên DataGridView
                        DataGrid_QuanLyThuoc.DataSource = resultList;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportThuoc report = new ReportThuoc();
            report.ShowDialog();
        }
    }
}
