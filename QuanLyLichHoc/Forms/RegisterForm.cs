using System;
using System.Windows.Forms;
using QuanLyLichHoc.Forms.Login;  // Để chuyển về form đăng nhập   
using System.Linq;               // Để sử dụng LINQ với dữ liệu
using QuanLyLichHoc.Models;

namespace QuanLyLichHoc.Forms.Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {

            InitializeComponent();


        }

        // Xử lý sự kiện khi nhấn nút Đăng Ký
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrWhiteSpace(UserNameTxt.Text) ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                string.IsNullOrWhiteSpace(PasswordTxt.Text) ||
                RoleComboBox.SelectedIndex == -1) // Kiểm tra nếu RoleComboBox chưa được chọn
            {
                // Hiển thị thông báo lỗi nếu chưa nhập đủ thông tin
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Khởi tạo đối tượng DataContext để kết nối với cơ sở dữ liệu
                DataClasses1DataContext db = new DataClasses1DataContext();

                // Tạo đối tượng người dùng
                var newUser = new User
                {
                    userName = UserNameTxt.Text,
                    password = PasswordTxt.Text,  // Mã hóa mật khẩu nếu cần
                    role = RoleComboBox.SelectedItem.ToString(),
                    email = EmailTxt.Text
                };

                try
                {
                    // Kiểm tra nếu email đã tồn tại trong cơ sở dữ liệu (không kiểm tra trùng email theo yêu cầu)
                    var existingUser = db.Users.FirstOrDefault(u => u.email == newUser.email);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm người dùng mới vào cơ sở dữ liệu
                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển về form đăng nhập sau khi đăng ký thành công
                    this.Hide();  // Ẩn form đăng ký
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();  // Hiển thị form đăng nhập
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có vấn đề khi lưu vào cơ sở dữ liệu
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xử lý sự kiện khi người dùng đóng form (ấn X)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Ẩn form đăng ký và chuyển thẳng về form đăng nhập khi người dùng ấn X
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Hiển thị form đăng nhập
        }
    }
}
