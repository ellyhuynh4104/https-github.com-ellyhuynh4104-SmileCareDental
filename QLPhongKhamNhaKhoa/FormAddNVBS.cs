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
    public partial class FormAddNVBS : Form
    {
        public FormAddNVBS()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
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


        private void FormAddNVBS_Load(object sender, EventArgs e)
        {
            txtMaNVBS.Enabled = true;
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
            LoadDataIntoComboBox();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                string MaNhanVien = txtMaNVBS.Text.Trim();
                string HoTen = txtTenNVBS.Text.Trim();
                DateTime NgaySinh = dtpkNgaySinh.Value;
                int ViTri = Convert.ToInt32(cbViTri.SelectedValue);
                string DiaChi = txtDiaChi.Text.Trim();
                string SDT = txtSoDienThoai.Text.Trim();
                string SoCCCD = txtCMT.Text.Trim();
                string KinhNghiem = txtKinhNghiem.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string BangCap = txtBangCap.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();

                if (string.IsNullOrEmpty(MaNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(HoTen))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbViTri.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn vị trí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(DiaChi))
                {
                    MessageBox.Show("Địa chỉ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(SDT))
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(SoCCCD))
                {
                    MessageBox.Show("Số CCCD không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(KinhNghiem))
                {
                    MessageBox.Show("Kinh nghiệm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Email không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(BangCap))
                {
                    MessageBox.Show("Bằng cấp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                bool GioiTinh;
                if (radioButton_Nam.Checked)
                {
                    GioiTinh = true;
                }
                else if (radioButton_Nu.Checked)
                {
                    GioiTinh = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new DentalClinic_DatabaseEntities())
                {
                    if (db.Staffs.Any(s => s.StaffId == MaNhanVien))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newStaff = new Staff
                    {
                        StaffId = MaNhanVien,
                        identityNumber = SoCCCD,
                        fullName = HoTen,
                        dateOfBirth = NgaySinh,
                        gender = GioiTinh,
                        address = DiaChi,
                        phone = SDT,
                        experience = KinhNghiem,
                        email = Email,
                        note = GhiChu,
                        certificateId = BangCap,
                        PositionId = ViTri
                    };

                    db.Staffs.Add(newStaff);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }




            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
