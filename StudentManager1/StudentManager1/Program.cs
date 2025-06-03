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

            Console.Write($"Enter Subject Name of Student - {i} :");
            string subjectName = Console.ReadLine();

            Console.Write($"Enter Subject Mark of Student - {i} :");
            int subjectMark = int.Parse(Console.ReadLine());

            Student student = new Student(studentName);
            student.AddMark(subjectName, subjectMark);
            studentList.Add(student);
        }

        Console.Write($"Type Y or y to view Student Data ");
        string option = Console.ReadLine();
        if (option == "Y" || option == "y")
        {
            foreach (var student in studentList)
            {
                student.Print();
            }
        }
    }
}
