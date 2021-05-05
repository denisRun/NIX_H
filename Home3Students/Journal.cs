using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Journal
    {
        protected List<Student> Students;
        protected Dictionary<Student, List<int>> Marks;

        public Journal()
        {
            Students = new List<Student>();
            Marks = new Dictionary<Student, List<int>>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            Marks[student] = new List<int>();
        }

        public void AddMark(Student student, int mark)
        {
            if (mark >= 0 && mark <= 100)
            {
                Marks[student].Add(mark);
            }
        }

        public double AvgMark(Student student)
        {
            double res = (from t in Marks
                          where t.Key == student
                          select t.Value).First().Average();

            return res;
        }       

        public void BadStudents()
        {
            var lst =  (from t in Marks
                       where t.Value.Min() < 60
                       select t.Key) ;
            foreach(var i in lst)
            {
                Student s = (Student)i;
                Console.WriteLine(s.Name +" "+ s.Surname + " " + s.Group);
            }
        }

        public void PrintJournal()
        {
            foreach(var stud in Students)
            {
                Console.WriteLine(stud.Name + " " + stud.Surname + " " + stud.Group +" - " + AvgMark(stud));
            }
        }
    }
}
