using System;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDev.HtmlRenderer.Adapters;
using System.Data;


namespace QuanLyLichHoc.Controls
{
    public partial class StudentControl1 : UserControl
    {
        private DataTable studentTable;

        public StudentControl1()
        {
            InitializeComponent();
            InitializeStudentTable();

        }
        private void InitializeStudentTable()
        {
            // Khởi tạo DataTable
            studentTable = new DataTable();

            // Thêm các cột vào DataTable
            studentTable.Columns.Add("Name", typeof(string));
            studentTable.Columns.Add("Birth", typeof(string));
            studentTable.Columns.Add("Email", typeof(string));
            studentTable.Columns.Add("PhoneNumber", typeof(string));
            studentTable.Columns.Add("Gender", typeof(string));

            // Gắn DataTable vào DataGridView
            dgvStudents.DataSource = studentTable;
        }

        private void StudentControl1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string name = txtName.Text.Trim();
            string birth = txtBirth.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = TxtPhone.Text.Trim();
            string Gender = TxtGender.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(birth) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(Gender))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Thêm vào DataTable
            studentTable.Rows.Add(name, birth, email, phoneNumber, Gender);

            // Xóa nội dung trong các TextBox
            txtName.Clear();
            txtBirth.Clear();
            txtEmail.Clear();
            TxtPhone.Clear();
            TxtGender.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudents.SelectedRows[0];

                selectedRow.Cells["Name"].Value = txtName.Text.Trim();
                selectedRow.Cells["Birth"].Value = txtBirth.Text.Trim();
                selectedRow.Cells["Email"].Value = txtEmail.Text.Trim();
                selectedRow.Cells["PhoneNumber"].Value = TxtPhone.Text.Trim();
                selectedRow.Cells["Gender"].Value = TxtGender.Text.Trim();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                dgvStudents.Rows.RemoveAt(dgvStudents.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
