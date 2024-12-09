using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichHoc.Models
{
    internal class LessonDetail
    {


        public string lessonId { get; set; }
        public string subjectName { get; set; }

        public string lecturerName { get; set; }

        public TimeSpan? startTime { get; set; }

        public TimeSpan? endTime { get; set; }
        public DateTime lessonDate { get; set; }
        public DateTime? createAt { get; set; }
    }
}
