using QuanLyLichHoc.Interfaces;
using QuanLyLichHoc.Models;
using QuanLyLichHoc.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyLichHoc.Controls
{
    public partial class HomeControl : UserControl

        
    {
        private readonly ILesson _lesson;
        int day, month, year;
        List<Lecturer> listLectures;

        List<Subject> listSubjects;

        List<Lesson> listData;


        public HomeControl()
        {
            InitializeComponent();
            _lesson = new LessonService();
             listLectures = _lesson.GetLecturer();

            listSubjects = _lesson.GetSubject();

             listData = _lesson.GetLesson();
            displayDays();
        }


        private void displayDays()
        {
            DateTime now = DateTime.Now;

            DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek);
            day = startOfWeek.Day;
            month = startOfWeek.Month;
            year = startOfWeek.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = $"{monthname} {year}";
            dayContainer.Controls.Clear();
           
              for (int i = 0; i < 7; i++)
               {
                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{startOfWeek.Day}/{startOfWeek.Month}");
                var label = "";
                for (int j = 0; j < listData.Count; j++)
                {
                    if (listData[j].lessonDate.Year == startOfWeek.Year &&
                        listData[j].lessonDate.Month == startOfWeek.Month &&
                    listData[j].lessonDate.Day == startOfWeek.Day)
                    {
                        for (int f = 0; f < listSubjects.Count; f++)
                        {
                            if (listSubjects[f].subjectId == listData[j].subjectId)
                            {
                                label = label + "Môn học: " + listSubjects[f].subjectName + "\n";
                            }
                        }
                        for (int e = 0; e < listLectures.Count; e++)
                        {
                            if (listLectures[e].lecturerId == listData[j].lecturerId)
                            {
                                label = label + "Giáo viên: " + listLectures[e].lecturerName + "\n";
                            }
                        }
                       
                        label = label + "Thời gian:\n" + listData[j].startTime + " -> " +  listData[j].endTime + "\n\n";
                    }
                   
                }
                hcday.labels(label);
                dayContainer.Controls.Add(hcday);
                startOfWeek = startOfWeek.AddDays(1);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();


            DateTime currentDate = new DateTime(year, month, day).AddDays(-7);

            month = currentDate.Month;
            year = currentDate.Year;
            day = currentDate.Day;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = monthname + " " + year;

            int daysToShow = 7;
            int currentDay = day;
            int currentMonth = month;
            int currentYear = year;

            for (int i = 0; i < daysToShow; i++)
            {
                if (currentDay > DateTime.DaysInMonth(currentYear, currentMonth))
                {
                    currentDay = 1;
                    currentMonth++;
                    if (currentMonth > 12)
                    {
                        currentMonth = 1;
                        currentYear++;
                    }
                }

                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{currentDay}/{currentMonth}");

                var label = "";
                for (int j = 0; j < listData.Count; j++)
                {
                    if (listData[j].lessonDate.Year == currentYear &&
                        listData[j].lessonDate.Month == currentMonth &&
                    listData[j].lessonDate.Day == currentDay)
                    {
                        for (int f = 0; f < listSubjects.Count; f++)
                        {
                            if (listSubjects[f].subjectId == listData[j].subjectId)
                            {
                                label = label + "Môn học: " + listSubjects[f].subjectName + "\n";
                            }
                        }
                        for (int g = 0; g < listLectures.Count; g++)
                        {
                            if (listLectures[g].lecturerId == listData[j].lecturerId)
                            {
                                label = label + "Giáo viên: " + listLectures[g].lecturerName + "\n";
                            }
                        }
                        label = label + "Thời gian:\n" + listData[j].startTime + " -> " + listData[j].endTime + "\n\n";
                    }

                }
                hcday.labels(label);
                dayContainer.Controls.Add(hcday);

                currentDay++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            DateTime currentDate = new DateTime(year, month, day).AddDays(7);

            month = currentDate.Month;
            year = currentDate.Year;
            day = currentDate.Day;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LABELDATE.Text = monthname + " " + year;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            int daysToShow = 7;
            int currentDay = day;
            int currentMonth = month;
            int currentYear = year;


            for (int i = 0; i < daysToShow; i++)
            {
                if (currentDay > DateTime.DaysInMonth(currentYear, currentMonth))
                {
                    currentDay = 1; 
                    currentMonth++;
                    if (currentMonth > 12) 
                    {
                        currentMonth = 1;
                        currentYear++;
                    }
                }

                HomeControlDay hcday = new HomeControlDay();
                hcday.days($"{currentDay}/{currentMonth}");

                var label = "";
                for (int j = 0; j < listData.Count; j++)
                {
                    if (listData[j].lessonDate.Year == currentYear &&
                        listData[j].lessonDate.Month == currentMonth &&
                    listData[j].lessonDate.Day == currentDay)
                    {
                        for (int f = 0; f < listSubjects.Count; f++)
                        {
                            if (listSubjects[f].subjectId == listData[j].subjectId)
                            {
                                label = label + "Môn học: " + listSubjects[f].subjectName + "\n";
                            }
                        }
                        for (int g = 0; g < listLectures.Count; g++)
                        {
                            if (listLectures[g].lecturerId == listData[j].lecturerId)
                            {
                                label = label + "Giáo viên: " + listLectures[g].lecturerName + "\n";
                            }
                        }
                        label = label + "Thời gian:\n" + listData[j].startTime + " -> " + listData[j].endTime + "\n\n";
                    }

                }
                hcday.labels(label);
                dayContainer.Controls.Add(hcday);

                currentDay++; 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
