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
    public partial class FormEditDvu : Form
    {
        public event Action DataUpdated;

        public FormEditDvu()
        {
            InitializeComponent();
            cbMaDichVu.SelectedIndexChanged += cbMaDichVu_SelectedIndexChanged;

        }



        private void FormEditDvu_Load(object sender, EventArgs e)
        {
            try
            {
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    var services = db.Services.Select(s => new { s.ServiceId, s.nameService }).ToList();
                    cbMaDichVu.DataSource = services;
                    cbMaDichVu.DisplayMember = "ServiceId";
                    cbMaDichVu.ValueMember = "ServiceId";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = cbMaDichVu.Text.Trim();
                string tenDichVu = cbTenDichVu.Text.Trim();
                decimal giaTien;
                string moTa = txtMoTa.Text.Trim();
                if (string.IsNullOrEmpty(maDichVu))
                {
                    MessageBox.Show("Mã dịch vụ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(tenDichVu))
                {
                    MessageBox.Show("Tên dịch vụ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string giaTienText = txtGiaTien.Text.Trim();
                if (string.IsNullOrEmpty(giaTienText) || !decimal.TryParse(giaTienText, out giaTien) || giaTien <= 0)
                {
                    MessageBox.Show("Giá tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    var service = db.Services.FirstOrDefault(s => s.ServiceId == maDichVu);

                    if (service != null)
                    {
                        service.nameService = tenDichVu;
                        service.price = giaTien;
                        service.note = moTa;

                        db.SaveChanges();

                        MessageBox.Show("Thông tin dịch vụ đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataUpdated?.Invoke();

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbMaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedServiceId = cbMaDichVu.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(selectedServiceId))
                {
                    using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                    {
                        var service = db.Services.FirstOrDefault(s => s.ServiceId == selectedServiceId);
                        if (service != null)
                        {
                            cbTenDichVu.Text = service.nameService;
                            txtGiaTien.Text = service.price.ToString();
                            txtMoTa.Text = service.note;
                        }
                        else
                        {
                            cbTenDichVu.Text = "";
                            txtGiaTien.Text = "";
                            txtMoTa.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thay đổi dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
