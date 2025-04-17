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
    public partial class FormDeleteLichHen : Form
    {

        DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities();
        public event EventHandler click_CloseForm = null;
        private string _appointmentId;
        public FormDeleteLichHen(string appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            txtMaLichHen.Text = _appointmentId;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var lichHen = db.Appointments.FirstOrDefault(x => x.AppointmentId == txtMaLichHen.Text);
                if (lichHen != null)
                {
                    db.Appointments.Remove(lichHen);
                    db.SaveChanges();

                    MessageBox.Show("Lịch hẹn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    click_CloseForm?.Invoke(sender, e);
                }
                else
                {
                    MessageBox.Show("Dịch vụ không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa dịch vụ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
