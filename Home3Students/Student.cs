using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;

        public Student(string name, string surname, string group)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
        }

        public string Tostring()
        {
            return $"{Name}";
        }
    }
}
