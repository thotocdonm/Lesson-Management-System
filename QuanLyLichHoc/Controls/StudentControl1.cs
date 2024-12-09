using System;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDev.HtmlRenderer.Adapters;
using System.Data;
using QuanLyLichHoc.Services;
using QuanLyLichHoc.Models;
using System.Collections.Generic;


namespace QuanLyLichHoc.Controls
{
    public partial class StudentControl1 : UserControl
    {
        private StudentService _student;

        public StudentControl1()
        {
            InitializeComponent();
            dgvStudents.CellClick += dgvStudents_CellClick;
            _student = new StudentService();
            LoadLecturer();

        }
        public void LoadLecturer()
        {
            List<Student> displayStudent = _student.GetLecturer();
            dgvStudents.Columns.Clear();
            dgvStudents.DataSource = displayStudent;
            dgvStudents.Columns["studentId"].Visible = false;
            Edit.Visible = false;
            Delete.Visible = false;
        }
        private DataGridViewRow row;
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Get the selected row
            row = dgvStudents.Rows[e.RowIndex];
            txtName.Text = row.Cells["studentName"].Value?.ToString();
            txtEmail.Text = row.Cells["studentEmail"].Value?.ToString();
            TxtGender.Text = row.Cells["studentGender"].Value?.ToString();
            TxtPhone.Text = row.Cells["studentPhone"].Value?.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells["studentDob"].Value?.ToString());
            Edit.Visible = true;
            Delete.Visible = true;
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
            Models.Student lecture = new Models.Student
            {
                studentName = txtName.Text,
                studentGender = TxtGender.Text,
                studentEmail = txtEmail.Text,
                studentPhone = TxtPhone.Text,
                studentDob = dateTimePicker1.Value,
            };
            try
            {
                _student.AddLecturer(lecture);
                MessageBox.Show("Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadLecturer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string studentId = row.Cells["studentId"].Value?.ToString();
                string studentPhone = TxtPhone.Text;
                string studentEmail = txtEmail.Text;
                string studentGender = TxtGender.Text;
                string studentName = txtName.Text;
                DateTime studentDob = dateTimePicker1.Value;
                Student lesson = new Student
                {
                    studentId = studentId,
                    studentDob = DateTime.Parse(studentDob.ToString()),
                    studentPhone = studentPhone,
                    studentEmail = studentEmail,
                    studentGender = studentGender,
                    studentName = studentName,
                };
                _student.EditLecturer(lesson);
                LoadLecturer() ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string lectureId = row.Cells["studentId"].Value?.ToString();
                Models.Student lecture = _student.GetLecturerById(lectureId);
                _student.DeleteLecturer(lecture);
                LoadLecturer();
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
