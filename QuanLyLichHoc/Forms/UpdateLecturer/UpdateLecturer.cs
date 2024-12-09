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
        private string lectureEmail;
        private string gender;
        private string phone;
        private DateTime date;
        public UpdateLecturer(string lectureId, string lectureName, string lectureEmail, string gender, string phone, DateTime date)
        {
            InitializeComponent();
            _editLecture = new LecturerService();
            this.lectureId = lectureId;
            this.lectureName = lectureName;
            this.lectureEmail = lectureEmail;
            this.gender = gender;
            this.phone = phone;
            this.date = date;
        }

        private void UpdateLecturer_Load(object sender, EventArgs e)
        {
            text_lecture_id.Text = lectureId;
            text_lecture_email.Text = lectureEmail;
            text_lecture_name.Text = lectureName;
            comboBox_lecture_gender.Text = gender;
            text_lecture_phone.Text = phone;
            dateTimeOBLecture.Value = date;
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

            Models.Lecturer lecture = new Models.Lecturer
            {
                lecturerId = text_lecture_id.Text,
                lecturerName = text_lecture_name.Text,
                lecturerGender = gender.ToString(),
                lecturerEmail = text_lecture_email.Text,
                lecturerPhone = text_lecture_phone.Text,
                lecturerDob = dateTimeOBLecture.Value,
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
