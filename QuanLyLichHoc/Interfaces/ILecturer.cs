using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichHoc.Models;
using QuanLyLichHoc.Services;

namespace QuanLyLichHoc.Interfaces
{
    public interface ILecturer
    {
        List<LecturerService> LectureData();
        List<Lecture> GetLecturer();
        (List<Lecture> Lecturer, int totalLecturer, int TotalPages) GetLecturer(string search, int page, int pageSize);
        Lecture GetLecturerById(int lectureId);
        void EditLecturer(Lecture lecture);
        void AddLecturer(Lecture lecture);
        void DeleteLecturer(Lecture lecture);
    }
}
