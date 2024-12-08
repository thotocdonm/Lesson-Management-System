using QuanLyLichHoc.Interfaces;
using QuanLyLichHoc.Models;
using QuanLyLichHoc.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyLichHoc.Controls
{
    public partial class LessonControl : UserControl
    {
        private readonly ILesson _lesson;
        private int currentPage = 1;
        private int pageSize = 8;
        public LessonControl()
        {
            InitializeComponent();
            _lesson = new LessonService();
            dataGridView.CellClick += dataGridView_CellClick;
            initDataSelect();
            LoadLesson();
        }

        public void initDataSelect()
        {
            List <Lecturer> listLectures = _lesson.GetLecturer();
            lecturerValue.Items.Clear();
            for (int i = 0; i < listLectures.Count; i++)
            {
                Lecturer lecturer = listLectures[i];
                lecturerValue.Items.Add(lecturer.lecturerName);
            }

            List<Subject> listSubjects = _lesson.GetSubject();
            subjectValue.Items.Clear();
            for (int i = 0; i < listSubjects.Count; i++)
            {
                Subject subject = listSubjects[i];
                subjectValue.Items.Add(subject.subjectName);
            }
        }

        public void LoadLesson()
        {
            if (searchValue.Text != null)
            {
                string search = searchValue.Text;
                var displayLesson = _lesson.GetLessonSearch(search, currentPage, pageSize);
                var allLesson = displayLesson.lesson;
                var totalPage = displayLesson.totalPages;
                var formattedLessons = allLesson.OrderBy(l => l.createAt).Select(lesson => new
                {
                    lesson.lessonId,
                    lesson.lecturerName,
                    lesson.subjectName,

                    timeValue = lesson.startTime == new TimeSpan(6, 45, 0) ? "Ca 1(Từ 6:45 đến 9:00)" :
                                         lesson.startTime == new TimeSpan(9, 25, 0) ? "Ca 2(Từ 9:25 đến 11:40)" :
                                         lesson.startTime == new TimeSpan(12, 15, 0) ? "Ca 3(Từ 12:15 đến 14:40)" :
                                         lesson.startTime == new TimeSpan(14, 55, 0) ? "Ca 4(Từ 14:55 đến 17:15)" :
                                         null,
                    lessonDate = lesson.lessonDate.ToString("dd/MM/yyyy")
                }).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = formattedLessons;
                dataGridView.Columns.Clear();
                dataGridView.DataSource = bindingSource;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.Columns["lessonId"].Visible = false;
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
                //PageOnPage.Text = $"{currentPage}/{totalPage}";

                //btn_Previous.Enabled = currentPage > 1;
                //btn_Next.Enabled = currentPage < totalPage;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startTime_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeSpan? startTime;

            TimeSpan? endTime;

            switch (timeValue.Text)
            {
                case "Ca 1 (Từ 6:45 đến 9:00)":
                    startTime = new TimeSpan(6, 45, 0); 
                    endTime = new TimeSpan(9, 0, 0);   
                    break;

                case "Ca 2 (Từ 9:25 đến 11:40)":
                    startTime = new TimeSpan(9, 25, 0); 
                    endTime = new TimeSpan(11, 40, 0);
                    break;

                case "Ca 3 (Từ 12:15 đến 14:40)":
                    startTime = new TimeSpan(12, 15, 0); 
                    endTime = new TimeSpan(14, 40, 0);  
                    break;

                case "Ca 4 (Từ 14:55 đến 17:15)":
                    startTime = new TimeSpan(14, 55, 0); 
                    endTime = new TimeSpan(17, 15, 0);  
                    break;

                default:
                    startTime = null;
                    endTime = null;
                    break;
            }

            string subjectId = "";

            string lecturerId = "";
            List<Lecturer> listLectures = _lesson.GetLecturer();
            for (int i = 0; i < listLectures.Count; i++)
            {
                if (listLectures[i].lecturerName == lecturerValue.SelectedItem.ToString())
                {
                    lecturerId = listLectures[i].lecturerId;
                }
            }

            List<Subject> listSubjects = _lesson.GetSubject();
            for (int i = 0; i < listSubjects.Count; i++)
            {
                if (listSubjects[i].subjectName == subjectValue.SelectedItem.ToString())
                {
                    subjectId = listSubjects[i].subjectId;
                }
            }
            Lesson lesson = new Lesson
            {
                lessonDate = DateTime.Parse(dateValue.Text),
                startTime = startTime,
                endTime = endTime,
                subjectId = subjectId,
                lecturerId = lecturerId,
            };
            try
            {
                _lesson.AddLesson(lesson);
                MessageBox.Show("Lesson added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddLesson();
                LoadLesson();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAddLesson()
        {
            dateValue.Text = "";
            timeValue.SelectedIndex = -1;
            subjectValue.SelectedIndex = -1;
            lecturerValue.SelectedIndex = -1;
        }

        private DataGridViewRow row;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            row = dataGridView.Rows[e.RowIndex];
            updateBtn.Visible = true;
            deleteBtn.Visible = true;
            lecturerValue.Text = row.Cells["lecturerName"].Value?.ToString();
            subjectValue.Text = row.Cells["subjectName"].Value?.ToString();
            timeValue.Text = row.Cells["timeValue"].Value?.ToString();
            dateValue.Value = DateTime.ParseExact(row.Cells["lessonDate"].Value?.ToString(), "dd/MM/yyyy", null);
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string lessonId = row.Cells["lessonId"].Value?.ToString();
                TimeSpan? startTime;

                TimeSpan? endTime;
                switch (timeValue.Text)
                {
                    case "Ca 1 (Từ 6:45 đến 9:00)":
                        startTime = new TimeSpan(6, 45, 0);
                        endTime = new TimeSpan(9, 0, 0);
                        break;

                    case "Ca 2 (Từ 9:25 đến 11:40)":
                        startTime = new TimeSpan(9, 25, 0);
                        endTime = new TimeSpan(11, 40, 0);
                        break;

                    case "Ca 3 (Từ 12:15 đến 14:40)":
                        startTime = new TimeSpan(12, 15, 0);
                        endTime = new TimeSpan(14, 40, 0);
                        break;

                    case "Ca 4 (Từ 14:55 đến 17:15)":
                        startTime = new TimeSpan(14, 55, 0);
                        endTime = new TimeSpan(17, 15, 0);
                        break;

                    default:
                        startTime = null;
                        endTime = null;
                        break;
                }

                string subjectId = "";

                string lecturerId = "";
                List<Lecturer> listLectures = _lesson.GetLecturer();
                for (int i = 0; i < listLectures.Count; i++)
                {
                    if (listLectures[i].lecturerName == lecturerValue.SelectedItem.ToString())
                    {
                        lecturerId = listLectures[i].lecturerId;
                    }
                }

                List<Subject> listSubjects = _lesson.GetSubject();
                for (int i = 0; i < listSubjects.Count; i++)
                {
                    if (listSubjects[i].subjectName == subjectValue.SelectedItem.ToString())
                    {
                        subjectId = listSubjects[i].subjectId;
                    }
                }
                Lesson lesson = new Lesson
                {
                    lessonId = lessonId,
                    lessonDate = DateTime.Parse(dateValue.Text),
                    startTime = startTime,
                    endTime = endTime,
                    subjectId = subjectId,
                    lecturerId = lecturerId,
                };
                _lesson.EditLesson(lesson);
                ClearAddLesson();
                LoadLesson();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            var dataSearch = _lesson.GetLessonSearch(searchValue.Text, currentPage, pageSize);
            var searchLesson = dataSearch.lesson;
            var totalPage = dataSearch.totalPages;
            var formattedLessons = searchLesson.OrderBy(l => l.createAt).Select(lesson => new
            {
                lesson.lessonId,
                lesson.lecturerName,
                lesson.subjectName,
                timeValue = lesson.startTime == new TimeSpan(6, 45, 0) ? "Ca 1(Từ 6:45 đến 9:00)" :
                                         lesson.startTime == new TimeSpan(9, 25, 0) ? "Ca 2(Từ 9:25 đến 11:40)" :
                                         lesson.startTime == new TimeSpan(12, 15, 0) ? "Ca 3(Từ 12:15 đến 14:40)" :
                                         lesson.startTime == new TimeSpan(14, 55, 0) ? "Ca 4(Từ 14:55 đến 17:15)" :
                                         null,
                lessonDate = lesson.lessonDate.ToString("dd/MM/yyyy")
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = formattedLessons;
            dataGridView.Columns.Clear();
            dataGridView.DataSource = bindingSource;
            dataGridView.Columns["lessonId"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            updateBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string lessonId = row.Cells["lessonId"].Value?.ToString();
                Lesson lesson = _lesson.GetLessonById(lessonId);
                _lesson.DeleteLesson(lesson);
                LoadLesson();
            }
        }
    }
}
