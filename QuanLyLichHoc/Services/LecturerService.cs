using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichHoc.Models;
using QuanLyLichHoc.Interfaces;

namespace QuanLyLichHoc.Services
{
    public class LecturerService: ILecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<LecturerService> LectureData()
        {
            List<LecturerService> atrLectures = db.Lectures
                .Select(l => new LecturerService
                {
                    Id = l.LectureID,
                    Name = l.LectureName,
                    Gender = l.LectureGender,
                    Address = l.LectureAddress,
                    Status = l.LectureStatus
                }).ToList();

            return atrLectures;
        }
        public Lecture GetLecturerById(int lectureId)
        {
            using (var context = new DataClasses1DataContext())
            {
                return context.Lectures.FirstOrDefault(l => l.LectureID == lectureId);
            }
        }

        public List<Lecture> GetLecturer()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    return db.Lectures.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddLecturer(Lecture lecture)
        {
            try
            {
                //lecture.LectureID = Guid.NewGuid().ToString();
                db.Lectures.InsertOnSubmit(lecture);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditLecturer(Lecture lecture)
        {
            try
            {
                Lecture oldLecturer = db.Lectures.FirstOrDefault(l => l.LectureID == lecture.LectureID);
                oldLecturer.LectureGender = lecture.LectureGender;
                oldLecturer.LectureAddress = lecture.LectureAddress;
                oldLecturer.LectureName = lecture.LectureName;
                oldLecturer.LectureGender = lecture.LectureGender;
                oldLecturer.LectureStatus = lecture.LectureStatus;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void DeleteLecturer(Lecture lecture)
        {
            try
            {
                Lecture oldLecturer = db.Lectures.FirstOrDefault(l => l.LectureID == lecture.LectureID);
                db.Lectures.DeleteOnSubmit(oldLecturer);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public (List<Lecture> Lecturer, int totalLecturer, int TotalPages) GetLecturer(string search, int page, int pageSize)
        {
            using (var db = new DataClasses1DataContext())
            {
                try
                {
                    var query = db.Lectures.AsQueryable();

                    if (!string.IsNullOrEmpty(search))
                    {
                        search = search.ToLower();
                        query = query.Where(o =>
                            o.LectureName.ToLower().Contains(search) ||
                            o.LectureAddress.ToLower().Contains(search) ||
                            o.LectureGender.Contains(search) ||
                            o.LectureStatus.ToLower().Contains(search)
                        );
                    }
                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var Employees = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                    return (Employees, totalEmployees, totalPages);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
