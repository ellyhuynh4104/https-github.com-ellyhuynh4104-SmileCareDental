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
    public partial class UCQuanLyNVBS : UserControl
    {
        public UCQuanLyNVBS()
        {
            InitializeComponent();
            dgv_NVBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadStaff();

        }

        public void LoadStaff()
        {
            DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
            var query = from s in db.Staffs
                        select new
                        {
                            MaNhanVien = s.StaffId,
                            MaCCD = s.identityNumber,
                            Hoten = s.fullName,
                            NgaySinh = s.dateOfBirth,
                            GioiTinh = s.gender,
                            DiaChi = s.address,
                            SoDienThoai = s.phone,
                            KinhNghiem = s.experience,
                            Email = s.email,
                            BangCap = s.certificateId,
                            ViTri = s.PositionId,
                            GhiChu = s.note
                        };
            dgv_NVBS.DataSource = query.ToList();

        }
        
        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void thêmNhânViênBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNVBS fnD = new FormAddNVBS();
            fnD.ShowDialog();
            LoadStaff();
        }

        private void sửaNhânViênBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditNVBS fnD = new FormEditNVBS();
            fnD.ShowDialog();
            LoadStaff();
        }

        private void xóaNhânViênBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteNVBS fnD = new FormDeleteNVBS();    
            fnD.ShowDialog();
            LoadStaff();
        }

        private void dgv_NVBS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuyển về chữ thường để so sánh

            DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();

            // Thực hiện truy vấn tìm kiếm
            var query = from s in db.Staffs
                        where s.fullName.ToLower().Contains(keyword) || // Tìm theo Họ tên
                              s.identityNumber.ToLower().Contains(keyword) || // Tìm theo số CMND/CCCD
                              s.phone.ToLower().Contains(keyword) || // Tìm theo số điện thoại
                              s.email.ToLower().Contains(keyword) // Tìm theo Email
                        select new
                        {
                            MaNhanVien = s.StaffId,
                            MaCCD = s.identityNumber,
                            Hoten = s.fullName,
                            NgaySinh = s.dateOfBirth,
                            GioiTinh = s.gender,
                            DiaChi = s.address,
                            SoDienThoai = s.phone,
                            KinhNghiem = s.experience,
                            Email = s.email,
                            BangCap = s.certificateId,
                            ViTri = s.PositionId,
                            GhiChu = s.note
                        };

            // Hiển thị kết quả lên DataGridView
            dgv_NVBS.DataSource = query.ToList();

            // Nếu không tìm thấy kết quả
            if (query.ToList().Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
