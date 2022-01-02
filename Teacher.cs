using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCoursework
{
    public class Teacher
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Number { get; set; }
        public int Experience { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, string surname, string middleName, string number, int experience, string subject)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Number = number;
            Experience = experience;
            Subject = subject;
        }

        public override string ToString() {
            return $"{Surname} {Name[0]}. {MiddleName[0]}.";
        }
    }
}
