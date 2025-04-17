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
    public partial class UCQuanLyBenhNhan : UserControl
    {
        public UCQuanLyBenhNhan()
        {
            InitializeComponent();
            DataGrid_QuanLyBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadBenhNhan();
        }

        void LoadBenhNhan()
        {
            DataGrid_QuanLyBenhNhan.AutoGenerateColumns = true;
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
                DataGrid_QuanLyBenhNhan.DataSource = sortedList;
            }
        }
        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBenhNhan frm = new FormAddBenhNhan();
            frm.ShowDialog();
            LoadBenhNhan();

        }

        private void sửaBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditBenhNhan frm = new FormEditBenhNhan();
            frm.ShowDialog();
            LoadBenhNhan();
        }

        private void xóaBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteBenhNhan frm = new FormDeleteBenhNhan();
            frm.ShowDialog();
            LoadBenhNhan();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ textBox tìm kiếm
            string searchKeyword = txtSearch.Text.Trim();

            // Kiểm tra xem người dùng có nhập từ khóa không
            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm.");
                return;
            }

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Truy vấn tất cả bệnh nhân 
                var filteredList = from bn in db.Patients
                                   where bn.fullName.Contains(searchKeyword) ||
                                         bn.PatientId.Contains(searchKeyword) ||      // Mã bệnh nhân
                                         bn.phone.Contains(searchKeyword) ||         // Số điện thoại
                                         bn.address.Contains(searchKeyword) ||       // Địa chỉ
                                         bn.email.Contains(searchKeyword) ||           // Email
                                          (bn.gender ? "Nam" : "Nữ").Contains(searchKeyword)
                                   select new
                                   {
                                       Ma = bn.PatientId,              // Mã bệnh nhân
                                       Ten = bn.fullName,              // Tên bệnh nhân
                                       GioiTinh = bn.gender ? "Nam" : "Nữ", // Giới tính (True là Nam, False là Nữ)
                                       NgaySinh = bn.dateOfBirth,      // Ngày sinh (không cần chuyển đổi)
                                       SoDienThoai = bn.phone,        // Số điện thoại
                                       DiaChi = bn.address,           // Địa chỉ
                                       Email = bn.email,              // Email
                                       GhiChu = bn.note               // Ghi chú
                                   };

                // Chuyển dữ liệu thành danh sách
                var resultList = filteredList.ToList();


                // Kiểm tra nếu có kết quả tìm kiếm
                if (resultList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.");
                }
                else
                {
                    // Hiển thị kết quả tìm kiếm lên DataGridView
                    DataGrid_QuanLyBenhNhan.DataSource = resultList;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBenhNhan();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportBenhNhan report = new ReportBenhNhan();
            report.ShowDialog();
        }
    }
}
