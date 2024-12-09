using QuanLyLichHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichHoc.Services
{
    internal class StudentService
    {
        public string studentId { get; set; }
        public string studentName { get; set; }
        public string studentEmail { get; set; }
        public string studentPhone { get; set; }
        public string studentGender { get; set; }
        public DateTime? studentDob { get; set; }

        public DateTime? createAt { get; set; }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<StudentService> LectureData()
        {
            List<StudentService> atrLectures = db.Students
                .Select(l => new StudentService
                {
                    studentId = l.studentId,
                    studentName = l.studentName,
                    studentEmail = l.studentEmail,
                    studentPhone = l.studentPhone,
                    studentGender = l.studentGender,
                    studentDob = l.studentDob,
                }).ToList();

            return atrLectures;
        }
        public Student GetLecturerById(string lectureId)
        {
            using (var context = new DataClasses1DataContext())
            {
                return context.Students.FirstOrDefault(l => l.studentId == lectureId && l.isDeleted == 0);
            }
        }

        public List<Student> GetLecturer()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var lecturers = (from lesson in db.Students
                                     where lesson.isDeleted == 0
                                     select lesson).ToList();
                    return lecturers;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddLecturer(Student lecture)
        {
            try
            {
                lecture.studentId = Guid.NewGuid().ToString().Substring(0, 20);
                lecture.isDeleted = 0;
                lecture.createAt = DateTime.Now;
                db.Students.InsertOnSubmit(lecture);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditLecturer(Student lecture)
        {
            try
            {
                Student oldLecturer = db.Students.FirstOrDefault(l => l.studentId == lecture.studentId);
                oldLecturer.studentGender = lecture.studentGender;
                oldLecturer.studentPhone = lecture.studentPhone;
                oldLecturer.studentDob = lecture.studentDob;
                oldLecturer.studentName = lecture.studentName;
                oldLecturer.studentEmail = lecture.studentEmail;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void DeleteLecturer(Student lecture)
        {
            try
            {
                Student oldLecturer = db.Students.FirstOrDefault(l => l.studentId == lecture.studentId);
                oldLecturer.isDeleted = 1;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public (List<StudentService> Lecturer, int totalLecturer, int TotalPages) GetLecturer(string search, int page, int pageSize)
        {
            using (var db = new DataClasses1DataContext())
            {
                try
                {
                    var query = db.Students.Where(o => o.isDeleted == 0).AsQueryable();

                    if (!string.IsNullOrEmpty(search))
                    {
                        search = search.ToLower();
                        query = query.Where(o =>
                            (o.studentName != null && o.studentName.ToLower().Contains(search)) ||
                            (o.studentEmail != null && o.studentEmail.ToLower().Contains(search)) ||
                            (o.studentGender != null && o.studentGender.ToLower().Contains(search)) ||
                            (o.studentPhone != null && o.studentPhone.ToLower().Contains(search))
                        );
                    }
                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var lecturers = query
                        .OrderBy(o => o.createAt)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .Select(o => new StudentService
                        {
                            studentId = o.studentId,
                            studentName = o.studentName,
                            studentEmail = o.studentEmail,
                            studentPhone = o.studentPhone,
                            studentGender = o.studentGender,
                            studentDob = o.studentDob,
                            createAt = o.createAt,
                        })
                        .ToList();


                    return (lecturers, totalEmployees, totalPages);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
