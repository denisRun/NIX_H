using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("a", "a", "a");
            Student st2 = new Student("b", "b", "b");
            Student st3 = new Student("c", "c", "c");
            Student st4 = new Student("d", "d", "d");

            Journal j = new Journal();
            j.AddStudent(st1);
            j.AddStudent(st2);
            j.AddStudent(st3);
            j.AddStudent(st4);

            j.AddMark(st1, 70);
            j.AddMark(st1, 90);
            j.AddMark(st2, 40);
            j.AddMark(st3, 30);
            j.AddMark(st4, 65);
            j.AddMark(st4, 70);
            Console.WriteLine("Avarage mark " + j.AvgMark(st1));

            Console.WriteLine("Bad Students");
            j.BadStudents();

            Console.WriteLine("Journal");
            j.PrintJournal();
        }
    }
}
