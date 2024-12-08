using QuanLyLichHoc.Models;
using QuanLyLichHoc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichHoc.Interfaces
{
    internal interface ILesson
    {
        List<LessonService> LessonData();
        List<Lesson> GetLesson();
        (List<LessonDetail> lesson, int totalLesson, int totalPages) GetLessonSearch(string search, int page, int pageSize);
        Lesson GetLessonById(string lessonId);
        void EditLesson(Lesson lesson);
        void AddLesson(Lesson lesson);
        void DeleteLesson(Lesson lesson);

        List<Lecturer> GetLecturer();
        List<Subject> GetSubject();
    }
}
