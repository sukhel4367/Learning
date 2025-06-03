using StudentManager1;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();

        Console.WriteLine("No of students wanted to add");
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.Write($"Enter Student Name  :");
            string studentName = Console.ReadLine();

            //Console.Write($"Enter Subject Name of Student - {i} :");
            //string subjectName = Console.ReadLine();

            //Console.Write($"Enter Subject Mark of Student - {i} :");
            //int subjectMark = int.Parse(Console.ReadLine());

            Student student = new Student(studentName);

            while (true)
            {
                Console.Write($"Enter Subject Name for Student - {studentName} : ");
                string subjectName = Console.ReadLine();

                Console.Write($"Enter Subject Mark for {subjectName} : ");
                int subjectMark = int.Parse(Console.ReadLine());

                student.AddMark(subjectName, subjectMark);

                Console.Write("Add another subject for this student? (Y/N): ");
                string subOption = Console.ReadLine();
                if (subOption != "Y" && subOption != "y")
                    break;
            }
            studentList.Add(student);
        }

        
        foreach (var student in studentList)
        {
            student.Print();
        }
        
    }
}
