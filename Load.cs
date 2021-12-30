using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCoursework
{

    public class Load
    {
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
        public int HourCount { get; set; }
        public string Subject { get; set; }
        public string LessonType { get; set; }
        public int Payment { get; set; }

        public Load(Teacher teacher, Group group, int hourCount, string subject, string lessonType, int payment)
        {
            Teacher = teacher;
            Group = group;
            HourCount = hourCount;
            Subject = subject;
            LessonType = lessonType;
            Payment = payment;
        }

    }
}
