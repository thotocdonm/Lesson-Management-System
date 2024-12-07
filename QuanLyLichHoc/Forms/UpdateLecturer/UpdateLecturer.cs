using QuanLyLichHoc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLichHoc.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyLichHoc.Interfaces;

namespace QuanLyLichHoc.Forms.UpdateLecturer
{
    public partial class UpdateLecturer : Form
    {
        public event Action LecturerUpdated;
        private readonly ILecturer _editLecture;
        private string lectureId;
        private string lectureName;
        private string lectureAddress;
        private string gender;
        private string status;
        public UpdateLecturer(string lectureId, string lectureName, string lectureAddress, string gender, string status)
        {
            InitializeComponent();
            _editLecture = new LecturerService();
            this.lectureId = lectureId;
            this.lectureName = lectureName;
            this.lectureAddress = lectureAddress;
            this.gender = gender;
            this.status = status;
        }

        private void UpdateLecturer_Load(object sender, EventArgs e)
        {
            text_lecture_id.Text = lectureId;
            text_lecture_address.Text = lectureAddress;
            text_lecture_name.Text = lectureName;
            comboBox_lecture_gender.Text = gender;
            comboBox_lecture_status.Text = status;
        }

        private void update_lecture_button_Click(object sender, EventArgs e)
        {
            string gender;
            switch (comboBox_lecture_gender.Text)
            {
                case "Male":
                    gender = "M";
                    break;
                case "Female":
                    gender="M";
                    break;
                case "Other":
                    gender = "O";
                    break;
                default: 
                    gender = "M"; 
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
                LectureID = int.Parse(text_lecture_id.Text),
                LectureName = text_lecture_name.Text,
                LectureGender = gender.ToString(),
                LectureAddress = text_lecture_address.Text,
                LectureStatus = status
            };

            try
            {
                _editLecture.EditLecturer(lecture);
                LecturerUpdated?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
