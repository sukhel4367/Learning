using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager1
{

    public class Student
    {
        public string StudentName { get; set; }
        public Dictionary<string, int> SubjectMarks { get; set; }

        public Student(string StudentName)
        {
            this.StudentName = StudentName;
            SubjectMarks = new Dictionary<string, int>();
        }


        public void AddMark(string subject, int mark)
        {
            SubjectMarks[subject] = mark;
        }
        public void Print()
        {
            Console.WriteLine($"Student Name : {StudentName}");
            foreach (var item in SubjectMarks)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

    }
}
