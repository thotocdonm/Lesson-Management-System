using QuanLyLichHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyLichHoc.Services
{
    internal class SubjectEnrollmentService
    {
        DataClasses1DataContext db = new DataClasses1DataContext("Data Source=DESKTOP-UOULN0V\\SQLEXPRESS;Initial Catalog=Lesson_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");

        public List<Subject> GetAll()
        {
            List<Subject> rs = new List<Subject>();
            try
            {
                var qr = db.Subjects.Where(o => o.isDeleted == 0);
                rs = qr.ToList();
            }
            catch (Exception ex)
            {
                rs = null;

            }
            return rs;
        }
    }
}
