using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichHoc.Services;
using System.Windows.Forms;
using QuanLyLichHoc.Interfaces;
using QuanLyLichHoc.Forms.UpdateLecturer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyLichHoc.Models;


namespace QuanLyLichHoc.Controls
{
    public partial class LecturerControl : UserControl
    {
        private readonly ILecturer _lecturer;
        private int currentPage = 1;
        private int pageSize = 8;
        public LecturerControl()
        {
            InitializeComponent();
            _lecturer = new LecturerService();
            dataGridView.CellClick += dataGridView_CellClick;
            LecturerAtr();
            LoadLecturer();
        }
        public void LoadLecturer()
        {
            if (text_lecture_search.Text != null)
            {
                string search = text_lecture_search.Text;
                var displayLecturer = _lecturer.GetLecturer(search, currentPage, pageSize);
                var allLecturer = displayLecturer.Lecturer;
                var totalPage = displayLecturer.TotalPages;
                var formattedLecturers = allLecturer.OrderBy(l => l.create_at).Select(lecturer => new
                {
                    lecturer.lecturerId,
                    lecturer.lecturerName,
                    lecturer.lecturerEmail,
                    lecturer.lecturerPhone,
                    LecturerGender = lecturer.lecturerGender == "M" ? "Male" :
                                         lecturer.lecturerGender == "F" ? "Female" :
                                         lecturer.lecturerGender == "O" ? "Other" :
                                         "Unknown",
                    LecturerDob = lecturer.lecturerDob?.ToString("dd/MM/yyyy")
                }).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = formattedLecturers;
                dataGridView.Columns.Clear();
                dataGridView.DataSource = bindingSource;
                dataGridView.Columns["lecturerId"].Visible = false;
                update_lecture_button.Visible=false;
                delete_lecture_button.Visible= false;
                PageOnPage.Text = $"{currentPage}/{totalPage}";

                btn_Previous.Enabled = currentPage > 1;
                btn_Next.Enabled = currentPage < totalPage;
            }
        }


        private DataGridViewRow row;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Get the selected row
            row = dataGridView.Rows[e.RowIndex];
            update_lecture_button.Visible = true;
            delete_lecture_button.Visible = true;
        }

        public void LecturerAtr()
        {
            LecturerService lectureatr = new LecturerService();
            dataGridView.DataSource = lectureatr.LectureData();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void add_lecture_button_Click(object sender, EventArgs e)
        {
            string gender;
            switch (comboBox_lecture_gender.Text)
            {
                case "Male":
                    gender = "M";
                    break;
                case "Female":
                    gender = "F";
                    break;
                case "Other":
                    gender = "O";
                    break;
                default:
                    gender = "O";
                    break;
            }
            Models.Lecturer lecture = new Models.Lecturer
            {
                lecturerName = text_lecture_name.Text,
                lecturerGender = gender,
                lecturerEmail = text_lecture_email.Text,
                lecturerPhone = text_lecture_phone.Text,
                lecturerDob = dateTimeOBLecture.Value,
            };
            try
            {
                _lecturer.AddLecturer(lecture);
                MessageBox.Show("Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddEployee();
                LoadLecturer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearAddEployee()
        {
            text_lecture_name.Text = "";
            text_lecture_phone.Text = "";
            text_lecture_email.Text = "";
            text_lecture_email.Text = "";
            comboBox_lecture_gender.SelectedIndex = -1;
            //dtp_dateOfBirth.Value = DateTime.Now;
            //dtp_hireDate.Value = DateTime.Now;
        }

        private void update_lecture_button_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string lectureId = row.Cells["lecturerId"].Value?.ToString();
                string lectureName = row.Cells["lecturerName"].Value?.ToString();
                string lectureEmail = row.Cells["lecturerEmail"].Value?.ToString();
                string gender = row.Cells["lecturerGender"].Value?.ToString();
                string phone = row.Cells["lecturerPhone"].Value?.ToString();
                DateTime date = DateTime.Parse(row.Cells["lecturerDob"].Value?.ToString());

                UpdateLecturer updateLecturer = new UpdateLecturer(lectureId, lectureName, lectureEmail, gender, phone, date);
                updateLecturer.StartPosition = FormStartPosition.Manual;
                updateLecturer.Location = new Point(500, 200);
                updateLecturer.LecturerUpdated += () =>
                {
                    LoadLecturer();
                };
                updateLecturer.Show();
            }
            
        }

        private void delete_lecture_button_Click(object sender, EventArgs e)
        {
            if(row != null)
            {
                string lectureId = row.Cells["lecturerId"].Value?.ToString();
                Models.Lecturer lecture = _lecturer.GetLecturerById(lectureId);
                _lecturer.DeleteLecturer(lecture);
                LoadLecturer();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            var dataSearch = _lecturer.GetLecturer(text_lecture_search.Text, currentPage, pageSize);
            var searchLecturer = dataSearch.Lecturer;
            var totalPage = dataSearch.TotalPages;
            var formattedLecturers = searchLecturer.OrderBy(l => l.create_at).Select(lecturer => new
            {
                lecturer.lecturerId,
                lecturer.lecturerName,
                lecturer.lecturerEmail,
                lecturer.lecturerPhone,
                LecturerGender = lecturer.lecturerGender == "M" ? "Male" :
                                         lecturer.lecturerGender == "F" ? "Female" :
                                         lecturer.lecturerGender == "O" ? "Other" :
                                         "Unknown",
                LecturerDob = lecturer.lecturerDob?.ToString("dd/MM/yyyy")
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = formattedLecturers;
            dataGridView.Columns.Clear();
            dataGridView.DataSource = bindingSource;
            dataGridView.Columns["lecturerId"].Visible = false;
            update_lecture_button.Visible = false;
            delete_lecture_button.Visible = false;
            PageOnPage.Text = $"{currentPage}/{totalPage}";

            btn_Previous.Enabled = currentPage > 1;
            btn_Next.Enabled = currentPage < totalPage;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadLecturer();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadLecturer();
            }
        }

        private void dateTimeOBLecture_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clear_lecture_button_Click(object sender, EventArgs e)
        {
            text_lecture_email.Clear();
            text_lecture_name.Clear();
            text_lecture_phone.Clear();
            text_lecture_search.Clear();
            comboBox_lecture_gender.Items.Clear();
        }
    }
}
