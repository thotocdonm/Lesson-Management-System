using QuanLyLichHoc.Interfaces;
using QuanLyLichHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichHoc.Services
{
    internal class LessonService : ILesson
    {

        public string lessonId { get; set; }
        public DateTime lessonDate { get; set; }
        public TimeSpan? startTime { get; set; }
        public TimeSpan? endTime { get; set; }
        public string lecturerId { get; set; }
        public string subjectId { get; set; }

        public DateTime? create_at { get; set; }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void AddLesson(Lesson lesson)
        {
            try
            {
                lesson.lessonId = Guid.NewGuid().ToString().Substring(0, 20);
                lesson.isDeleted = 0;
                lesson.createAt = DateTime.Now;
                db.Lessons.InsertOnSubmit(lesson);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteLesson(Lesson lesson)
        {
            try
            {
                Lesson oldLesson = db.Lessons.FirstOrDefault(l => l.lessonId == lesson.lessonId);
                oldLesson.isDeleted = 1;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditLesson(Lesson lesson)
        {
            try
            {
                Lesson oldLesson = db.Lessons.FirstOrDefault(l => l.lessonId == lesson.lessonId);
                oldLesson.lessonDate = lesson.lessonDate;
                oldLesson.startTime = lesson.startTime;
                oldLesson.endTime = lesson.endTime;
                oldLesson.lecturerId = lesson.lecturerId;
                oldLesson.subjectId = lesson.subjectId;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Lesson> GetLesson()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var lessons = (from lesson in db.Lessons
                                  where lesson.isDeleted == 0
                                  select lesson).ToList();
                    return lessons;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckDuplicateLesson(DateTime lessonDate, TimeSpan? startTime, TimeSpan? endTime)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
  
                    var duplicateLesson = db.Lessons
                                            .Where(lesson => lesson.isDeleted == 0 &&
                                                             lesson.lessonDate.Date == lessonDate.Date && 
                                                             lesson.startTime == startTime &&
                                                             lesson.endTime == endTime)
                                            .FirstOrDefault();

                    return duplicateLesson != null; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Lecturer> GetLecturer()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var lecturers =
                                    (from lecturer in db.Lecturers
                                     where lecturer.isDeleted == 0
                                     select lecturer).ToList();
                    return lecturers;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Subject> GetSubject()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var subjects =
                                    (from subject in db.Subjects
                                     where subject.isDeleted == 0
                                     select subject).ToList();
                    return subjects;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public (List<LessonDetail> lesson, int totalLesson, int totalPages) GetLessonSearch(string search, int page, int pageSize)
        {
            using (var db = new DataClasses1DataContext())
            {
                try
                {

                    var query = from lesson in db.Lessons
                                join lecturer in db.Lecturers on lesson.lecturerId equals lecturer.lecturerId
                                join subject in db.Subjects on lesson.subjectId equals subject.subjectId
                                where lesson.isDeleted == 0
                                select new LessonDetail
                                {
                                    subjectName = subject.subjectName,
                                    lessonId = lesson.lessonId,
                                    startTime = lesson.startTime,
                                    endTime = lesson.endTime,
                                    lecturerName = lecturer.lecturerName,
                                    lessonDate = lesson.lessonDate,
                                    createAt = lesson.createAt 
                                };


                    if (!string.IsNullOrEmpty(search))
                    {
                        search = search.ToLower();
                        query = query.Where(o =>
                            (o.subjectName != null && o.subjectName.ToLower().Contains(search)) ||
                            (o.lecturerName != null && o.lecturerName.ToLower().Contains(search))
                        );
                    }

                    var totalLessons = query.Count();

                    var totalPages = (int)Math.Ceiling((double)totalLessons / pageSize);


                    var lessons = query
                        .OrderBy(o => o.createAt)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    return (lessons, totalLessons, totalPages);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while retrieving lessons: " + ex.Message);
                }
            }
        }

        public Lesson GetLessonById(string lessonId)
        {
            using (var context = new DataClasses1DataContext())
            {
                return context.Lessons.FirstOrDefault(l => l.lessonId == lessonId && l.isDeleted == 0);
            }
        }

        public List<LessonService> LessonData()
        {
            List<LessonService> atrLesson = db.Lessons
               .Select(l => new LessonService
               {
                   lessonId = l.lessonId,
                   lessonDate = l.lessonDate,
                   startTime = l.startTime,
                   endTime = l.endTime,
                   lecturerId = l.lecturerId,
                   subjectId = l.subjectId,
               }).ToList();

            return atrLesson;
        }
    }
}
