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
        List<Lecturer> GetLecturer();
        (List<LecturerService> Lecturer, int totalLecturer, int TotalPages) GetLecturer(string search, int page, int pageSize);
        Lecturer GetLecturerById(string lectureId);
        void EditLecturer(Lecturer lecture);
        void AddLecturer(Lecturer lecture);
        void DeleteLecturer(Lecturer lecture);
    }
}
