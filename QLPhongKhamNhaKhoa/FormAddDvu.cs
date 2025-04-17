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
    public partial class FormAddDvu : Form
    {
        public event Action DataUpdated;
        public FormAddDvu()
        {
            InitializeComponent();
        }
      

        private void btnLuuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();
                string tenDichVu = cbTenDichVu.Text.Trim();
                int giaTien;
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
                if (!int.TryParse(txtGiaTien.Text, out giaTien) || giaTien <= 0)
                {
                    MessageBox.Show("Giá tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    if (db.Services.Any(s => s.ServiceId == maDichVu))
                    {
                        MessageBox.Show("Mã dịch vụ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newService = new Service
                    {
                        ServiceId = maDichVu,
                        nameService = tenDichVu,
                        price = giaTien,
                        note = moTa
                    };

                    db.Services.Add(newService);
                    db.SaveChanges();

                    MessageBox.Show("Dịch vụ mới đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtMaDichVu.Clear();
                    txtGiaTien.Clear();
                    txtMoTa.Clear();
                    cbTenDichVu.SelectedIndex = -1;
                }
                DataUpdated?.Invoke();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddDvu_Load(object sender, EventArgs e)
        {

        }
    }
}
