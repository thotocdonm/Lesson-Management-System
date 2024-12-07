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


namespace QuanLyLichHoc.Controls
{
    public partial class LecturerControl : UserControl
    {
        private readonly ILecturer _lecturer;
        private int currentPage = 1;
        private int pageSize = 10;
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
                dataGridView.Columns.Clear();
                dataGridView.DataSource = allLecturer;
                update_lecture_button.Visible=false;
                delete_lecture_button.Visible= false;
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
            char gender;
            switch (comboBox_lecture_gender.Text)
            {
                case "Male":
                    gender = 'M';
                    break;
                case "Female":
                    gender = 'F';
                    break;
                case "Other":
                    gender = 'O';
                    break;
                default:
                    gender = 'O';
                    break;
            }
            string status;
            switch (comboBox_lecture_status.Text)
            {
                case "Active":
                    status = "Active";
                    break;
                case "Inactive":
                    status = "Inactive";
                    break;
                default:
                    status = "Active";
                    break;
            }
            Models.Lecture lecture = new Models.Lecture
            {
                LectureName = text_lecture_name.Text,
                LectureGender = gender.ToString(),
                LectureAddress = text_lecture_address.Text,
                LectureStatus = status
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
            text_lecture_address.Text = "";
            comboBox_lecture_status.SelectedIndex = -1;
            comboBox_lecture_gender.SelectedIndex = -1;
            //dtp_dateOfBirth.Value = DateTime.Now;
            //dtp_hireDate.Value = DateTime.Now;
        }

        private void update_lecture_button_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string lectureId = row.Cells["LectureId"].Value?.ToString();
                string lectureName = row.Cells["LectureName"].Value?.ToString();
                string lectureAddress = row.Cells["LectureAddress"].Value?.ToString();
                string gender = row.Cells["LectureGender"].Value?.ToString();
                string status = row.Cells["LectureStatus"].Value?.ToString();

                UpdateLecturer updateLecturer = new UpdateLecturer(lectureId, lectureName, lectureAddress, gender, status);
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
                string lectureId = row.Cells["LectureId"].Value?.ToString();
                Models.Lecture lecture = _lecturer.GetLecturerById(int.Parse(lectureId));
                _lecturer.DeleteLecturer(lecture);
                LoadLecturer();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var dataSearch = _lecturer.GetLecturer(text_lecture_search.Text, currentPage, pageSize);
            var searchLecturer = dataSearch.Lecturer;
            dataGridView.DataSource = searchLecturer;
        }
    }
}
