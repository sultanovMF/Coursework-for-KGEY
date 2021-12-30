using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCoursework
{
    public class Group
    {
        public string Specialization { get; set; }
        public string Department { get; set; }
        public int StudentCount { get; set; }

        public Group(string specialization, string department, int studentCount)
        {
            Specialization = specialization;
            Department = department;
            StudentCount = studentCount;
        }

        public override string ToString()
        {
            return $"{Specialization} - {Department}";
        }
    }
}
