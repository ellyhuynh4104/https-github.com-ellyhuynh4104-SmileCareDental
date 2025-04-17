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
    public partial class FormDeleteNVBS : Form
    {
        public FormDeleteNVBS()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            LoadStaff();

        }

        private void LoadDataIntoComboBox()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                var positions = db.Positions
                          .Select(p => new { p.PositionId, p.namePosition })
                          .ToList();
                cbViTri.DataSource = positions;
                cbViTri.DisplayMember = "PositionName";
                cbViTri.ValueMember = "PositionId";
            }

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


        private void FormDeleteNVBS_Load(object sender, EventArgs e)
        {

            txtMaNVBS.Enabled = false;
            txtTenNVBS.Enabled = true;
            txtDiaChi.Enabled = true;
            txtBangCap.Enabled = true;
            cbViTri.Enabled = true;
            txtCMT.Enabled = true;
            txtCMT.Enabled = true;
            txtGhiChu.Enabled = true;
            txtKinhNghiem.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            LoadStaff();
            LoadDataIntoComboBox();
        }

        private void dgv_NVBS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtMaNVBS.Text = dgv_NVBS.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtTenNVBS.Text = dgv_NVBS.Rows[e.RowIndex].Cells["Hoten"].Value.ToString();
                dtpkNgaySinh.Value = Convert.ToDateTime(dgv_NVBS.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                txtDiaChi.Text = dgv_NVBS.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = dgv_NVBS.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtCMT.Text = dgv_NVBS.Rows[e.RowIndex].Cells["MaCCD"].Value.ToString();
                txtKinhNghiem.Text = dgv_NVBS.Rows[e.RowIndex].Cells["KinhNghiem"].Value.ToString();
                txtEmail.Text = dgv_NVBS.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtBangCap.Text = dgv_NVBS.Rows[e.RowIndex].Cells["BangCap"].Value.ToString();
                txtGhiChu.Text = dgv_NVBS.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();

                bool gender = Convert.ToBoolean(dgv_NVBS.Rows[e.RowIndex].Cells["GioiTinh"].Value);
                if (gender)
                {
                    radioButton_Nam.Checked = true;
                }
                else
                {
                    radioButton_Nu.Checked = true;
                }

                cbViTri.SelectedValue = dgv_NVBS.Rows[e.RowIndex].Cells["ViTri"].Value;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string staffIdToDelete = txtMaNVBS.Text;

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {

                var staffToDelete = db.Staffs.FirstOrDefault(s => s.StaffId == staffIdToDelete);

                if (staffToDelete != null)
                {
                    db.Staffs.Remove(staffToDelete);
                    db.SaveChanges();


                    LoadStaff();
                    MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
