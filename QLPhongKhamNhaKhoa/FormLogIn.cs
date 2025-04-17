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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTaiKhoan = txtUsername.Text.Trim();
                string matKhau = txtPassword.Text.Trim();

                // Kiểm tra thông tin nhập vào
                if (string.IsNullOrEmpty(tenTaiKhoan))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (DentalClinic_DatabaseEntities db = new DentalClinic_DatabaseEntities())
                {
                    // Tìm tài khoản có tên người dùng và mật khẩu khớp
                    var account = db.Accounts.FirstOrDefault(a => a.userName == tenTaiKhoan && a.passWord == matKhau);

                    if (account != null)
                    {
                        // Đăng nhập thành công
                        //MessageBox.Show($"Xin chào", "Thông báo");

                        // Chuyển đến giao diện chính (MainForm hoặc Dashboard)
                        this.Hide();
                        FormMain mainForm = new FormMain(); // Thay MainForm bằng form chính của bạn
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Tên đăng nhập hoặc mật khẩu không đúng
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
