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
        public string lecturerId { get; set; }
        public string lecturerName { get; set; }
        public string lecturerEmail { get; set; }
        public string lecturerPhone { get; set; }
        public string lecturerGender { get; set; }
        public DateTime? lecturerDob { get; set; }

        public DateTime? create_at { get; set; }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<LecturerService> LectureData()
        {
            List<LecturerService> atrLectures = db.Lecturers
                .Select(l => new LecturerService
                {
                    lecturerId = l.lecturerId,
                    lecturerName = l.lecturerName,
                    lecturerGender = l.lecturerGender,
                    lecturerEmail = l.lecturerEmail,
                    lecturerPhone = l.lecturerPhone,
                    lecturerDob = l.lecturerDob,
                }).ToList();

            return atrLectures;
        }
        public Lecturer GetLecturerById(string lectureId)
        {
            using (var context = new DataClasses1DataContext())
            {
                return context.Lecturers.FirstOrDefault(l => l.lecturerId == lectureId && l.isDeleted == 0);
            }
        }

        public List<Lecturer> GetLecturer()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var lecturers = db.Lecturers
                              .Where(l => l.isDeleted == 0)
                              .Select(l => new Lecturer
                              {
                                  lecturerId = l.lecturerId,
                                  lecturerName = l.lecturerName,
                                  lecturerEmail = l.lecturerEmail,
                                  lecturerPhone = l.lecturerPhone,
                                  lecturerDob = l.lecturerDob,
                              }).ToList();
                    return lecturers;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddLecturer(Lecturer lecture)
        {
            try
            {
                lecture.lecturerId = Guid.NewGuid().ToString().Substring(0, 20);
                lecture.isDeleted = 0;
                lecture.create_at = DateTime.Now;
                db.Lecturers.InsertOnSubmit(lecture);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditLecturer(Lecturer lecture)
        {
            try
            {
                Lecturer oldLecturer = db.Lecturers.FirstOrDefault(l => l.lecturerId == lecture.lecturerId);
                oldLecturer.lecturerGender = lecture.lecturerGender;
                oldLecturer.lecturerPhone = lecture.lecturerPhone;
                oldLecturer.lecturerDob = lecture.lecturerDob;
                oldLecturer.lecturerName = lecture.lecturerName;
                oldLecturer.lecturerEmail = lecture.lecturerEmail;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void DeleteLecturer(Lecturer lecture)
        {
            try
            {
                Lecturer oldLecturer = db.Lecturers.FirstOrDefault(l => l.lecturerId == lecture.lecturerId);
                oldLecturer.isDeleted = 1;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public (List<LecturerService> Lecturer, int totalLecturer, int TotalPages) GetLecturer(string search, int page, int pageSize)
        {
            using (var db = new DataClasses1DataContext())
            {
                try
                {
                    var query = db.Lecturers.Where(o => o.isDeleted == 0).AsQueryable();

                    if (!string.IsNullOrEmpty(search))
                    {
                        search = search.ToLower();
                        query = query.Where(o =>
                            (o.lecturerName != null && o.lecturerName.ToLower().Contains(search)) ||
                            (o.lecturerEmail != null && o.lecturerEmail.ToLower().Contains(search)) ||
                            (o.lecturerGender != null && o.lecturerGender.ToLower().Contains(search)) ||
                            (o.lecturerPhone != null && o.lecturerPhone.ToLower().Contains(search))
                        );
                    }
                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var lecturers = query
                        .OrderBy(o => o.create_at)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .Select(o => new LecturerService
                        {
                            lecturerId = o.lecturerId,
                            lecturerName = o.lecturerName,
                            lecturerEmail = o.lecturerEmail,
                            lecturerPhone = o.lecturerPhone,
                            lecturerGender = o.lecturerGender,
                            lecturerDob = o.lecturerDob,
                            create_at = o.create_at,
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
