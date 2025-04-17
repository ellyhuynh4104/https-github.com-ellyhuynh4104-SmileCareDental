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
    public partial class UCQuanLyThanhToan : UserControl
    {
        public UCQuanLyThanhToan()
        {
            InitializeComponent();
            LoadReceipts();
            LoadStaff();
            LoadMedicines();
            LoadServices();
            dataGridViewThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Kiểm tra xem đã chọn bệnh nhân hay chưa
                if (cbMaBN.SelectedValue != null)
                {
                    string patientId = cbMaBN.SelectedValue.ToString();

                    // Lấy thông tin bệnh nhân từ PatientId
                    var patient = db.Patients.FirstOrDefault(p => p.PatientId == patientId);

                    if (patient != null)
                    {
                        // Cập nhật thông tin vào các textbox
                        txtHoTenBN.Text = patient.fullName;
                        txtDiaChi.Text = patient.address;
                        txtSDT.Text = patient.phone;
                        txtEmail.Text = patient.email;
                        dateTimePickerNgaySinh.Value = patient.dateOfBirth;

                        if (patient.gender) rbtnNam.Checked = true;
                        else rbtnNu.Checked = true;
                    }
                }
            }
        }
        private void gbInfBenhNhan_Enter(object sender, EventArgs e)
        {
            LoadData();
            LoadStatus();
        }
        private void LoadData()
        {
            LoadPatients();
        }
        private void LoadPatients()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Gán đúng DisplayMember và ValueMember
                cbMaBN.DataSource = db.Patients.Select(p => new { p.PatientId, p.fullName }).ToList();
                cbMaBN.DisplayMember = "PatientId";  // Hiển thị tên bệnh nhân
                cbMaBN.ValueMember = "PatientId";   // Lưu trữ PatientId
            }
        }


        // Phương thức Load danh sách dịch vụ vào CheckedListBox
        private void LoadServices()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy danh sách dịch vụ từ database
                var services = db.Services.Select(s => new { s.ServiceId, s.nameService }).ToList();

                // Kiểm tra nếu không có dịch vụ nào
                if (services == null || services.Count == 0)
                {
                    MessageBox.Show("Không có dịch vụ nào!");
                    return;
                }

                // Xóa các mục hiện có trong CheckedListBox
                checklistboxDV.Items.Clear();

                // Thêm các dịch vụ vào CheckedListBox
                foreach (var service in services)
                {
                    checklistboxDV.Items.Add(service.nameService, false); // false là trạng thái mặc định của checkbox
                }
            }
        }
        private decimal total = 0; // Khai báo và khởi tạo biến total


        //Load cbThanhToan

        private void LoadStatus()
        {
            // Tạo danh sách các trạng thái thanh toán
            List<string> statusList = new List<string> { "Đã thanh toán", "Chưa thanh toán" };

            // Gán danh sách vào ComboBox
            cbStatus.DataSource = statusList;
        }
        //Xử lý btnThanhToan


        private void LoadReceipts()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                var receipts = db.Receipts.Select(r => new
                {
                    r.ReceiptId,
                    PatientName = r.Patient.fullName,
                    r.receiptdate,
                    r.total,
                    r.note,
                    r.statusReceipt
                }).ToList();

                // Đảm bảo DataSource được cập nhật lại sau khi thanh toán
                dataGridViewThanhToan.DataSource = receipts;

                // Nếu vẫn không hiển thị, thử làm mới DataGridView
                dataGridViewThanhToan.Refresh();
            }
        }
        private void LoadStaff()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy danh sách nhân viên từ cơ sở dữ liệu
                var staffList = db.Staffs.Select(s => new { s.StaffId, s.fullName }).ToList();

                // Gán danh sách nhân viên vào ComboBox
                cbStaff.DataSource = staffList;
                cbStaff.DisplayMember = "fullName";  // Hiển thị tên nhân viên
                cbStaff.ValueMember = "StaffId";     // Lưu trữ StaffId
            }
        }
        private void LoadMedicines()
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                var medicines = db.Medicines.Select(m => new { m.MedicineId, m.nameMedicine, m.price }).ToList();

                if (medicines == null || medicines.Count == 0)
                {
                    MessageBox.Show("Không có thuốc nào!");
                    return;
                }

                checkedListBoxThuoc.Items.Clear();

                foreach (var medicine in medicines)
                {
                    checkedListBoxThuoc.Items.Add($"{medicine.nameMedicine} ({medicine.price:N0})", false); // Hiển thị tên thuốc và giá
                }
            }
        }


        private void UpdateTotal()
        {
            decimal serviceTotal = 0;
            decimal.TryParse(txtTienDV.Text, out serviceTotal); // Lấy giá trị từ txtTienDV

            decimal medicineTotalValue = 0;
            decimal.TryParse(txtTienThuoc.Text, out medicineTotalValue); // Lấy giá trị từ txtTienThuoc

            // Tổng cộng cả hai
            decimal finalTotal = serviceTotal + medicineTotalValue;

            // Hiển thị tổng tiền vào txtTotal
            txtTotal.Text = finalTotal.ToString("N0");
        }
        private void ResetForm()
        {
            // Reset các TextBox
            txtHoTenBN.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtTienDV.Text = "0";
            txtTienThuoc.Text = "0";
            txtTotal.Text = "0";

            // Reset các ComboBox
            cbMaBN.SelectedIndex = -1;
            cbStaff.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;

            // Reset các RadioButton
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;

            // Reset các CheckedListBox (Dịch vụ)
            for (int i = 0; i < checklistboxDV.Items.Count; i++)
            {
                checklistboxDV.SetItemChecked(i, false); // Bỏ chọn tất cả các dịch vụ
            }

            // Reset các CheckedListBox (Thuốc)
            for (int i = 0; i < checkedListBoxThuoc.Items.Count; i++)
            {
                checkedListBoxThuoc.SetItemChecked(i, false); // Bỏ chọn tất cả các thuốc
            }

            // Reset DateTimePicker
            dateTimePickerThanhToan.Value = DateTime.Now; // Đặt lại ngày mặc định
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                string patientId = cbMaBN.SelectedValue?.ToString();

                // Lấy StaffId từ comboBox chọn nhân viên
                string staffId = cbStaff.SelectedValue?.ToString();
                DateTime receiptDate = dateTimePickerThanhToan.Value;

                if (string.IsNullOrEmpty(staffId))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên.");
                    return;
                }
                var lastReceipt = db.Receipts.OrderByDescending(r => r.ReceiptId).FirstOrDefault();
                int newReceiptId = 1;

                if (lastReceipt != null)
                {
                    // Nếu có hóa đơn trước đó, lấy số cuối cùng và cộng thêm 1
                    string lastReceiptId = lastReceipt.ReceiptId;
                    newReceiptId = int.Parse(lastReceiptId.Substring(2)) + 1; // Lấy phần số của mã hóa đơn và cộng 1
                }

                // Tạo mã hóa đơn mới theo định dạng ID3, ID4, ID5, ...
                string newReceiptIdString = "ID" + newReceiptId.ToString();

                dateTimePickerThanhToan.Value = DateTime.Now; // Thiết lập giá trị mặc định là ngày hiện tại
                dateTimePickerThanhToan.Format = DateTimePickerFormat.Custom;
                dateTimePickerThanhToan.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày theo yêu cầu

                // Lấy giá trị status từ ComboBox 
                string status = cbStatus.SelectedItem?.ToString(); // Hoặc giá trị khác tùy thuộc vào cách bạn nhận status
                decimal totalReceipt = 0;
                decimal.TryParse(txtTotal.Text, out totalReceipt);
                var receipt = new Receipt
                {
                    ReceiptId = newReceiptIdString,
                    PatientId = patientId,
                    StaffId = staffId,
                    receiptdate = receiptDate,
                    total = totalReceipt,
                    note = "Thanh toán dịch vụ",
                    statusReceipt = (status == "Đã thanh toán") ? (bool?)true : (bool?)false
                };

                db.Receipts.Add(receipt);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!");

                    // Reset lại tất cả các điều khiển sau khi thanh toán thành công
                    ResetForm();

                    // Cập nhật lại DataGridView
                    LoadReceipts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng trong DataGridView chưa
            if (dataGridViewThanhToan.SelectedRows.Count > 0)
            {
                // Lấy ReceiptId từ dòng được chọn
                string receiptId = dataGridViewThanhToan.SelectedRows[0].Cells["ReceiptId"].Value.ToString();

                // Xác nhận người dùng có chắc chắn muốn xóa không
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xóa hóa đơn", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                    {
                        // Tìm hóa đơn trong cơ sở dữ liệu dựa trên ReceiptId
                        var receipt = db.Receipts.FirstOrDefault(r => r.ReceiptId == receiptId);

                        if (receipt != null)
                        {
                            // Xóa hóa đơn khỏi cơ sở dữ liệu
                            db.Receipts.Remove(receipt);
                            db.SaveChanges();

                            // Thông báo người dùng
                            MessageBox.Show("Hóa đơn đã được xóa thành công.");

                            // Cập nhật lại DataGridView
                            LoadReceipts();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
            }

        }


        private decimal medicineTotal = 0;
        private void checkedListBoxThuoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy tên thuốc từ mục đang kiểm tra
                string selectedItem = checkedListBoxThuoc.Items[e.Index].ToString();
                string medicineName = selectedItem.Split('(')[0].Trim();

                // Tìm thuốc trong database
                var medicine = db.Medicines.FirstOrDefault(m => m.nameMedicine == medicineName);

                if (medicine != null)
                {
                    decimal medicinePrice = medicine.price ?? 0;

                    // Cập nhật tổng tiền thuốc
                    if (e.NewValue == CheckState.Checked)
                    {
                        medicineTotal += medicinePrice;
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        medicineTotal -= medicinePrice;
                    }

                    txtTienThuoc.Text = medicineTotal.ToString("N0");
                    UpdateTotal();
                }
            }
        }

        private void checklistboxDV_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
            {
                // Lấy tên dịch vụ từ mục đang kiểm tra (vì chúng ta lưu tên dịch vụ trong CheckedListBox)
                string serviceName = checklistboxDV.Items[e.Index].ToString();

                // Lấy thông tin dịch vụ từ cơ sở dữ liệu dựa trên tên dịch vụ
                var service = db.Services.FirstOrDefault(s => s.nameService == serviceName);

                if (service != null)
                {
                    decimal servicePrice = service.price ?? 0; // Lấy giá dịch vụ

                    // Kiểm tra trạng thái checkbox (checked hoặc unchecked)
                    if (e.NewValue == CheckState.Checked)
                    {
                        total += servicePrice; // Thêm giá trị vào total khi checkbox được chọn
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        total -= servicePrice; // Giảm giá trị khi checkbox bị bỏ chọn
                    }

                    // Cập nhật giá trị total lên textbox
                    txtTienDV.Text = total.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Dịch vụ không tìm thấy trong cơ sở dữ liệu.");
                }
            }

        }

        
    }

}
