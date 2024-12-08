using QuanLyLichHoc.Forms.Register;  // Thêm namespace Register để gọi Form đăng ký
using QuanLyLichHoc.Models;
using System;
using System.Linq;
using System.Windows.Forms;
namespace QuanLyLichHoc.Forms.Login
{
    public partial class LoginForm : Form
    {
        // Khởi tạo đối tượng DataContext để kết nối với cơ sở dữ liệu
        DataClasses1DataContext db = new DataClasses1DataContext();

        public LoginForm()
        {
            InitializeComponent();  // Gọi phương thức tự động khởi tạo giao diện


        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (string.IsNullOrEmpty(UsernameTxt.Text) || string.IsNullOrEmpty(PasswordTxt.Text))
            {
                MessageBox.Show("Please enter complete account information and password ădasd.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu chưa nhập đủ
            }

            // Kiểm tra thông tin đăng nhập trong cơ sở dữ liệu
            var user = db.Users.SingleOrDefault(u => u.userName == UsernameTxt.Text && u.password == PasswordTxt.Text);

            if (user != null)
            {
                // Đăng nhập thành công
                MessageBox.Show("Successful login!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Chuye den ma hinh chinh
                MainForm main = new MainForm();
                main.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Wrong login name or password.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            // Mở form đăng ký và ẩn form đăng nhập
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Ẩn form LoginForm
        }
    }
}
